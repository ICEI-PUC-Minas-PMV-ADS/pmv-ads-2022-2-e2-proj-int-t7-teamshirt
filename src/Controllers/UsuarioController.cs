using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using team_shirt.Data;
using team_shirt.Models;

namespace team_shirt.Controllers
{
    [AllowAnonymous]
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Usuario usuario)
        {
            var user = await _context.Usuario
               .FirstOrDefaultAsync(m => m.Email == usuario.Email);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View();
            }

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(usuario.Senha, user.Senha);

            if (isValidPassword)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Perfil.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);

                var authenticationProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(3),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(claimsPrincipal, authenticationProperties);

                return Redirect("/");
            }

            ViewBag.Message = "Email e/ou senha inválidos!";
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Usuario");
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Usuario.FirstOrDefaultAsync(m => m.Email == usuario.Email);

                if (user != null)
                {
                    ViewBag.Message = "Já existe usuário com esse email cadastrado";
                    return View();
                }

                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Add(usuario);

                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "Usuario");
            }

            return View(usuario);
        }

    }
}
