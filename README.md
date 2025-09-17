PexelsProject
Descrição
O PexelsProject é um projeto de API em ASP.NET Core que integra com a API do Pexels (plataforma de fotos e vídeos stock gratuitos). Ele permite buscar e exibir fotos e vídeos de forma simples e eficiente. 
O projeto foi criado para praticar desenvolvimento de APIs web, utilizando o modelo minimal API do .NET 8+.
Atualmente, inclui endpoints básicos como uma rota inicial de boas-vindas e uma previsão de tempo de exemplo (para testes iniciais). 
Em breve, serão adicionados endpoints para integração real com o Pexels, como busca de imagens por palavra-chave.
Tecnologias Utilizadas

Framework: ASP.NET Core (Minimal API)
Linguagem: C#
Versão do .NET: 8.0 ou superior
Ferramentas Adicionais:

OpenAPI/Swagger para documentação da API
HTTP Client para chamadas à API externa do Pexels


Banco de Dados: Não implementado (pode ser adicionado com Entity Framework Core no futuro)
Outros: Random para geração de dados de exemplo

Pré-requisitos

Instalação e Configuração

Clone o Repositório:
1. Abra o terminal e execute:
 git clone https://github.com/AnaC380/PexelsProject.git
 cd PexelsProject

2. Restaure as Dependências:
  dotnet restore

3. Compile o Projeto:
  dotnet build


Configure a Chave da API do Pexels (opcional para endpoints futuros):

. Crie uma conta gratuita no Pexels e obtenha uma chave de API.
. Adicione a chave no arquivo appsettings.json ou via variáveis de ambiente:

{
  "PexelsApiKey": "sua_chave_aqui"
}

Como Executar


1. RODAR O PROJETO:
No diretório raiz do projeto (ou no subprojeto de apresentação, se aplicável), execute:
dotnet run --project PexelsProject.Presentation/PexelsProject.Presentation.csproj

O servidor iniciará em http://localhost:5000 (ou HTTPS em https://localhost:5001).


2. ACESSE OS ENDPOINTS:

Página Inicial: http://localhost:5000/ – Exibe uma mensagem de boas-vindas.
Previsão do Tempo (Exemplo): http://localhost:5000/weatherforecast – Retorna dados JSON de previsão simulada.
Swagger (em Desenvolvimento): http://localhost:5000/swagger – Documentação interativa da API.

Exemplo de saída da previsão:
json:  
{
    "date": "2025-09-18",
    "temperatureC": 25,
    "temperatureF": 77,
    "summary": "Warm"
  }

3. TESTES:
Use ferramentas como Postman, Insomnia ou o navegador para testar os endpoints.
Para modo de desenvolvimento, certifique-se de que a variável ASPNETCORE_ENVIRONMENT=Development.

Estrutura do Projeto

PexelsProject.Presentation: Camada de apresentação com o Minimal API (arquivo Program.cs).
Outras Pastas (se aplicável): Models, Services, Controllers (a serem expandidos).
Arquivos Principais:

Program.cs: Configuração da API e endpoints.
appsettings.json: Configurações do ambiente.
WeatherForecast.cs: Modelo de exemplo (record).


ENDPOINTS ATUAIS E FUTUROS
Atuais

GET / – Mensagem de boas-vindas.
GET /weatherforecast – Previsão de tempo simulada (para testes).

PLANEJADOS (Integração com Pexels)

- GET /photos/search?query={termo}&per_page=10 – Busca fotos por palavra-chave.
- GET /videos/search?query={termo} – Busca vídeos.
- GET /photos/{id} – Detalhes de uma foto específica.
- Suporte a paginação, filtros por orientação/cor e autenticação via chave API.

CONTRIBUIÇÃO
Contribuições são bem-vindas! Siga estes passos:

. Fork o repositório.
. Crie uma branch para sua feature (git checkout -b feature/nova-funcionalidade).
. Commit suas mudanças (git commit -m 'Adiciona nova funcionalidade').
. Push para a branch (git push origin feature/nova-funcionalidade).
. Abra um Pull Request.

Por favor, leia o Código de Conduta e as Diretrizes de Contribuição (a serem criadas).
Licença
Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.
Contato

Autora: Ana C. (AnaC380)
GitHub: AnaC380
Issues: Abra uma issue para dúvidas ou sugestões.

Obrigada por visitar o projeto! Se precisar de ajuda para expandir ou integrar com o Pexels, é só pedir. 🚀





Editor de código como Visual Studio, Visual Studio Code ou JetBrains Rider
Acesso à internet para rodar o projeto localmente e testar endpoints
