using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        enum menu {Soma = 1, Subtracao, Adicao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool menuSair = false;
            while(!menuSair)
            {
                Console.WriteLine("Seja bem vindo a calculara, Vamos começar \n");
                Console.WriteLine("1-Soma \n2-Subtração \n3-Adição \n4-Multiplicação \n5-Potencia \n6-Raiz \n7-Sair \n");
                menu selectMenu = (menu)int.Parse(Console.ReadLine());
                Console.WriteLine(selectMenu);

                switch (selectMenu)
                {
                    case menu.Soma:
                        soma();
                        break;

                    case menu.Subtracao:
                        sub();
                        break;

                    case menu.Adicao:
                        div();
                        break;

                    case menu.Multiplicacao:
                        mult();
                        break;

                    case menu.Potencia:
                        pot();
                        break;

                    case menu.Raiz:
                        raiz();
                        break;


                    case menu.Sair:
                        menuSair = true;
                        break;
                        
                }

                Console.Clear();

            }

            void soma()
            {
                Console.WriteLine("Soma os numeros \n");
                Console.WriteLine("Digite o primeiro numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                int result = a + b;
                Console.WriteLine($"O resultado é {result}");

                Console.WriteLine(" \nAperte ENTER para voltar ao menu");

                Console.ReadLine();
            }

            void sub()
            {
                Console.WriteLine("Subtraia os numeros \n");
                Console.WriteLine("Digite o primeiro numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                int result = a - b;
                Console.WriteLine($"O resultado é {result}");

                Console.WriteLine(" \nAperte ENTER para voltar ao menu");

                Console.ReadLine();
            }

            void div()
            {
                Console.WriteLine("Divida os numeros \n");
                Console.WriteLine("Digite o primeiro numero");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                float result = a / b;
                Console.WriteLine($"O resultado é {result}");

                Console.WriteLine(" \nAperte ENTER para voltar ao menu");

                Console.ReadLine();
            }

            void mult()
            {
                Console.WriteLine("Multiplique os numeros \n");
                Console.WriteLine("Digite o primeiro numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                int result = a * b;
                Console.WriteLine($"O resultado é {result}");

                Console.WriteLine(" \nAperte ENTER para voltar ao menu");

                Console.ReadLine();
            }

            void pot()
            {
                Console.WriteLine("Potencia do numero \n");
                Console.WriteLine("Digite o primeiro numero base");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente");
                int expoent = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                int result = (int)Math.Pow(baseNum, expoent);
                Console.WriteLine($"O resultado é {result}");

                Console.WriteLine(" \nAperte ENTER para voltar ao menu");

                Console.ReadLine();
            }

            void raiz()
            {
                Console.WriteLine("Raiz dos numeros \n");
                Console.WriteLine("Digite o primeiro numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                double result = Math.Sqrt(a);
                Console.WriteLine($"O resultado é {result}");

                Console.WriteLine(" \nAperte ENTER para voltar ao menu");

                Console.ReadLine();
            }
        }
    }
}
