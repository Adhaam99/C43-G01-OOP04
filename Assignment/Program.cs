

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q1 -  Write a class named Calculator that contains a method named Add. Overload the Add method to:


            //Calculator calculator = new Calculator();

            //Console.WriteLine(calculator.Add(10, 20));

            //Console.WriteLine(calculator.Add(10, 20, 20));

            //Console.WriteLine(calculator.Add(10.5, 20.1));

            #endregion

            #region Q2 - Create a class named Rectangle with the following constructors:

            //Rectangle rectangle = new Rectangle();

            //Console.WriteLine(rectangle.ToString());

            //Rectangle recatngle = new Rectangle(10 , 20);

            //Console.WriteLine(recatngle);

            //Rectangle recatngle = new Rectangle(10);

            //Console.WriteLine(recatngle);

            #endregion

            #region Q3 - Define a class Complex Number that represents a complex number with real and imaginary parts.

            //ComplexNumber C1 = new ComplexNumber() { Real = 7 , Img = 3};

            //ComplexNumber C2 = new ComplexNumber() { Real = 10, Img = 6 };

            ////ComplexNumber C3 = C1 + C2;

            ////Console.WriteLine(C3);

            //ComplexNumber C3 = C1 - C2;

            //Console.WriteLine(C3);

            #endregion

            #region Q4 

            #region a) Create a base class named Employee with method That Work as it prints "Employee is working".

            //Employee employee = new Employee();

            //employee.Work();

            #endregion

            #region b) Create a derived class named Manager that overrides the Work method to print "Manager is managing".

            //Manager manager = new Manager();

            //manager.Work();

            #endregion

            #endregion

            #region Q5

            //BaseClass baseClass = new BaseClass();

            //baseClass.DisplayMessage();

            //DerivedClass1 D1 = new DerivedClass1();

            //D1.DisplayMessage();

            //DerivedClass2 D2 = new DerivedClass2();

            //D2.DisplayMessage();

            /*
             * The override keyword is used to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
             * 
             * When a method in a derived class is marked with override, it replaces the method with the same signature in the base class. The base class method must be marked with virtual, abstract, or override.
             * 
             * [Dynamic-Ploymorphism] in the runtime.
             * 
             * 
             * 
             * The new keyword is used to hide a member of the base class. This means you are creating a new member in the derived class that has the same name as one in the base class.
             * 
             * When a method in a derived class is marked with new, it hides the method with the same signature in the base class. This does not replace the base class method but creates a new method in the derived class.
             * 
             * [Static-Polymorphism] in the compile time.
            */

            #endregion




            #endregion


            #region Part02

            //Duration D1 = new Duration(1, 10, 15);

            //Console.WriteLine(D1.ToString());

            Duration D1 = new Duration(3600);

            Duration D2 = new Duration(7800);

            Duration D3 = new Duration(666);

            //Console.WriteLine(D1.ToString());

            //Console.WriteLine(D2.ToString());

            //Console.WriteLine(D3.ToString());

            //D3 = D1 + D2;

            //Console.WriteLine(D3.ToString());

            //D3 = D1 + 7800;

            //Console.WriteLine(D3.ToString());

            //D3 = 666 + D3;

            //Console.WriteLine(D3.ToString());

            //D1 = D1 - D2;

            //Console.WriteLine(D1.ToString());

            //if (D1 > D2)
            //    Console.WriteLine(" D1 > D2 ");
            //else if (D1 < D2)
            //    Console.WriteLine(" D1 < D2 ");
            //else
            //    Console.WriteLine(" D1 = D2 ");


            //if (D1 <= D2)
            //    Console.WriteLine(" D1 <= D2 ");
            //else
            //    Console.WriteLine(" D1 > D2 ");
            
            //DateTime obj = new DateTime();

            // obj = (DateTime)D3;

            //Console.WriteLine(obj.ToString());

            #endregion
        }
    }
}
