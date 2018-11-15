using  System;
using System.Collections.Generic;

namespace  ToDoListNamespace
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("");
      Console.WriteLine("Would you like to add an item or View the list? (Add/View)");
      string uInput = Console.ReadLine();
      ToDoListProgram(uInput);
      uInput = "";
    }

    public static void ToDoListProgram(string uInputProgram)
    {
      if (uInputProgram == "Add")
      {
        Console.WriteLine("");
        Console.WriteLine("What would you like to add?");
        string addedDesc = Console.ReadLine();
        Item newItem = new Item(addedDesc);
        Console.WriteLine("'{0}' has been added to the list.", newItem.GetDescription());
      }
      else if (uInputProgram == "View")
      {
        Console.WriteLine("");
        List<Item> resultList = Item.GetAll();
        foreach (Item x in resultList) {
          Console.WriteLine(x.GetDescription());
        }
      }
      Console.WriteLine("");
      Console.WriteLine("Now what would you like to End the program? Y/N");
      string EndYN = Console.ReadLine();
      if (EndYN == "Y" || EndYN == "y") {

      } else {
        Main();
      }
    }
  }
}
