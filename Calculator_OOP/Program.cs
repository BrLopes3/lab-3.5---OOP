using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*Student: Bruno Rafael Ferreira Lopes
  --------Lab 3.5 - OOP------------- */

namespace Calculator_OOP
{
    class Calc
    {
        private double number1;
        private double number2;

        public Calc() { } //default constructor
        
        public Calc(double number1, double number2) //constructor with 2 arguments
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        
        //Proprieties
        public double Number1 
        {
            get { return number1; }
            set { number1 = value; }
        }
        public double Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        //Methods
        public double Add(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }
        public double Sub(double n1, double n2)
        {
            double sub = n1 - n2;
            return sub;
        }
        public double Mult(double n1, double n2)
        {
            double mult = n1 * n2;
            return mult;
        }
        public dynamic Div(double n1, double n2)
        {
            if (n2 != 0) //verification to avoid divide by 0
            {
                double div = Math.Round(n1 / n2,2);
                return div;
            }     
            else
            {
                string div1 = "Not possible divide by 0";
                return div1;
            }
        }
        public void Display1(double n1, double n2) //display the results of the operations
        {
            Console.WriteLine("Result using defaut constructor\n");
            Console.WriteLine("Your numbers are: {0} & {1}\n================Results================\n {0}+{1} = {2}\n {0}-{1} = {3}\n {0}*{1} = {4}\n {0}/{1} = {5}\n=======================================", n1, n2, Add(n1,n2), Sub(n1,n2), Mult(n1,n2), Div(n1,n2) );
            Console.ReadKey ();
        }

        public void Display2(double n1, double n2) //display the results of the operations
        {
            Console.WriteLine("Result using constructor with 2 arguments\n");
            Console.WriteLine("Your numbers are: {0} & {1}\n================Results================\n {0}+{1} = {2}\n {0}-{1} = {3}\n {0}*{1} = {4}\n {0}/{1} = {5}\n=======================================\n", n1, n2, Add(n1, n2), Sub(n1, n2), Mult(n1, n2), Div(n1, n2));
            Console.ReadKey();
        }

    }//end class Calc

    internal class Program
    {
        static void Main(string[] args)
        {
          label1:
            Calc calc1 = new Calc(); //first obj with the defaut constructor
            Console.WriteLine("For the first object enter with the values:\n");
          label2:
            Console.Write("Please enter the first number:");
            try
            {
                calc1.Number1 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex1)
            {
                Console.WriteLine(ex1.Message);
                goto label2;
            }
         label3:   
            Console.Write("Please enter the second number:");
            try
            {
                calc1.Number2 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex2)
            {
                Console.WriteLine(ex2.Message);
                goto label3;
            }
            
            Console.WriteLine();

            calc1.Display1(calc1.Number1, calc1.Number2);

            Console.WriteLine("\nFor the second object using the constructor with arguments 9 and 3\n");
            
            Calc calc2 = new Calc(9,3); //second obj using the constructor with 2 parameters (9 & 3)
            Console.WriteLine();
            calc2.Display2(9,3);
            label4:
            Console.WriteLine("Do you want to continue doing calculations Y or N ?");
            string opt = Console.ReadLine();
            opt = opt.ToUpper();
            if(opt !="Y" && opt != "N")
            {
                Console.WriteLine("Enter with a valid option Y or N");
                goto label4;
            }
            else
            {
                if(opt == "Y")
                {
                    goto label1;
                }
                else
                {
                    Console.WriteLine("Bye Bye");
                    
                }
            }

        }//end main
    }//end class Program
}//end namespace
