using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string Fizzbuzz(int number)
		{
			if (IsMultipleOfThree(number) && IsMultipleOfFive(number))
				return "FizzBuzz";
			if (IsMultipleOfFive(number))
				return "Buzz";
			if (IsMultipleOfThree(number))
				return "Fizz";
			return number.ToString();	
		}

		private bool IsMultipleOfThree(int numero)
		{
			return (numero % 3 == 0);
		}

		private bool IsMultipleOfFive(int numero)
		{
			return numero % 5 == 0;
		}
	}
}
