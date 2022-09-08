# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feito pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Empresário Eustaqui Motta  | Aumentar a sua exposição no mercado de camisas raras de futebol | Expandir o seu alcance, para que os seus produtos alcancem uma maior quantidade de potenciais clientes.   |
|Empresário Eustaquio Motta | Quero criar um portal para poder expor todos os meus produtos que estão para venda | Devido ao espaço limitado em sua loja física, muitos produtos que ele quer comercializar acabam não recebendo o destaque adequado para a venda dos mesmos. |
| Cliente Enzo Guttemberg | Quero Continuar a tradição da família de colecionar artigos de roupas de futebol da época de seu avô. | Manter a tradição de colecionador na família, ensinada pelo seu avô. |
| Cliente Enzo Guttemberg | Um portal de vendas que possa encontrar produtos exclusivos para poder expandir a sua coleção. | Aumentar a vaiedade de produtos em sua coleção. |
| Empresário Francisco Fagundes | Criar um portal de vendas on-line onde os clientes não precisem se preocupar com a originalidade ou a qualidade do produto. | Entrar no mercado de vendas de camisas raras, garantindo segurança para o consumidor, fornecendo garantia dos produtos e a sua genuinidade. |
| Cliente Clara Rezende | Poder apresentar o seu namorado com uma camisa de futebol rara do seu time de coração. | Agradar o seu cônjugue, escolher um presente que seja um gosto compartilhado entre ambas as partes. |
| Cliente Arthur Souza | Encontrar uma camiseta retro de futebol específica, de acesso muito limitado. | Poder assistir aos jogos da copa do mundo com esta camisa específica. |
| Cliente Arthur Souza | Presentear os membros de sua família com o mesmo produto para poderem torcer juntos pela seleção. | Satisfazer o seu desejo supersticioso, poder agradar os membros de sua família no momento de assistir os jogos. |
| Cliente Marcelo Falcão | Poder publicar na internet avaliações de camisas de futebol exclusivas de pouco acesso. | Gerar conteùdo em suas redes sociais, aumentar a margem de visualização do seu conteúdo. |
| Cliente Marcelo Falcão | Adquirir produtos raros com o intuito de vender novamente no futuro, por um preço mais elevado do que o que foi pago. | Investir na compra de camisas raras de futebol com o intuito de obter lucro no futuro. |



## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve ter uma homr page intuitiva e com o menu navegável. | ALTA | 
|RF-002| A aplicação deve ter os produtos destacados na página inicial, como forma de sugestão ao usuário. | ALTA |
|RF-003| A aplicação deve conter uma linguagem acessível para a maioria, com poucos termos técnicos.  | ALTA |
|RF-004| Os preços devem ser explícitos para todos, melhorando a confiabilidade. | ALTA |
|RF-005| A aplicação deve ter um breve resumo sobre quem somos. | MÉDIA |
|RF-006| A aplicação deve conter uma página sobre política de trocas e devoluções e como realizar essas instruções. | MÉDIA |
|RF-007| A aplicação deve conter um campo de busca para produtos. | MÉDIA |
|RF-008| A aplicação deve apresentar um catálogo de seus produtos disponíveis. | MÉDIA |
|RF-009| A aplicação deve apresentar uma área para cadastro e login de usuário. | ALTA |
|RF-010| A aplicação deve apresentar uma área de carrinho em que o usuário irá adicionar seus itens para realização da compra. | ALTA |
|RF-011| A aplicação deve apresentar um registro de pedidos do usuário. | MÉDIA |
|RF-012| A aplicação deve conter na página do usuário acesso aos seus dados cadastrados para futurações alterações. | BAIXA |
|RF-013| A aplicação deve conter uma área em que o usuário possa adicionar itens desejados para futuras compras. | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku).  | ALTA | 
|RNF-002| O site deverá ser responsivo permitido a visualização em um celular de forma adequada. |  ALTA |
|RNF-003| O site deve ter bom nível de contraste entre os elementos da tela em conformidade. | MÉDIA |
|RNF-004| O site deve ser compatível com as principais fontes e navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). | ALTA |
|RNF-005| Uso de componentes gráficos (grids, barras de rolagem, menus). | ALTA |



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku). |
|02| O site deverá ser responsivo permitindo a visualização em um celular de forma adequada. |
|03| O site deve ter bom nível de contraste entre os elementos da tela em conformidade. |



## Diagrama de Casos de Uso

<img src="img/diagramadecasodeuso.png" alt="Diagrama de Caso de Uso">
