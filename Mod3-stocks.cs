// Properties look like fields from the outside but internally, they contain logic, like methods:
using System;

var stock = new Stock();
stock.CurrentPrice = 123.45M;
// stock.CurrentPrice.Dump();
Console.WriteLine(stock.CurrentPrice);

var stock2 = new Stock { CurrentPrice = 83.12M };
// stock2.CurrentPrice.Dump();
Console.WriteLine(stock2.CurrentPrice);

public class Stock
{
  decimal currentPrice;           // The private "backing" field
  
  public decimal CurrentPrice     // The public property
  {
    get { return currentPrice; } set { currentPrice = value; }
  }
}
// Properties - calculated & read-only

// The Worth Property is a read-only calculated property.

// var stock = new Stock { CurrentPrice = 50, SharesOwned = 100 };
// stock.Worth.Dump();

// public class Stock
// {
//   decimal currentPrice;           // The private "backing" field
//   public decimal CurrentPrice     // The public property
//   {
//     get { return currentPrice; } set { currentPrice = value; }
//   }

//   decimal sharesOwned;           // The private "backing" field
//   public decimal SharesOwned     // The public property
//   {
//     get { return sharesOwned; } set { sharesOwned = value; }
//   }

//   public decimal Worth
//   {
//     get { return currentPrice * sharesOwned; }
//   }
// }
// Properties - expression-bodied

// The Worth Property is now an expression-bodied property.

// var stock = new Stock { CurrentPrice = 50, SharesOwned = 100 };
// stock.Worth.Dump();

// public class Stock
// {
//   decimal currentPrice;           // The private "backing" field
//   public decimal CurrentPrice     // The public property
//   {
//     get { return currentPrice; } set { currentPrice = value; }
//   }

//   decimal sharesOwned;           // The private "backing" field
//   public decimal SharesOwned     // The public property
//   {
//     get { return sharesOwned; } set { sharesOwned = value; }
//   }

//   public decimal Worth => currentPrice * sharesOwned;    // Expression-bodied property

//   // From C# 7, we can take this further, and write both the get and set accessors in
//   // expression-bodied syntax:
//   public decimal Worth2
//   {
//     get => currentPrice * sharesOwned;
//     set => sharesOwned = value / currentPrice;
//   }

// }
// Automatic Properties

// Here's the preceding example rewritten with two automatic properties:

// var stock = new Stock { CurrentPrice = 50, SharesOwned = 100 };
// stock.Worth.Dump();

// public class Stock
// {
//   public decimal CurrentPrice { get; set; }   // Automatic property
//   public decimal SharesOwned { get; set; }    // Automatic property

//   public decimal Worth
//   {
//     get { return CurrentPrice * SharesOwned; }
//   }
// }
// Property Initializers

// var stock = new Stock();
// stock.CurrentPrice.Dump();
// stock.Maximum.Dump();

// public class Stock
// {
//   public decimal CurrentPrice { get; set; } = 123;
//   public int Maximum { get; } = 999;
// }
// Properties - get & set accessibility
