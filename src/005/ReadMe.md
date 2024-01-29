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

### Creating a `Fraction` Data Type

> TODO: More Notes....

#### Parsing

We've given our `Fraction` objects the ability to be expressed as a string. Now, let's see if we can *reverse* the process. Taking textual information an producing some other type of object is known as **parsing**.

All of the built-in numeric data types in C# have `static` methods to support converting strings to their numeric values. As a common convention, those methods are called `Parse()` and `TryParse()`. We want our custom numeric data type to do the same, which means we will need to create a `Fraction.Parse()` and `Fraction.TryParse()` pair of methods. Let's begin with our specifications.