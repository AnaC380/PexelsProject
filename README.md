PexelsProject



Descrição

O PexelsProject é uma API desenvolvida em ASP.NET Core que integra (ou será integrada) com a API do Pexels — uma plataforma de fotos e vídeos livres de direitos autorais. Permite buscar e exibir mídias de forma simples e eficiente. O projeto foi criado com o intuito de praticar o desenvolvimento de APIs web com .NET 8+ no estilo Minimal API.

Hoje, já possui endpoints básicos (rota inicial de boas-vindas, previsão do tempo de exemplo para testes) e está planejado adicionar funcionalidades completas de busca de fotos/vídeos, paginação, filtros, etc.

Tecnologias Utilizadas

> Framework: ASP.NET Core (Minimal API)
> Linguagem: C#
> Versão do .NET: 8.0 ou superior
> Documentação: OpenAPI / Swagger 
> Chamadas HTTP externas: HttpClient para integração com a API do Pexels
> Banco de dados: não implementado ainda (pode vir futuramente com EF Core)
> Outros componentes auxiliares: geração de dados exemplo, configuração via appsettings.json ou variáveis de ambiente

Pré-requisitos

> .NET 8 SDK instalado
> Acesso à internet para consumir a API do Pexels 
> (Opcional) Chave de API do Pexels para endpoints de busca reais

Instalação e Configuração

1. Clone o repositório:

git clone https://github.com/AnaC380/PexelsProject.git
cd PexelsProject

2. Restaure as dependências:
dotnet restore

3. Compile o projeto:
dotnet build

4. Configure a chave da API do Pexels (se for usar os endpoints de busca):

> Crie uma conta gratuita no Pexels e pegue sua chave de API 
> Adicione a chave em appsettings.json ou defina como variável de ambiente:

json:

{
  "PexelsApiKey": "sua_chave_aqui"
}

COMO_EXECUTAR

dotnet run --project PexelsProject.Presentation/PexelsProject.Presentation.csproj

 O servidor rodará em:
 
> HTTP: http://localhost:5000 
> HTTPS: https://localhost:5001

Endpoints disponíveis atualmente

> GET / — Mensagem de boas-vindas
> GET /weatherforecast — Previsão de tempo simulada (dados de exemplo)
> GET /swagger — Documentação interativa da API (quando em ambiente de desenvolvimento)

Funcionalidades Planejadas

> GET /photos/search?query={termo}&per_page=10 — Buscar fotos por palavra-chave 
> GET /videos/search?query={termo} — Buscar vídeos
> GET /photos/{id} — Detalhes de uma foto específica
> Paginação nos resultados
> Filtros por orientação, cor, etc.
> Autenticação/autorização via chave da API


Estrutura do Projeto

> PexelsProject.Presentation: camada que hospeda a API (arquivo Program.cs, configuração, endpoints) 
> PexelsProject.Domain: domínio da aplicação (entidades, regras de negócio)
> PexelsProject.Infrastructure: integrações externas, persistência, etc.
> (Possíveis outras camadas como Services, Models, etc., conforme for evoluindo)

📦 Deploy

Explica como rodar o projeto fora do ambiente local (exemplo: Docker, Azure, AWS, etc.).
## Deploy

- O projeto pode ser publicado usando o comando:

  ```bash
  dotnet publish -c Release
. Também é possível rodar em container Docker:
docker build -t pexelsproject .
docker run -d -p 5000:5000 pexelsproject


---

### ✅ Testes
Mostra como rodar testes automatizados (se você for implementar futuramente).

```md
## Testes

- Para executar os testes automatizados:

  ```bash
  dotnet test

. Os testes serão adicionados futuramente em uma camada dedicada (PexelsProject.Tests).



---

### 🛠️ Futuras Melhorias
Uma lista de melhorias que você pode ir riscando conforme implementar.

```md
## Futuras Melhorias

- [ ] Implementar integração real com a API do Pexels  
- [ ] Adicionar paginação nas consultas  
- [ ] Criar testes unitários e de integração  
- [ ] Configurar CI/CD no GitHub Actions  
- [ ] Deploy automatizado em Azure ou AWS  

## Status do Projeto

🚧 Em desenvolvimento 🚧




Contribuição

Contribuições são bem-vindas! Para contribuir:

1. Faça um fork do repositório
2. Crie uma branch para sua funcionalidade:

git checkout -b feature/nova-funcionalidade


3. Faça seus commits com mensagens claras
4.Faça o push para sua branch no seu fork
5. Abra um Pull Request para este repositório

Antes de contribuir, leia se há um Código de Conduta ou diretrizes específicas (caso tenha) para manter alinhamento.

Licença

Este projeto está licenciado sob a MIT License. Veja o arquivo LICENSE para mais detalhes.

Contato

Autora: Ana C. (AnaC380)
GitHub: AnaC380

Se tiver dúvidas, sugestões ou quiser colaborar, abra uma issue ou entre em contato!
