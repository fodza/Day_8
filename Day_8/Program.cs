using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //JaunaZvaigznite();
            PieciSkaitli();
        }

        /* static void MasivaPiemers()
         {
             int[] masivs = new int[4]; // "4" norada cik vertibas var saglabat
             masivs[0] = 1; //kastites, kuras kaut kas glabajas
             masivs[1] = 5;
             masivs[2] = 7;
             masivs[3] = 6;

             for (int i = 0; i < 4; i++)
             {
                 Console.WriteLine(masivs[i]);
             }

                 Console.ReadLine();
         }

         static void JaunaZvaigznite()
         {
             //*
             //**
             //***

             string[] zvaigznites = new string[3];
             zvaigznites[0] = "*";
             zvaigznites[1] = "**";
             zvaigznites[2] = "***";

             string mainigais2;
             for(int i = 0; i < 3; i++)
             {
                 if(i==1)
                 {
                     mainigais2 = zvaigznites[i];
                     Console.WriteLine("ieksa if");
                 }
                 Console.WriteLine("ara if");

             }

             for (int i = 0; i < 3; i++)
             {
                 Console.WriteLine(zvaigznites[i]);

             }

             Console.ReadLine();


         }*/
        static void PieciSkaitli()
        {
            string[] ievade = new string[5];
            int[] izvade = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet" + i + " vertibu ");
                ievade[i] = Console.ReadLine();
                izvade[i] = Convert.ToInt16(ievade[i]);

            }
            
            for (int i = 0; i < 1; i++)
            {

                Console.WriteLine(izvade[i] + izvade[i+1]+ izvade[i + 2]+izvade[i+3]+izvade[i+4]);
                
            }


            Console.ReadLine();


        }
            
        }
}
 