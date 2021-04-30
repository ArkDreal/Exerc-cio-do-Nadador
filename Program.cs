using System;

namespace Exercicio_Nadador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
            int idadePessoa = int.Parse(Console.ReadLine());

            if (idadePessoa < 5)
            {
                Console.WriteLine("Você não é classificável ");
            }

            else
            {
                if (idadePessoa <= 7)
                {
                    Console.WriteLine("Sua categoria é: Infantil A");
                }

                else
                {
                    if (idadePessoa <= 10)
                    {
                        Console.WriteLine("Sua categoria é: Infantil B");
                    }


                    else
                    {
                        if (idadePessoa <= 13)
                        {
                            Console.WriteLine("Sua categoria é: juvenil A");
                        }

                        else
                        {
                            if (idadePessoa <= 17)
                            {
                                Console.WriteLine("Sua categoria é: Juvenil B");
                            }

                            else
                            {
                                if (idadePessoa >= 18)
                                {
                                    Console.WriteLine("Sua categoria é: Sênior");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
