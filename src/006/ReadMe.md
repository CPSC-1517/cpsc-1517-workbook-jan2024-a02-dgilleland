# Blazor 8 Intro

- [ ] Create a Blazor 8 web application (w. Bootstrap)

    ```powershell
    dotnet new blazor -o src/006/Website -n WebApp
    dotnet new sln -o src/006 -n BlazorIntro
    cd src/006
    dotnet sln add Website/WebApp.csproj
    cd Website
    ```

- [ ] Install dev certificate (and trust it) (see [these docs](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-dev-certs#examples))
  - *This is a one-time task on your computer*

    ```powershell
    dotnet dev-certs https --trust
    ```

- [ ] Run the blazor website (in watch mode)

    ```powershell
    dotnet watch
    ```

- [ ] Tour of the starter kit code
