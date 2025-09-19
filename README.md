PexelsProject
📖 Descrição

O PexelsProject é uma API RESTful desenvolvida em ASP.NET Core que integra com a API do Pexels — uma plataforma de fotos e vídeos livres de direitos autorais.

Atualmente, a API já permite buscar fotos de forma simples e eficiente, demonstrando a integração com uma API externa.

O projeto foi criado com o intuito de praticar o desenvolvimento de APIs web com .NET 8+ no estilo Minimal API.

🛠️ Tecnologias Utilizadas

Framework: ASP.NET Core (Minimal API)

Linguagem: C#

Versão do .NET: 8.0 ou superior

Documentação: OpenAPI / Swagger

Chamadas HTTP externas: HttpClient para integração com a API do Pexels

Banco de dados: Não implementado (pode vir futuramente com EF Core)

Outros: Configuração via appsettings.json ou variáveis de ambiente

📌 Pré-requisitos

.NET 8 SDK instalado

Acesso à internet para consumir a API do Pexels

(Opcional) Chave de API do Pexels para usar os endpoints de busca

⚙️ Instalação e Configuração

1. Clone o repositório:

git clone https://github.com/AnaC380/PexelsProject.git
cd PexelsProject

2. Restaure as dependências:

dotnet restore

3. Configure a chave da API do Pexels:

. Crie uma conta gratuita no Pexels e pegue sua chave de API.

. Adicione a chave no arquivo appsettings.json ou defina como uma variável de ambiente.

json:

// appsettings.json
{
  "Pexels": {
    "ApiKey": "sua_chave_aqui"
  }
}

▶️ Como Executar

O projeto pode ser executado em ambiente de Desenvolvimento para que as configurações do arquivo appsettings.Development.json sejam lidas.

Windows PowerShell:

$env:ASPNETCORE_ENVIRONMENT="Development"; dotnet run

Unix/Linux:

export ASPNETCORE_ENVIRONMENT=Development && dotnet run

🔗 O servidor rodará em:

. HTTP: http://localhost:5000


📡 Endpoints Disponíveis

. GET / → Mensagem de boas-vindas

. GET /weatherforecast → Previsão de tempo simulada

. GET /photos/{query} → Busca fotos por palavra-chave (ex: /photos/nature)

. GET /swagger → Documentação interativa da API (em ambiente de desenvolvimento)

📂 Estrutura do Projeto

. PexelsProject.Presentation: Camada que hospeda a API (arquivo Program.cs, configuração, endpoints).

. PexelsProject.Domain: Domínio da aplicação (entidades, regras de negócio).

. PexelsProject.Infrastructure: Integrações externas, como a chamada para a API do Pexels.

📌 Status do Projeto

✅ Funcionalidades básicas de busca concluídas.

🚀 Futuras Melhorias

 . Implementar busca por vídeos (/videos/{query})

 . Adicionar paginação nos resultados

 . Adicionar filtros por orientação, cor, etc.

 . Criar testes unitários e de integração

 . Configurar CI/CD no GitHub Actions

 . Deploy automatizado em Azure ou AWS.

🤝 Contribuição

Contribuições são bem-vindas!

1. Faça um fork do repositório

2. Crie uma branch para sua funcionalidade:

git checkout -b feature/nova-funcionalidade

3. Faça seus commits com mensagens claras

4. Faça o push para sua branch no seu fork

5. Abra um Pull Request para este repositório

📜 Licença

Este projeto está licenciado sob a MIT License.

📬 Contato

. Autora: Ana C. (AnaC380)

. GitHub: AnaC380

Se tiver dúvidas, sugestões ou quiser colaborar, abra uma issue ou entre em contato!
