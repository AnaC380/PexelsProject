# PexelsProject

## 📖 Descrição

O **PexelsProject** é uma API RESTful desenvolvida em ASP.NET Core que integra com a [API do Pexels](https://www.pexels.com/api/) — uma plataforma de fotos e vídeos livres de direitos autorais.

A API permite buscar fotos de forma eficiente e segura, demonstrando boas práticas de arquitetura de software, incluindo **Clean Architecture**, **Injeção de Dependência** e **Separação de Responsabilidades**.

Este projeto foi criado com o intuito de demonstrar conhecimento em desenvolvimento de APIs profissionais com .NET 8.

---

## 🏗️ Arquitetura

O projeto segue os princípios da **Clean Architecture** (Arquitetura Limpa), organizado em camadas:

```
PexelsProject/
├── PexelsProject.Domain/          # Entidades e regras de negócio
├── PexelsProject.Application/      # Serviços, interfaces e lógica de aplicação
├── PexelsProject.Infrastructure/   # Integrações externas (API do Pexels)
└── PexelsProject.Presentation/     # API/Controllers e configuração
```

### Benefícios desta arquitetura:
- ✅ **Testabilidade**: Facilita a criação de testes unitários
- ✅ **Manutenibilidade**: Código organizado e fácil de manter
- ✅ **Escalabilidade**: Preparado para crescer
- ✅ **Separação de Responsabilidades**: Cada camada tem sua função específica
- ✅ **Injeção de Dependência**: Baixo acoplamento entre componentes

---

## 🛠️ Tecnologias Utilizadas

- **Framework**: ASP.NET Core 8.0
- **Linguagem**: C# 12
- **Arquitetura**: Clean Architecture com Controllers
- **Documentação**: Swagger/OpenAPI (Swashbuckle)
- **HTTP Client**: HttpClientFactory para integração com APIs externas
- **Configuração**: appsettings.json e variáveis de ambiente
- **Padrões**: Dependency Injection, Repository Pattern (preparado)

---

## 📌 Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado
- Acesso à internet para consumir a API do Pexels
- Chave de API do Pexels ([obtenha gratuitamente aqui](https://www.pexels.com/api/))

---

## ⚙️ Instalação e Configuração

### 1. Clone o repositório:

```bash
git clone https://github.com/AnaC380/PexelsProject.git
cd PexelsProject
```

### 2. Restaure as dependências:

```bash
dotnet restore
```

### 3. Configure a chave da API do Pexels:

Crie ou edite o arquivo `PexelsProject.Presentation/appsettings.Development.json`:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "Pexels": {
    "ApiKey": "SUA_CHAVE_AQUI"
  }
}
```

> **⚠️ Importante**: Nunca commite sua chave de API real! Use variáveis de ambiente em produção.

---

## ▶️ Como Executar

### Executar em modo Development:

**Windows (PowerShell):**
```powershell
$env:ASPNETCORE_ENVIRONMENT="Development"
dotnet run --project PexelsProject.Presentation
```

**Windows (CMD):**
```cmd
set ASPNETCORE_ENVIRONMENT=Development
dotnet run --project PexelsProject.Presentation
```

**Unix/Linux/macOS:**
```bash
export ASPNETCORE_ENVIRONMENT=Development
dotnet run --project PexelsProject.Presentation
```

### Executar com Hot Reload:

```bash
cd PexelsProject.Presentation
dotnet watch run
```

---

## 🔗 Endpoints da API

O servidor rodará em: **http://localhost:5000**

### Documentação Interativa

- **Swagger UI**: http://localhost:5000/swagger

### Endpoints Disponíveis

| Método | Endpoint | Descrição | Exemplo |
|--------|----------|-----------|---------|
| `GET` | `/api/photos/{query}` | Busca fotos por palavra-chave | `/api/photos/nature` |

#### Exemplo de Requisição:

```bash
curl http://localhost:5000/api/photos/mountains
```

#### Exemplo de Resposta:

```json
{
  "page": 1,
  "per_page": 10,
  "photos": [
    {
      "id": 2325447,
      "width": 5184,
      "height": 3456,
      "url": "https://www.pexels.com/photo/...",
      "photographer": "Francesco Ungaro",
      "photographer_url": "https://www.pexels.com/@francesco-ungaro",
      "src": {
        "original": "https://images.pexels.com/photos/...",
        "large2x": "https://images.pexels.com/photos/...",
        "large": "https://images.pexels.com/photos/...",
        "medium": "https://images.pexels.com/photos/...",
        "small": "https://images.pexels.com/photos/..."
      },
      "alt": "Hot air balloons float over landscape"
    }
  ]
}
```

---

## 📂 Estrutura do Projeto

```
PexelsProject/
│
├── PexelsProject.Domain/
│   └── (Entidades de domínio - futuro)
│
├── PexelsProject.Application/
│   ├── Interfaces/
│   │   └── IPhotoService.cs
│   └── Services/
│       └── PhotoService.cs
│
├── PexelsProject.Infrastructure/
│   └── (Integrações externas - futuro)
│
└── PexelsProject.Presentation/
    ├── Controllers/
    │   └── PhotosController.cs
    ├── Properties/
    │   └── launchSettings.json
    ├── Program.cs
    ├── appsettings.json
    └── appsettings.Development.json
```

---

## 📌 Status do Projeto

✅ **Concluído:**
- Arquitetura em camadas (Clean Architecture)
- Integração com API do Pexels
- Endpoint de busca de fotos
- Documentação Swagger/OpenAPI
- Injeção de dependência
- Configuração por ambiente (Development/Production)

---

## 🚀 Futuras Melhorias

- [ ] Implementar DTOs (Data Transfer Objects) para respostas tipadas
- [ ] Adicionar paginação customizável nos resultados
- [ ] Adicionar filtros por orientação, cor, tamanho
- [ ] Implementar busca de vídeos (`/api/videos/{query}`)
- [ ] Adicionar cache de requisições (Redis/In-Memory)
- [ ] Implementar tratamento de erros global (Exception Middleware)
- [ ] Adicionar logging estruturado (Serilog)
- [ ] Criar testes unitários e de integração (xUnit)
- [ ] Implementar rate limiting
- [ ] Adicionar autenticação/autorização (JWT)
- [ ] Configurar CI/CD no GitHub Actions
- [ ] Deploy automatizado em Azure ou AWS
- [ ] Adicionar Health Checks
- [ ] Containerização com Docker

---

## 🧪 Testes

(Em desenvolvimento)

```bash
dotnet test
```

---

## 🤝 Contribuição

Contribuições são bem-vindas! Siga os passos:

1. Faça um **fork** do repositório
2. Crie uma **branch** para sua funcionalidade:
   ```bash
   git checkout -b feature/nova-funcionalidade
   ```
3. Faça seus **commits** com mensagens claras e descritivas
4. Faça o **push** para sua branch:
   ```bash
   git push origin feature/nova-funcionalidade
   ```
5. Abra um **Pull Request** descrevendo suas alterações

---

## 📜 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

---

## 📬 Contato

- **Autora**: Ana C.
- **GitHub**: [@AnaC380](https://github.com/AnaC380)
- **LinkedIn**: [Seu LinkedIn aqui]

---

## 🙏 Agradecimentos

- [Pexels](https://www.pexels.com/) pela API gratuita de fotos
- Comunidade .NET pelo suporte e documentação

---

**⭐ Se este projeto foi útil para você, considere dar uma estrela no repositório!**
