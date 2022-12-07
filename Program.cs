
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Animal_Informations_System
{
    public class Program// class to run the program
    {
        static void Main(string[] args)
        {
           Core run = new Core();
           run.Run();
        }
    }
    class Core
    {
      public void Run() //class for making the program
      {

      
      start:
      Console.WriteLine("         ANIMAL INFORMATION SYSTEM");
       
      Console.WriteLine("-----------------------------------------------------------");
      Console.WriteLine();
      Console.WriteLine("[1] Cat                                           [2]Dog");
      Console.WriteLine("[3] Cho Tre                                             ");
      Console.WriteLine();
      Console.WriteLine();
    
      Console.Write("Choose your number to check: ");
    string input = Console.ReadLine();
    bool issuccess;
    int check;
    issuccess = int.TryParse(input, out check);
    if (issuccess == true)
    {
      Console.WriteLine("The program is checking...");
      Console.WriteLine("Successfully checked!!!");
    }else
    {
      Console.WriteLine("The program is checking...");
      Console.WriteLine("Check failed!!!");
      Console.WriteLine("Press Ctrl + C to exit, Enter to back the menu...");
      Console.ReadKey(true);
      goto start;
    }

    if (check == 1)
    {
      Animal cat = new Animal();
      cat.CatInfor();
      goto start;
/*
    }else if (check == 2)
    {
        Dog();
        Console.WriteLine("Press Ctrl + C to exit, Enter to continue...");
        Console.ReadKey(true);
        goto start;
    }else if (check == 3)
    {
      ChoTre();
    Console.WriteLine("Press Ctrl + C to exit, Enter to continue...");
    Console.ReadKey(true);
    goto start;*/
    }else 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This number isn't in this list!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Press Ctrl + C to exit, Enter to back to menu...");
        Console.ReadKey(true);
        goto start;
    }
        
    }
    }

    class Animal //class for making animal
    {
      public void CatInfor()
      {
        InforAnimal Cat = new InforAnimal("Cat",15.5f,2.2f,50,"No Danger");
        Cat.infor();
        Console.WriteLine("Press Ctrl + C to exit, Enter to back the menu...");
        Console.ReadKey(true);
      }
      }

    class InforAnimal //class for creating informations of animal
    {
      public string Name;
      public float Weight;
      public float Height;
      public int Iq;
      public string DangerRange;

      public InforAnimal (string name, float weight, float height, int iq, string dangerRange)
      {
        Name = name;
        Weight = weight;
        Height = height;
        Iq = iq;
        DangerRange = dangerRange;
       
      }
      public void infor()
      {
         Console.WriteLine("                  "+Name);
        Console.WriteLine("Weight: "+Weight+" kg");
        Console.WriteLine("Height: "+Height+" m");
        Console.WriteLine("IQ: "+Iq);
        Console.WriteLine("Danger Range: "+DangerRange);
      }
      

    }

    
}