# Assorted Classes

To set up this, from the root of this repo run the following code:

```ps
dotnet new classlib -o src/005/AssortedDemos -n Assorted
dotnet new sln -o src/005 -n AssortedClasses
```

> Remember to add the `005` folder as one of the workspace folders in VS Code by selecting *File -> Add Folder to Workspace...*

To open this new solution in the Solution Explorer, press <kbd>F1</kbd> and type "Open Solution".

### Coin + CoinFace

> Take from [The Book](https://programming-0101.github.io/TheBook/Topic/I/Examples/Coin.html).

## Setting Up for Unit Tests

```ps
# From within the ~/src/005 folder, run the following
dotnet new xunit -o AssortedDemos.Specs
cd AssortedDemos.Specs
dotnet add project ../AssortedDemos/Assorted.csproj
dotnet add package FluentAssertions
```
