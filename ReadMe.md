# GeeksLtdMsharp

Overview
- Razor Pages project using .NET 8 and the M# (MSharp) framework.
- Purpose: sample registration flow with domain model `Register` and UI form modules. The project includes custom code in the `Pangolin` folder (your Pangolin code).
- Key feature added: automatic `InvitationCode` generation for new `Register` records.

Requirements
- .NET 8 SDK
- Visual Studio 2022 (or later) or the `dotnet` CLI
- M# runtime / packages used by the project (refer to the solution's NuGet packages)

Quick start (CLI)
1. Clone the repository:
   - `git clone https://github.com/bamdadtabari-geeksltd/GeeksLtdMsharp`
2. Restore and build:
   - `dotnet restore`
   - `dotnet build`
3. Run (if the web project is the startup project):
   - `dotnet run --project <path-to-web-project>`  
   Or open the solution in Visual Studio and use the IDE to run.

Quick start (Visual Studio)
- Open the solution in Visual Studio 2022.
- Select the web project as the startup project.
- Use __Build > Build Solution__ then __Debug > Start Debugging__ (or __Start Without Debugging__).

Project layout (important files)
- `M#\Model\Domain\Register.cs` — M# model definition for the `Register` entity.
- `Domain\Logic\Register.cs` — partial domain logic (validation + InvitationCode generation).
- `Domain\[GEN-Entities]\Register.cs` — generated entity class (auto-generated).
- `M#\UI\Modules\Register\RegisterForm.cs` — M# form module for registration UI.
- `M#\UI\Pages\RegisterPage.cs` — page that hosts the form module.
- `Website\Controllers\Pages\Register.Controller.cs` — controller + viewmodel glue for posting the form.
- `Pangolin/` — your custom Pangolin code (see notes below).

M# documentation
- Primary project and API docs / code samples: https://github.com/Geeksltd/MSharp  
  (Refer to the M# repo and its documentation for framework specifics: model DSL, modules, pages, and code generation.)
- Use M# docs when modifying `EntityType` declarations, `.Calculated()` fields, UI `FormModule<T>` and module life-cycle hooks.

Pangolin folder
- The repository contains a `Pangolin` folder with your Pangolins code. This folder appears to hold custom utilities / components you wrote.
- Recommended:
  - Add a `Pangolin/README.md` describing the purpose and how to build/run those components.
  - If Pangolin contains a library used by the web app, ensure its project is referenced by the main solution and listed in the solution file.
  - If Pangolin is a standalone tool, document required inputs, outputs and example usages.

InvitationCode behavior (what's implemented)
- New `Register` instances get an automatically-generated invitation code at construction time (secure random alphanumeric, avoids ambiguous characters).
- Current model uses `.Calculated()` for `InvitationCode` (read-only calculated property). That means:
  - The code is generated in the domain constructor and is available at runtime.
  - It is not persisted in the database by default because generated entities mark it as calculated.
- To persist the generated invitation code:
  - Change the M# model to remove `.Calculated()` for `InvitationCode` (use `String("InvitationCode")` instead).
  - Regenerate or update the generated entity so EF maps the column, then run migrations or update the database.
  - Consider enforcing uniqueness if required.

Notes & troubleshooting
- If you see validation messages related to email or age, those are enforced in `Domain\Logic\Register.cs`.
- If you need the UI to display the generated invitation code to the user after save, persist the code (see previous section) or expose it via the ViewModel.
- For NuGet and package issues, use __Tools > NuGet Package Manager > Manage NuGet Packages for Solution__ or the `dotnet` CLI (`dotnet restore`, `dotnet nuget`).

Contributing
- Fork -> branch -> PR.
- Keep changes scoped (one feature / fix per PR).
- Add unit tests for domain logic where possible.

Contact / author
- Repository origin: `https://github.com/bamdadtabari-geeksltd/GeeksLtdMsharp` (branch: `master`).
- If you want, I can:
  - Persist `InvitationCode` and add a migration.
  - Add a `Pangolin/README.md` with concrete build/run steps if you tell me what's inside the folder.
  - Add tests for the `Register` validation and InvitationCode generation.

License
- Add your preferred license file (`LICENSE`) in the repo root if needed.
