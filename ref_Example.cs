using System;
namespace Interview_Program
{
    public class ref_Example
    {
         static void Main(string[] args)
         {
             int someInt;
             SomeMethod2(out someInt); // Out displays initalized variable value
             Console.WriteLine(someInt); //2

             SomeMethod1(ref someInt);// ref gives modified output
             Console.WriteLine(someInt);//1

             SomeMethod(someInt);// data not change in assign value at run time
             Console.WriteLine(someInt);//1

             Console.ReadLine();
         }
         static void SomeMethod(int value)
         {
             value = 0;
         }
         static void SomeMethod1(ref int value)
         {
             value = 1;
         }
         static void SomeMethod2(out int value)
         {
           value = 2;
        }
    }
}
