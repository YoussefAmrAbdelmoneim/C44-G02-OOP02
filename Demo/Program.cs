using Demo.Encapsulation;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct 

            #region Example 01
            //Point P1;
            //// Declare variable | Object From Type 'Point' 
            //// CLR Will Allocate 8 Unitintialized Bytes At Stack 

            //P1 = new Point();
            //// New Is Just For Constructor Selection That Will Used To Initialize P1 Attribute 
            //Console.WriteLine($"P1.X = {P1.x}"); // 0
            //Console.WriteLine($"P1.Y = {P1.y}"); // 0


            //P1 = new Point(10, 20);

            //P1 = new (10, 20); // Syntax Sugar 
            //Console.WriteLine($"P1.X = {P1.x}"); // 10
            //Console.WriteLine($"P1.Y = {P1.y}"); // 20


            //Console.WriteLine(P1); // (10 , 20)
            //Console.WriteLine(P1.ToString()); // (10 , 20) 
            #endregion

            #region Example 02

            //Point P1 = new Point(1 , 2);
            //Console.WriteLine($"P1.X = {P1.x}"); // 1 
            //Console.WriteLine($"P1.Y = {P1.y}"); // 2

            //Point P2 =	new Point(10 , 20);
            //Console.WriteLine($"P2.X = {P2.x}"); // 10 
            //Console.WriteLine($"P2.Y = {P2.y}"); // 20

            //P2 = P1;

            //Console.WriteLine("After Assign P2 = P1");
            //Console.WriteLine($"P1.X = {P1.x}"); // 1 
            //Console.WriteLine($"P1.Y = {P1.y}"); // 2
            //Console.WriteLine($"P2.X = {P2.x}"); // 1 
            //Console.WriteLine($"P2.Y = {P2.y}"); // 2

            //P1.x = 100;
            //P1.y = 200;

            //Console.WriteLine("After Changing P1 ");
            //Console.WriteLine($"P1.X = {P1.x}"); // 100 
            //Console.WriteLine($"P1.Y = {P1.y}"); // 200
            //Console.WriteLine($"P2.X = {P2.x}"); // 1 
            //Console.WriteLine($"P2.Y = {P2.y}"); // 2

            #endregion

            #endregion
            #region Encapsulation
            //Employee emp1 = new Employee();
            //emp1.setName("Ahmed");
            //Console.WriteLine(emp1.GetName());
            //emp1.Salary = 1;
            //Console.WriteLine(emp1.Salary);
            #endregion
        }
    }
}
