# Agenda

[![Quick Style](./docs/images/favicon.png) Quick Style](./src/008/Docs/Styling.md) instructions for *empty Blazor projects*. 

> These are my notes on what I plan to teach in each [**upcoming class**](#apr-8). For the timeline of where we are today, see [the current schedule](./README.md#schedule).
>
> ##### *... Warn those who are idle ..., encourage the disheartened, help the weak, be patient with everyone.*
>
> > My philosophy of teaching, taken from [the source](https://www.bible.com/bible/111/1TH.5.14.NIV)

----

## Code Samples

Are you interested in grabbing my code samples? Here's a quick script that you can run in the terminal from the root of your own repository to grab all of my code samples and place them inside a folder called `~/dan/`.

```ps
# Ensure your terminal is open at the ROOT of your workbook!
pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a01-dgilleland/src ./dan
```

If you *don't* want my samples to be included in your own repository's history, then change the last part from `./dan` to `./rnd`.

Note that each time you run this, it will overwrite the existing content in that folder; that makes it easy to keep up-to-date with my changes. Use your own `~/src/` folder for your personal demos and practices attempts. Detail on how the script works can be found in the [`~/src/ReadMe.md`](./src/ReadMe.md) file.

----

## Jan 8 (W1)

- [x] Course Introduction
- [x] Create student workbook(s)
- [x] Install CLI tools (git, gh, node)
- [x] Install editor (vscode)
- [x] Learn some DOS commands

## Jan 9

- [ ] Grabbing the Demos (you will need to have Node and [pnpm](https://pnpm.io/installation) installed):
  
    ```ps
    # Ensure your terminal is open at the ROOT of your workbook!
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/000 ./src/000
    ```
  
    ```ps
    # Ensure your terminal is open at the ROOT of your workbook!
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/001-StartHere ./src/001-StartHere
    ```
  
    ```ps
    # Ensure your terminal is open at the ROOT of your workbook!
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/002 ./src/002
    ```

- [x] Git & Markdown
  - [000](./src/000/ReadMe.md)
  - Add/Commit/Push - [**The Routine**](./docs/TheRoutine.md)
  - :+1: Student Name in [README.md](README.md)
  - [001- Start Here](./src/001-StartHere/ReadMe.md)
- [x] **Homework!** :100:
  - [002](./src/002/ReadMe.md)
  - Assignments on MS Teams:
    - About Me
    - GitDoc Usage
    - GitDoc Typing Profile

## Jan 11

- [ ] Comments/Demo of Practice Assignments
  - About Me
  - GitDoc Usage
  - GitDoc Typing Profile
- [ ] Lot's of Lectures!
  - **What is a Computer Program**
    - *A computer program is a **set of instructions** for manipulating **information**.*
    - Information: Primitve Types & Complex Types
      - Primitive types: Textual, Numeric, Conceptual
      - Complex types: Classes (`class`), `struct`, `record`
        - A class is a blueprint for creating objects.
        - It describes what an object will *look like* and how it will *behave*.
        - `class` is made up of fields, properties, methods and constructors.
    - Kinds of programs:
      - CLI (console w. UI)
      - Desktop
      - Web
      - Others: (scheduled jobs, server apps, edge applications, etc.)
- [ ] Walk through on Projects and Solutions (see Rnd/ReadMe)
  - Run the following code

    ```ps
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/003 ./src/003
    ```

- [ ] **Homework!**
  - Readings:
    - VS Code [**User Interface**](https://code.visualstudio.com/docs/getstarted/userinterface)
    - [Working with C# in VS Code](https://code.visualstudio.com/docs/languages/csharp)
    - [Working with .NET and VS Code](https://code.visualstudio.com/docs/languages/dotnet)
    - [Getting Started with C# in VS Code](https://code.visualstudio.com/docs/csharp/get-started)
  - Videos:
    - [Intro Videos on C# and VS Code](https://code.visualstudio.com/docs/csharp/introvideos-csharp)

----

## Jan 15 (W2)

- [ ] Resume/complete the *HelloWorld* app from [003](./src/003/ReadMe.md) (Step 8)
- [ ] Force-commit the `.code-workspace`

    ```ps
    git add ./src/A02-CPSC-1517.code-workspace --force
    git commit -m "Force-add code workspace"
    ```

- [ ] Transition to the [004](./src/004/ReadMe.md) demo and start the intro to TLPs and TDD. Remember to add a workspace folder for 004.

    ```ps
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/004 ./src/004
    ```

## Jan 16

- [ ] Resume **WindChill** demo
  - [ ] version 1 - with unit tests and simple primitive class members

## Jan 18

> "7H3 M345UR3 OF 1N73LL163NC3 15 7H3 481L17Y 70 CH4N63" - 4l83r7 31n5731n

- [ ] Discuss the Take-Home Lab Exercises
  - [ ] Ex 1 - Project/Solution Setup
- [ ] Resume **WindChill** demo
- [ ] **Homework!**
  - [ ] In VS Code: *Help -> Welcome*, then follow the "Get Started with C# DevKit"
  - [ ] Review the [Simplified C# Grammar](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html)

----

## Jan 22 (W3)

- [ ] Discuss the Take-Home Lab Exercises
  - [ ] Ex 1 - Unit Tests & Utilities class
- [ ] C# Review Presentations
  - [ ] [Foundational Concepts](https://programming-0101.github.io/slides/OOP-Ramp-Up/00-FoundationalConcepts.html)
  - [ ] [Grammar](https://programming-0101.github.io/slides/OOP-Ramp-Up/01-Grammar.html)
  - [ ] [Enums](https://programming-0101.github.io/slides/OOP-Ramp-Up/02-Enum.html)

## Jan 23

- [ ] C# Review Presentations
  - [ ] [Simple Objects](https://programming-0101.github.io/slides/OOP-Ramp-Up/03-Objects.html)
  - [ ] [Object Inheritance](https://programming-0101.github.io/slides/OOP-Ramp-Up/04-Objects.html)
- [ ] Resume [**WindChill**](./src/004) demo
  - [ ] version 1 - with unit tests and simple primitive class members

## Jan 25

- [ ] Assorted Demos
  - [ ] A class library of various sample classes from ***The Book***
- [ ] Demo **Fraction**
  - [ ] version 1 - create unit tests
- [ ] **Tip:** *Don't force abstractions by rushing to create complex data types. Begin with classes/records that have intrinsic primitive types.*

----

## Feb 5

- [ ] Multiple Choice Quiz
- [ ] Exercise 1 Solution

## Feb 6

> *Lab time (by request)*

## Feb 8

- [ ] Exercise 2 Addendum
  - [ ] Notes & video
- [ ] Comments on Quiz 1
- [ ] Blazor Web Application Intro

    ```ps
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/006 ./src/006
    ```

- [ ] **Homework!**
  - [ ] Read the following:
    - [ ] [**ASP.NET Documentation**](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0) *(Entry point to learn more about ASP.NET)*
    - [ ] [**ASP.NET Core Blazor**](https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-8.0)
    - [ ] [**ASP.NET Core Blazor project structure**](https://learn.microsoft.com/en-us/aspnet/core/blazor/project-structure?view=aspnetcore-8.0)
    - [ ] [**Layout in ASP.NET Core**](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/layout?view=aspnetcore-8.0)
    - [ ] [**Razor syntax reference for ASP.NET Core**](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-8.0)
    - [ ] [**ASP.NET Core Razor components**](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-8.0)
    - [ ] [**ASP.NET Core Razor component lifecycle**](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/lifecycle?view=aspnetcore-8.0)

----

## Feb 12 (W6)

- [ ] Exercise 2 Solution


## Feb 13

- [ ] **Quiz 1**

  ![Quiz 1](./docs/images/Quiz1.png)

## Feb 15

- [ ] Classless CSS in Blazor 8

    ```ps
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/007 ./src/007
    ```

- [ ] **Homework!**
  - [ ] Read the following (along with readings added to [*Feb 8*](#feb-8)):
    - [ ] [**ASP.NET Core Blazor project structure**](https://learn.microsoft.com/en-us/aspnet/core/blazor/project-structure?view=aspnetcore-8.0)
    - [ ] [ASP.NET Core Blazor forms overview](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/?view=aspnetcore-8.0)
    - [ ] [ASP.NET Core Blazor input components](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/input-components?view=aspnetcore-8.0)
    - [ ] [ASP.NET Core Blazor forms binding](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/binding?view=aspnetcore-8.0)
    - [ ] [ASP.NET Core Blazor forms validation](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/validation?view=aspnetcore-8.0)
    - [ ] [Working with Dates And Times in Razor Pages Forms](https://www.mikesdotnetting.com/article/352/working-with-dates-and-times-in-razor-pages-forms)
    - [ ] [Troubleshoot ASP.NET Core Blazor forms](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/troubleshoot?view=aspnetcore-8.0)
    - [ ] [Model Binding in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-8.0)
    - [ ] [Work with images in ASP.NET Core Blazor](https://learn.microsoft.com/en-us/aspnet/core/blazor/images?view=aspnetcore-8.0)
    - [ ] [ASP.NET Core Blazor QuickGrid component](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/quickgrid?view=aspnetcore-8.0)

----

## Reading Break

| Feb 12-16, 2024 | Showing Appreciation |
|:--:|:---|
| ![book](./docs/images/storyline-top-book.png) | What takes you 5 minutes to read may take 40 minutes to write with additional background time spent researching and verifying the content. Take time to appreciate that what you are consuming in such a short time has taken exponentially more time to produce. Share the appreciation for what you receive. |

----

## Feb 26

- [ ] Solution to the In-Class Assessment

## Feb 27

> Instructor away - students are to ensure they have completed the [readings from Feb 15](#feb-15).

## Feb 29

> **Leap Year!**

- [ ] HTML Form Elements (In Blazor 8)

  ```ps
  pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/008 ./src/008    
  ```

  - [ ] Run the website in watch mode

    ```ps
    cd src/008/Website
    dotnet watch
    ```

----

## Mar 4

- [ ] Blazor Input Controls for Forms
  - [ ] Present updates to the [008](./src/008/ReadMe.md) resources/demo
  - [ ] Discuss the [Common Controls](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/input-components?view=aspnetcore-8.0#input-components) for Blazor forms and the use of the `<EditForm>` Component.
- [ ] Reports and CSV Data
  - [ ] Begin the *Weather-or-Not* demo

    ```ps
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/009 ./src/009
    ```

  - [ ] Plan/Design the App

## Mar 5

- [ ] Review Specs on Exercise 3
- [ ] Continue with 009 (Weather App)

----

## Mar 18

- [ ] Quiz 2 Prep

    ```ps
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/Q2-Prep ./src/Q2-Prep
    ```

## Mar 19

- [x] Quiz 2

## Mar 21

- [ ] Databases and Blazor using **WestWind** (see [`~/src/011`](./src/011/ReadMe.md))

    ```ps
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/011 ./src/011
    ```

----

## Mar 25

> Follow the [**Step-by-Step Instructions**](./src/011/StepByStep/ReadMe.md).

- [ ] Continue Developing the WestWind Demo ([`~/src/011`](./src/011/ReadMe.md))
  - [ ] **Business-Logic-Layer** - `ProductServices` class
  - [ ] **Dependency-Injection** - `WestWindServices` class
  - [ ] **Configuring Services** - `Program` class
- [ ] Readings:
  - [ ] [Lambdas and Delegates](https://dmit-2018.github.io/topics/linq/lambda.html)

## Mar 26

- [ ] Continue Developing the WestWind Demo ([`~/src/011`](./src/011/ReadMe.md))
  - [ ] Product Catalog page
  - [ ] Product Editing page

## Mar 28

- [ ] ***[Self-study]*** - Continue Developing the WestWind Demo ([`~/src/011`](./src/011/ReadMe.md))
  - [ ] Complete any remaining demo work for Products CRUD
  - [ ] Practice by creating CRUD services/pages for **Suppliers**
  - [ ] Practice by creating CRUD services/pages for **Categories**

----

## Apr 1 (Easter Monday)

## Apr 2

- [ ] Setting up the BLL Service Class
  - [ ] *Read* - Data Lookup Services
- [ ] Exposing Services through a DI Extension Method
- [ ] Registering Services in `Program.cs`

## Apr 4

- [ ] Blazor Report of Data
  - [ ] Paging
  - [ ] Search/Filter

----

## Apr 8

- [ ] Data Manipulation Services
  - [ ] *Add*
  - [ ] *Update*
  - [ ] *Delete*

## Apr 10

- [ ] Edit Form for Add/Update/Delete
- [ ] Navigating from a `<QuickGrid>`

## Apr 11


----

## *Future - TBD*

> ***TODO:** Consolodate these ideas with the other section (Beyond Compare)*

- [ ] Resume **WindChill** demo
  - [ ] version 2 - 
- [ ] Resume **WindChill** demo
  - [ ] version 3 - 
- [ ] C# Review Presentations
  - [ ] [Arrays](https://programming-0101.github.io/slides/OOP-Ramp-Up/05-Arrays.html)
  - [ ] [Interfaces](https://programming-0101.github.io/slides/OOP-Ramp-Up/08-Interface.html)
  - [ ] [EF Core](https://programming-0101.github.io/slides/OOP-Ramp-Up/15-EF-Core.html)
  - [ ] [~~Unit Tests~~](https://programming-0101.github.io/slides/UnitTests/index.html)
- [ ] Blazor Articles (from Microsoft)
  - [ ] [ASP.NET Core built-in Razor components](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/built-in-components?view=aspnetcore-8.0) - Lists the built-in Blazor components with links to resources (e.g.: [NavLink](https://learn.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing?view=aspnetcore-8.0#navlink-component))
  - [ ] [**ASP.NET Core Blazor with Entity Framework Core (EF Core)**](https://learn.microsoft.com/en-us/aspnet/core/blazor/blazor-ef-core?view=aspnetcore-8.0)
  - [ ] [**Safe storage of app secrets in development in ASP.NET Core**](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-8.0&tabs=windows)
  - [ ] [ASP.NET Core Best Practices](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/best-practices?view=aspnetcore-8.0)
    - [ ] [*Reliable web app patterns*](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/best-practices?view=aspnetcore-8.0#reliable-web-app-patterns)
- [ ] Other Articles
  - [ ] FYI Reading relevant to .NET 7 & 8: ⁠[**Why doesn't my ASP.NET Core 7 web app launch on HTTPS?**](https://www.mikesdotnetting.com/article/366/why-doesnt-my-asp-net-core-7-web-app-launch-on-https)
  - [ ] [Executing async operations onchange in Blazor](https://www.mikesdotnetting.com/article/365/executing-async-operations-onchange-in-blazor)
  - [ ] [A reusable generic autocomplete component for Blazor](https://www.mikesdotnetting.com/article/363/a-reusable-generic-autocomplete-component-for-blazor)
  - [ ] [*Mike's Dotnetting*](https://www.mikesdotnetting.com/) is an excellent blog for the quality of articles.

### RnD

- [ ] https://github.com/tossnet/Blazor-Calendar
