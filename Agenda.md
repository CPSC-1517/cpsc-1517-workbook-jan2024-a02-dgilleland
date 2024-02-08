# Agenda

> These are my notes on what I plan to teach in each [**upcoming class**](#jan-18). For the timeline of where we are today, see [the current schedule](./README.md#schedule).
>
> ##### *... Warn those who are idle ..., encourage the disheartened, help the weak, be patient with everyone.*
>
> > My philosophy of teaching, taken from [the source](https://www.bible.com/bible/111/1TH.5.14.NIV)

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
- [ ] Blazor Web Application Intro

    ```ps
    pnpm dlx tiged --disable-cache --force CPSC-1517/cpsc-1517-workbook-jan2024-a02-dgilleland/src/006 ./src/006
    ```


----

## *Future - TBD*

- [ ] Resume **WindChill** demo
  - [ ] version 2 - 
- [ ] Resume **WindChill** demo
  - [ ] version 3 - 
- [ ] C# Review Presentations
  - [ ] [Arrays](https://programming-0101.github.io/slides/OOP-Ramp-Up/05-Arrays.html)
  - [ ] [Interfaces](https://programming-0101.github.io/slides/OOP-Ramp-Up/08-Interface.html)
  - [ ] [EF Core](https://programming-0101.github.io/slides/OOP-Ramp-Up/15-EF-Core.html)
  - [ ] [~~Unit Tests~~](https://programming-0101.github.io/slides/UnitTests/index.html)

