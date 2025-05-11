using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverLoad;
using System;

namespace task10
{
  [TestClass]
  public class InvalidMenuChoiceExceptionTests
  {
    [TestMethod]
    public void InvalidMenuChoiceException_DefaultConstructor_InitializesCorrectly()
    {
      InvalidMenuChoiceException exception;
      exception = new InvalidMenuChoiceException();

      Assert.AreEqual("Некорректный выбор в меню", exception.Message);
      Assert.IsNull(exception.MenuChoice);
    }
  }
}