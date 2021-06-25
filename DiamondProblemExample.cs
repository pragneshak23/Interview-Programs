using System;
namespace Interview_Program
{
    
        interface IMother
        {
            void Loan();
        }
        interface IFather
        {
            void Loan();
        }
        public class Mother : IMother
        {
            public void Loan()
            {
                Console.WriteLine("Loan taken by mother.");
            }
        }
        public class Father : IFather
        {
            public void Loan()
            {
                Console.WriteLine("Loan taken by father");
            }
        }
        public class Child : IMother, IFather
        {
            void IMother.Loan()
            {
                Console.WriteLine("Mother's loan paid by child");
            }

            void IFather.Loan()
            {
                Console.WriteLine("Father's loan paid by child");
            }
        }

        public class DiamondProblem
        {
            static void Main(string[] args)
            {
                Child child = new Child();
                ((IMother)child).Loan();
                ((IFather)child).Loan();

                Console.ReadLine();
            }
        }
    }

