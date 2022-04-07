using System;

namespace Aula7CSharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool desligar = false;

            while(!desligar)
            {
                 Console.WriteLine("Calculadora");
            Console.WriteLine("Digite o primeio número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o operador: ");
            string operador = Console.ReadLine();

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.WriteLine("Resultado: " + Somar(num1, num2));
                    break;
                case "-":
                    Console.WriteLine("Resultado: " + Subtrair(num1, num2));
                    break;
                case "*":
                    Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                    break;
                case "/":
                    Console.WriteLine("Resultado: " + Dividir(num1, num2));
                    break;
                case "%":
                    Console.WriteLine("Resultado: " + Porcentagem(num1, num2));
                    break;
                default:
                    Console.WriteLine("Operador inválido");
                    break;
            }

                Console.WriteLine("Deseja desligar? ");
                string condicao = Console.ReadLine();
                if(condicao == "Sim")
                {
                    desligar = true;
                }
                else
                {
                    desligar = false;
                }
            }

           

        }
    
        public static string Somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string Subtrair(int num1, int num2)
        {
           return (num1 - num2).ToString();
        }
        public static string Multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string Dividir(int num1, int num2)
        {
            if (valorDividendoMenorOuIqualZero(num2))
            {
            return "Não é possível dividir por zero ou menor que zero!";
            }
            return (num1 / num2).ToString();
        bool valorDividendoMenorOuIqualZero(int num2)
        {
        if (num2 <= 0)
        {
            return true;
        }
            return false;
        }
}
        public static string Porcentagem(int num1, int num2)
        {
            return ((num1 * num2) / 100).ToString();
        }
    }
}




    
