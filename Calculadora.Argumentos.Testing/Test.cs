using NUnit.Framework;
using System;

namespace Calculadora.Argumentos.Testing
{
	[TestFixture()]
	public class Test
	{
		private CalculadoraDeAcougue calculadora;
		
		[SetUp]
		public void Initialize()
		{
			calculadora = new CalculadoraDeAcougue();
		}
		
		[TearDown]
		public void Finalizing()
		{
			
		}
		
		[Test()]
		public void ShouldSumTwoNumbers ()
		{
			// given:
			int number1 = 100;
			int number2 = 200;
			
			// when:
			double result = calculadora.operate('+', number1, number2);
			
			// then:
			Assert.AreEqual(300, result, "O resultado da soma não é o esperado");
		}
		
		[Test()]
		public void ShouldSumTwoDecimalNumbers ()
		{
			// given:
			double number1 = 100.5;
			double number2 = 200.5;
			
			// when:
			double result = calculadora.operate('+', number1, number2);
			
			// then:
			Assert.AreEqual(301, result, "O resultado da soma de valores decimais não é o esperado");
		}
		
		[Test]
		public void ShouldSubtractTwoNumbers ()
		{
			// given
			int number1 = 987;
			int number2 = 635;
			
			// when:
			double result = calculadora.operate('-', number1, number2);
			
			// then:
			Assert.AreEqual(352, result, "O resultado da subtração não é o esperado");
		}
		
		[Test]
		public void ShouldMultiplyTwoNumbers() {
			//given
			int operando1 = 86;
			int operando2 = 27;
			char operador = '*';
			
			//when
			double resultado = calculadora.operate(operador, operando1, operando2);
			
			//then
			Assert.AreEqual(2322, resultado, "O resultado da multiplicação não é o esperado");
		}
		
		[Test]
		public void ShouldDivideTwoNumbers() {
			//given
			int operando1 = 42;
			int operando2 = 10;
			char operador = '/';
			
			//when
			double resultado = calculadora.operate(operador, operando1, operando2);
			
			//then
			Assert.AreEqual(4.2, resultado, "O resultado da divisão não é o esperado");
		}
	}
}

