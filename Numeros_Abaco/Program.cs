using System;
using System.Threading;

namespace Numeros_Abaco
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] soma1 = new int[5];
           
            Random num = new Random();
            Console.WriteLine("Este programa tem objetivo de ajudar minha Julinha a fazer conta no abaco e também de cabeça, a Julinha\nVai ser muito inteligente::::\nde seu paizao de Deus 16/06/20");
            Console.WriteLine("\n\n\nESTÁ PRONTA? pegue seu ABACO E VAMOS COMEÇAR\ndigite ENTER para iciar");
            Console.ReadLine();
            Console.Clear();
            inicio:
            int aux = 0;
            int soma2 = 0, soma3 = 0;
            for (int i = 0; i < soma1.Length; i++)
            {

                aux = num.Next(100, 999);
                Console.Beep();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n                               "+ aux);
                soma2 += aux;
                Thread.Sleep(3000);
                Console.Clear();

            }
            Console.WriteLine("\ntotal dos números é "+soma2);
            Console.WriteLine("\nPara treinar conta de cabeça digite 1:\nPara voltar proabaco digite 2:");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha==2)
            {
                goto inicio;
            }
            if (escolha==1)
            {

                goto parte2;
            }
        parte2:
            soma3 = 0;
            aux = 0;
            Console.WriteLine("Vamos treinar a mente :");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < soma1.Length; i++)
            {

                aux = num.Next(10, 99);
                Console.Beep();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n                             " + aux);
                soma3 += aux;
                Thread.Sleep(3000);
                Console.Clear();

            }
            Console.WriteLine("\ntotal dos números é " + soma3);
            Console.WriteLine("se você consegiu não sei nem o que falar pra você, porque é realmente dificil GAROTA POWER!!!");
            Console.WriteLine("\n\n\nPara treinar conta de cabeça digite 1:\nPara voltar proabaco digite 2:");
             escolha = int.Parse(Console.ReadLine());
            if (escolha == 2)
            {
               
                goto inicio;
            }
            if (escolha == 1)
            {
                
                goto parte2;
            }
            Console.Clear();



        }
    }
}
