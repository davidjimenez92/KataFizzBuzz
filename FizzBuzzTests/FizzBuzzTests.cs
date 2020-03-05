using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System;
namespace FizzBuzz.Tests
{
	[TestClass()]
	public class FizzBuzzTests
	{
		public static FizzBuzz fizzbuzz;

		[TestInitialize]
		public void Setup()
		{
			fizzbuzz = new FizzBuzz();
		}
		[TestMethod()]
		public void FizzBuzzReturnIntegerNumber()
		{
			var numero = 1;
			var response = fizzbuzz.Fizzbuzz(numero);
			Assert.AreEqual(numero.ToString(), response);
		}

		[TestMethod()]
		public void FizzbuzzReturnFizzIfNumberIsThree()
		{
			var numero = 3;
			var response = fizzbuzz.Fizzbuzz(numero);
			Assert.AreEqual("Fizz", response);
		}

		[TestMethod()]
		public void FizzbuzzReturnFizzIsNumberMultipleOfThree()
		{
			var numero = 6;
			var response = fizzbuzz.Fizzbuzz(numero);
			Assert.AreEqual("Fizz", response);
		}

		[TestMethod()]
		public void FizzbuzzReturnBuzzIfNumberMultipleOfFive()
		{
			var numero = 10;
			var fizzbuzz = new FizzBuzz();
			var response = fizzbuzz.Fizzbuzz(numero);
			Assert.AreEqual("Buzz", response);
		}

		[TestMethod()]
		public void FizzbuzzReturnFizzBuzzIfNumberMultipleOfFiveAndThree()
		{
			var numero = 15;
			var fizzbuzz = new FizzBuzz();
			var response = fizzbuzz.Fizzbuzz(numero);
			Assert.AreEqual("FizzBuzz", response);
		}
	}
}