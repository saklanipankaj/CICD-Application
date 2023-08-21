# CICD-Application ![ ](https://github.com/saklanipankaj/MyBlazorApp/actions/workflows/UnitTesting.yml/badge.svg)
Created by adapting the base Microsoft Blazor App. Includes a working weather widget that draws information from a live API service. (Location is set to Singapore)

## Requirements (Update As Necessary Later):
.Net 7

## UAT Testing using Playwright
The UAT Testing has been done using Microsoft.Playwright library using NUnit.
Refer to the [offical documentation site]((https://playwright.dev/dotnet/docs/intro#installing-playwright)) for more information

## Running Test Locally CLI
All Tests can be run locally when the project is cloned.
Follow the steps outlined for Unit Testing:
- `cd "directory of test project"` (optional - if left at base directory will run all tests)
- `dotnet build`
- `dotnet test`

## UAT Testing (Playwright):
### Setup
- Start Powershell
- `Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass` used to temporarily allow for execution of script
- `.\bin\Debug\net7.0\playwright.ps1 install` install dependencies

### Testing
- `cd UAT`
- `dotnet build`
- `dotnet test` / `dotnet test -- Playwright.LaunchOptions.Headless=false`

## Playwright Codegen
Helps to create Playwright script using a UI
- Navigate to project root directory
- Navigate to App folder `cd DotNetApp`
- Start the BlazorApp `dotnet watch`/ `dotnet run`
    - `dotnet watch` is a interactive version exclusive to Blazor, allows for changes to the files to be immediately reflected on the running application
- Start another powershell terminal to continue
- `Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass` used to temporarily allow for execution of scripts
- Navigate to UAT Folder `cd UAT`
- Run the ` .\bin\Debug\net7.0\playwright.ps1 codegen http://localhost:5001/`
