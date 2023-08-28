# CICD-Application [![Release](https://github.com/saklanipankaj/CICD-Application/actions/workflows/Release.yml/badge.svg?branch=main)](https://github.com/saklanipankaj/CICD-Application/actions/workflows/Release.yml) 
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

## Changing Browser
- `dotnet test --settings:chromium.runsettings` Chrome
- `dotnet test --settings:firefox.runsettings` Firefox
- `dotnet test --settings:webkit.runsettings` Safari

## UAT Testing (Playwright):
### Setup
- Start Powershell
- `Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass` used to temporarily allow for execution of script
- Navigate to Playwright Test Project `cd PWTests`
- Add the Playwright package to the project `dotnet add package Microsoft.Playwright.NUnit`
- Build the Project `dotnet build`
- `.\bin\Debug\net7.0\playwright.ps1 install` install dependencies

### Testing
- Navigate to Playwright Test Project `cd PWTests`
- `dotnet build`
- `dotnet test` / `dotnet test -- Playwright.LaunchOptions.Headless=false` (Lauches the entire test with UI)
#### Debug Modein Powershell 
- Run the command `$env:PWDEBUG=1` to activate debug mode
- Run the command `dotnet test`

#### Run Different Browsers
- `dotnet test --settings:chromium.runsettings` Chrome Browser
- `dotnet test --settings:firefox.runsettings` Firefox Browser
- `dotnet test --settings:webkit.runsettings` Safari Browser

## Playwright Codegen
Helps to create Playwright script using a UI
- Navigate to project root directory
- Navigate to App folder `cd DotNetApp`
- Start the BlazorApp `dotnet watch`/ `dotnet run`
    - `dotnet watch` is a interactive version exclusive to Blazor, allows for changes to the files to be immediately reflected on the running application
- Start another powershell terminal to continue
- `Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass` used to temporarily allow for execution of scripts
- Navigate to UAT Folder `cd PWTest`
- Run the ` .\bin\Debug\net7.0\playwright.ps1 codegen {{url-of-locally-running-webpage}}`

## Playwright Trace Viewer
- Start Powershell Terminal Required
- `Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass` used to temporarily allow for execution of scripts
- Navigate to PWTests Folder `cd PWTests`
- Run the `.\bin\Debug\net7.0\playwright.ps1 show-trace PWTests\bin\Debug\net7.0\trace.zip`


