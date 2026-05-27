# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project

ASP.NET Core Web API targeting **.NET 10** (`net10.0`). Single-project solution (`FirstWebApiClaudeSkillCommitCheck.slnx`). Nullable reference types and implicit usings are enabled.

## Commands

Run all commands from the project directory (`FirstWebApiClaudeSkillCommitCheck/`).

- Build: `dotnet build`
- Run (Development, HTTPS profile — Swagger UI at `/swagger`): `dotnet run --launch-profile https`
  - HTTPS: `https://localhost:7290`, HTTP: `http://localhost:5257`
- Run (HTTP only): `dotnet run --launch-profile http`
- Restore packages: `dotnet restore`
- Clean: `dotnet clean`

No test project exists yet — `dotnet test` will report no projects found.

`FirstWebApiClaudeSkillCommitCheck.http` contains sample requests usable from the VS / Rider HTTP client.

## Architecture

Conventional minimal-hosting ASP.NET Core layout:

- `Program.cs` is the composition root. It wires up MVC controllers (`AddControllers` / `MapControllers`), OpenAPI (`AddOpenApi` + `MapOpenApi`), and Swashbuckle Swagger (`AddSwaggerGen` / `UseSwagger` / `UseSwaggerUI`). Swagger and OpenAPI endpoints are only mapped in the Development environment. There is also a root `MapGet("/")` returning `"Hello world!"` alongside the controller routes.
- `Controllers/` holds attribute-routed `[ApiController]` classes using `[Route("[controller]")]`, so each controller is reachable at `/<ControllerName>` (e.g. `/Hello`, `/WeatherForecast`).
- Models live at the project root (e.g. `WeatherForecast.cs`) in the `FirstWebApiClaudeSkillCommitCheck` namespace.

When adding a new endpoint, prefer adding a controller in `Controllers/` over a minimal-API mapping in `Program.cs` to stay consistent with the existing pattern.

## Claude skills in this repo

`../.claude/skills/` defines two project-local skills used during development:

- `commit-message` — generates commit messages for staged changes (invoked via `/commit`).
- `pr-description` — writes PR descriptions following a What / Why / Changes template, based on `git diff main...HEAD`.

`../.claude/skills/DeveloperSkillPack.md` lists additional aspirational skills (test, lint, build, deploy, release) but only the two above have backing `Skill.md` files.
