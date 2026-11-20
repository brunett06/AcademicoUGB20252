# 🎓 Sistema Acadêmico (ASP.NET Core MVC)

Sistema web para cadastro de **instituições, departamentos e alunos**, desenvolvido em disciplina da graduação em Sistemas de Informação (UGB, 2025/2).

## Funcionalidades
- CRUD completo (listar, cadastrar, ver detalhes, editar e excluir) de **Instituições**, **Departamentos** e **Alunos**
- Departamento vinculado a uma instituição (relacionamento 1:N), com coordenador, telefone e e-mail
- Aluno com matrícula, e-mail, telefone e CEP
- Banco de dados versionado com migrations do Entity Framework

## Tecnologias
![C#](https://img.shields.io/badge/C%23-512BD4?style=flat&logo=dotnet&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET_8-512BD4?style=flat&logo=dotnet&logoColor=white)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET_Core_MVC-5C2D91?style=flat&logo=dotnet&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity_Framework_Core-68217A?style=flat&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)

## Estrutura
```
Academico/
├── Controllers/   # Aluno, Departamento, Instituicao
├── Models/        # entidades e relacionamentos
├── Views/         # telas em Razor
├── Data/          # AcademicoContext (EF Core)
└── Migrations/    # histórico do banco
```

## Como rodar
1. Ajuste a connection string do SQL Server no `appsettings.json`
2. Crie o banco: `dotnet ef database update`
3. Rode o projeto: `dotnet run --project Academico`

## O que pratiquei
Padrão MVC, modelagem de dados com relacionamentos, migrations com Entity Framework e formulários em Razor.

---
Feito por [Bruna Aganett](https://github.com/brunett06) · [Portfólio](https://brunaaganettportifolio.lovable.app)
