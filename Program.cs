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
    
    [TestMethod]
    public void InvalidMenuChoiceException_MessageConstructor_InitializesCorrectly()
    {
      string message = "Текстовое сообщение";
      InvalidMenuChoiceException exception;
      exception = new InvalidMenuChoiceException(message);

      Assert.AreEqual(message, exception.Message);
      Assert.IsNull(exception.MenuChoice);
    } 

    [TestMethod]
    public void InvalidMenuChoiceException_MessageAndChoiceConstructor_InitializesCorrectly()
    {
      string message = "Тестовое сообщение с выбором";
      string choice = "Вариант 3";
      InvalidMenuChoiceException exception;

      exception = new InvalidMenuChoiceException(message, choice);

      Assert.AreEqual(message, exception.Message);
      Assert.AreEqual(choice, exception.MenuChoice);
    }

    [TestMethod]
    public void InvalidMenuChoiceException_MessageAndInnerExceptionConstructor_InitializesCorrectly()
    {
      string message = "Тестовое сообщение с внутренним исключением";
      Exception innerException = new Exception("Внутреннее сообщение об исключении");
      InvalidMenuChoiceException exception;
      exception = new InvalidMenuChoiceException(message, innerException);

      Assert.AreEqual(message, exception.Message);
      Assert.AreEqual(innerException, exception.InnerException);
      Assert.IsNull(exception.MenuChoice);
    }
  }
}