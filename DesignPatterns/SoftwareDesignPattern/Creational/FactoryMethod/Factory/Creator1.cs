﻿using System;

#pragma warning disable CC0091 // Use static method
namespace DesignPatterns.SoftwareDesignPattern.Creational.FactoryMethod.Factory {
  // Should be only used as concrete factory method
  public class Creator1 {
    public static IProduct FactoryMethod() {
      Console.WriteLine($"Factory method called, will create {nameof(Product)} with {nameof(IProduct)} type");
      return new Product();
    }

    public string OtherStuff() => "Some action";
  }
}
