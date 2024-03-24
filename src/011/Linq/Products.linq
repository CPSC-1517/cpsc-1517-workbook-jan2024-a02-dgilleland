<Query Kind="Expression">
  <Connection>
    <ID>89b9f309-798d-4dfa-8ab5-9a906eccdb3e</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPath>C:\GH\2024-Jan-In-Class\1517-A02-Instructor\src\011\WWWCore\bin\Debug\net8.0\WestWindWholesale.dll</CustomAssemblyPath>
    <CustomTypeName>WestWindWholesale.DAL.WestWindContext</CustomTypeName>
    <DriverData>
      <UseDbContextOptions>false</UseDbContextOptions>
    </DriverData>
  </Connection>
</Query>

// LINQ - Language INtegrated Query
// A part of C# that allows for "querying" similar
// to how you would do it in SQL.
Products.Where(item => item.ProductName.Contains("chef"))
// Select Products
// Where each item's ProductName contains the text "chef"