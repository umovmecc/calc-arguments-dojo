using System;

namespace Calculadora.Argumentos
{
	public class CalculadoraDeAcougue
	{
		public double operate (char operador, double number1, double number2)
		{
			switch(operador){
			case '-':
				return number1 - number2;
			case '+':
				return number1 + number2;
			case '*':
				return number1 * number2;
			case '/':
				return number1 / number2;
			}
			throw new InvalidOperationException();
		}
		
		public CalculadoraDeAcougue ()
		{
			
		}
		
		
		
	}
}

