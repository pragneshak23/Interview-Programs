using System;
namespace Interview_Program
{
    public class Is_a_relationTest
    {
        static void Main(string[] args)
        {
            //  B b = new A(); 
          

                //Because B, by extending A, is also an A.We say this in object-orientation terms
                //by saying that a B is -a A.This means that you can use a B anywhere you use an A.

                //This relationship is not commutative --B is -a A does not imply that A is -a B.
                //Therefore you cannot use an A anywhere you would use a B.

                //Consider this case:

                //class Animal;
                //        class Dog extends Animal;
                //        This makes sense:

                //Animal animal = new Dog();
                //        Anywhere it makes sense to use an Animal you can also use a Dog.This is intuitive.

                //        Dog dog = new Animal();
                //        This, on the other hand, does not make sense.


            A a = new B();
                //By using A obj = new B(); a new object of class B is created and assigned to variable obj.
                //This variable is actually of type class A. However, B is derived from A and this will work.

                //A super class reference variable can hold reference of sub-class object without casting.

            int result = a.Test();
            Console.WriteLine(result); // 10
            Console.ReadLine();
        } 
    }
    public class A
    {
        public int Test()
        {
            return 10;
        }
    }
    public class B : A
    {
        public int Test()
        {
            return 20;
        }
    }
}
