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
    DemoFractions.Run(args);
}
/**** Helper Functions *****/
void ShowHelp()
{
    WriteLine("-f     Run Fractions Demo");
}
