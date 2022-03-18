using System;

namespace ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            menu();

        }

        static public void menu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("1-ex1: Soma N inteiros");
            Console.WriteLine("2-ex2: Numeros impares");
            Console.WriteLine("3-ex3: Retangulo");
            Console.WriteLine("4-ex4: Quadrado");
            Console.WriteLine("5-ex5: Fatorial");
            Console.WriteLine("6-ex6: Fibonacci");
            Console.WriteLine("7-ex7: Capital acumulado");
            Console.WriteLine("8-ex8: Fatorial");
            Console.WriteLine("9-ex9: Fatorial");
            Console.WriteLine("10-SAIR");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    somaN();
                    break;
                case 2:
                    num_impares();
                    break;
                case 3:
                    retangulo();
                    break;
                case 4:
                    quadrado();
                    break;
                case 5:
                    fatorial();
                    break;
                case 6:
                    fibonacci();
                    break;
                case 7:
                    capital_acumulado();
                    break;
                case 8:
                    decompor();
                    break;
                case 9:
                    word_count();
                    break;
                case 10:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    menu();
                    break;
            }
        }

        static public void somaN()
        {
            Console.WriteLine("Introduza um numero: ");
            int num = Convert.ToInt16(Console.ReadLine());
            int soma=0;
            for (int i = 1; i<=num; i++)
            {
                soma += i;
            }
            Console.WriteLine("A adiçao dos {0} primeiros numeros é: {1}", num, soma);
            menu();
        }

        static public void num_impares()
        {
            Console.Clear();
            Console.WriteLine("Introduza o limite inferior: ");
            int A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduza o limite superior: ");
            int B = Convert.ToInt16(Console.ReadLine());
            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
            }
            for(int i = A; i<=B; i++){
                if (i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
            menu();
        }

        static public void retangulo()
        {
            Console.Clear();
            Console.WriteLine("Introduza a largura: ");
            int largura = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduza o comprimento: ");
            int comprimento = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= comprimento; i++){
                if (i == 1 || i == comprimento)
                {
                    for (int j = 0; j < largura; j++)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("x".PadRight(largura - 1) + "x");

                }
            }
            menu();
        }

        static public void quadrado()
        {
            Console.Clear();
            Console.WriteLine("Introduza a largura: ");
            int largura = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduza o comprimento: ");
            int comprimento = Convert.ToInt16(Console.ReadLine());
            if(largura != comprimento)
            {
                Console.WriteLine("Dados invalidos! comprimento = largura!");
                menu();
            }
            else
            {
                for (int i = 1; i <= comprimento; i++)
                {
                    for(int j = 1; j <= largura; j++)
                    {
                        if(j % 2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    Console.WriteLine("");
                }
            }
            menu();
        }

        static public void fatorial()
        {
            int fat, i;
            Console.WriteLine("Introduza um valor: ");
            int num = Convert.ToInt16(Console.ReadLine());
            for ( fat = 1, i = 1; i <= num; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine("Fatorial: {0}", fat);
            menu();
        }

        static public void fibonacci()
        {
            int num1 = 0, num2 = 1, aux;
            for (int i = 0; i<=100; i++)
            {
                if (num2 >= 100)
                {
                    break;
                }
                else
                {
                    aux = num1;
                    num1 = num2;
                    num2 = num1 + aux;
                    Console.WriteLine("{0}", num2);
                }
            }
            menu();
        }

        static public void capital_acumulado()
        {
            int ano = 2022;
            Console.WriteLine("Introduza o montante da capital: ");
            float capital = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(capital.ToString().PadRight(10) + "|2%".PadRight(10) + "|2.5%".PadRight(10) + "|3%");
            for (int i = 1; i<=3; i++){
                ano++;
                double taxa2 = Math.Round(capital * Math.Pow((1 + 2.0 / 100), i),2);
                double taxa25 = Math.Round(capital * Math.Pow((1 - 2.5 / 100), i),2);
                double taxa3 = Math.Round(capital * Math.Pow((1 - 3.0 / 100), i), 2);
                Console.WriteLine(ano.ToString().PadRight(10) + "|" +taxa2.ToString().PadRight(10) + "|"+ taxa25.ToString().PadRight(10) + "|" + taxa3.ToString());
            }
            menu();
        }

        static public void decompor()
        {
            Console.WriteLine("Introduza um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string str = num.ToString();
            int lenght = str.Length;
            double soma = 0;
            for (int i = 0; i < lenght; i++)
            {
                soma = soma + (str[i] * Math.Pow(10, lenght));
                lenght--;
            }
            Console.WriteLine(soma);
        }

        static public void word_count()
        {
            Console.WriteLine("Introduza uma string");
            string str = Console.ReadLine();
            int words = 0;
            Console.WriteLine(str.Length);
            for (int i = 0; i<= str.Length; i++)
            {
                if (i == 13) { break; }
                if(str[i] == ' ' && str[i+1] !=' ')
                {
                    words++;
                }
            }
            words++;
            Console.WriteLine("A string contem " + words.ToString()+" palavras");
        }
    }
}