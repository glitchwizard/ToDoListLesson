using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ToDoListNamespace
{
  [TestClass]
  public class ItemTest: IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
    
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item testItem = new Item("test");
      Assert.AreEqual(typeof(Item), testItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Item testItem = new Item(description);
      string result = testItem.GetDescription();
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Walk the dog.";
      Item testItem = new Item(description);
      string updatedDescription = "Do the dishes";
      testItem.SetDescription(updatedDescription);
      string result = testItem.GetDescription();
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> newList = new List<Item>{ };

      List<Item> result = Item.GetAll();
      foreach(Item thisItem in result)
      {
        Console.WriteLine("Output from empty list GetAll test: " + thisItem.GetDescription());
      }

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string description1 = "Walk the Dog";
      string description2 = "Wash the dishes";
      Item testItem1 = new Item(description1);
      Item testItem2 = new Item(description2);

      List<Item> newList = new List<Item>{ testItem1, testItem2 };

      List<Item> result = Item.GetAll();

      foreach(Item thisItem in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisItem.GetDescription());
      }

      CollectionAssert.AreEqual(newList, result);
    }

  }
}
