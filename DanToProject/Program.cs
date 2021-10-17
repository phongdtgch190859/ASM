using System;

namespace DanToProject
{
    class Program
    {
        static void Main(string[] args)
        {
        DoTask();
       
        }
        static void PrintStore()
        {
            System.Console.WriteLine("    Select Bread Store   ");
            System.Console.WriteLine("_________________________");
            System.Console.WriteLine("(1): Da Nang Bread Store ");
            System.Console.WriteLine("(2): Sai Gon Bread Store ");
            System.Console.WriteLine("(3): Hue Bread Store     ");
        }
        static void PrintMenu()
        {   
            
            System.Console.WriteLine("     Welcome to Bread Store             ");
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("                 -Menu-                 ");
            System.Console.WriteLine("*Garlic            20,000vnđ            ");
            System.Console.WriteLine("*Pate              15,000vnđ            ");
            System.Console.WriteLine("*Mixed             30,000vnđ            ");
            System.Console.WriteLine("----------------------------------------");

        }

        static void DoTask()
        {
            PrintStore();
            Console.WriteLine("Input your option ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:  
                {
                PrintMenu();
                DNSelectBread();
                break;
                }
                case 2:  
                {
                PrintMenu();
                SGSelectBread();
                break;
                }
                case 3:  
                {
                PrintMenu();
                HueSelectBread();
                break;
                }
                case 0: Quit();             break;
                default: ShowError();       break;
            }
            
        }

        static void Quit()
        {
            Console.WriteLine("Exit Pragram");
        }
        static void ShowError()
        {
            Console.WriteLine("Invalid option ");
        }
        static void DNSelectBread()
        {
            System.Console.WriteLine("Enter your Bread:");
            string type =Console.ReadLine();
            var DN =new DNBreadStore();
            DN.OrderPizza(type);
            int cost = Bill(type);
            Console.WriteLine("Your bill: " + cost);
        }
         static void SGSelectBread()
        {   
            System.Console.WriteLine("Enter your Bread:");
            string type =Console.ReadLine();
            var SG =new SGBreadStore();
            SG.OrderPizza(type);
            int cost = Bill(type);
            Console.WriteLine("Your bill: " + cost);
        }
        static void HueSelectBread()
        {
            System.Console.WriteLine("Enter your Bread:");
            string type =Console.ReadLine();
            var Hue =new HueBreadStore();
            Hue.OrderPizza(type);
            int cost = Bill(type);
            Console.WriteLine("Your bill: " + cost);
        }
        static int Bill(string type)
        {   
            int cost;
            if(type=="Mixed") cost=30000;
            else if(type=="Pate") cost=15000;
            else cost=20000;
            return cost;
        }
    }
}
