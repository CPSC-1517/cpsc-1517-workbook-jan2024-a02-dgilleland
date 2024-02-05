// See https://aka.ms/new-console-template for more information
using DemoClasses;
using static System.Console;
Clear();
WriteLine("Hello, World!");

if(args.Length == 0)
    ShowHelp();
else
{
    // TODO: Support more demos
    switch(args[0])
    {
        case "-f":
            DemoFractions.Run(args);
            break;
        case "-q":
            DemoScantron.Run(args);
            break;
        default:
            ShowHelp();
            break;
    }
}
/**** Helper Functions *****/
void ShowHelp()
{
    WriteLine("-f          Run Fractions Demo");
    WriteLine("-q <path>   Run Scantron Demo");
}
