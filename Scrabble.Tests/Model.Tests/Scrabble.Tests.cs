using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.TestTools
{
  [TestClass]
  public class ScrabbleTest// : IDisposible
  {
    // public void Dispose()
    // {
    //   Gram.ClearAll();
    // }

    [TestMethod]
    public void WordConstructor_CreateInstanceOfWord_Word()
    {
      Word newWord = new Word("hoser");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstructor_ConvertInputWordToCharArray_CharArray()
    {
      string userInput = "ANT";
      char[] testCharArray = userInput.ToCharArray();
      Assert.AreEqual('N', testCharArray[1]);
    }

    [TestMethod]
    public void AssignCharValue_ReturnNonAlphaInput_False()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string userInput = "ANT";
      Word testWord = new Word(userInput);
      Assert.AreEqual(3, testWord.AssignCharValue(userInput));
    }

  }
}
