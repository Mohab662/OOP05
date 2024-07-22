using OOP05.First_Project;
using OOP05.Second_Project;
using System.Drawing;

namespace OOP05
{
    internal class Program
    {
        public static void Swap(Point3D x, Point3D y ) 
        {
            Point3D temp ;
            temp = x;
            x= y;
            y= temp;

        }
        static void Main(string[] args)
        {
            #region First Project
            //int x, y, z;
            //bool X, Y, Z;

            //Point3D P = new Point3D(5, 10, 2);
            //Console.WriteLine(P.ToString());

            //do {  X = int.TryParse(Console.ReadLine(), out x); }
            //while (X!=true);
            //do { Y = int.TryParse(Console.ReadLine(), out y); }
            //while (Y != true);
            //do { Z = int.TryParse(Console.ReadLine(), out z); }
            //while (Z != true);          
            //Point3D P1 = new Point3D(x, y, z);
            //Console.WriteLine("P1");
            //Console.WriteLine(P1.ToString());

            //do { X = int.TryParse(Console.ReadLine(), out x); }
            //while (X != true);
            //do { Y = int.TryParse(Console.ReadLine(), out y); }
            //while (Y != true);
            //do { Z = int.TryParse(Console.ReadLine(), out z); }
            //while (Z != true);
            //Point3D P2 = new Point3D(x, y, z);
            //Console.WriteLine("P2");
            //Console.WriteLine(P2.ToString());


            //    Console.WriteLine(P1 == P2); // Give False Till the two objects Have save Values 

            //   Point3D[] points = 
            //{
            //   new Point3D(6, 12, 15),
            //   new Point3D(2, 9, 1),
            //   new Point3D(8, 4, 9),
            //   new Point3D(8, 6, 4)
            //};
            //   for (int i = 0; i < points.Length; i++)
            //   {
            //       for (int j = 0; j < points.Length - j - i; j++)
            //       {
            //           if (points[i].CompareTo(points[j+1])==1)
            //           {
            //               Console.WriteLine(points[i].CompareTo(points[j + 1])==1);
            //               Swap(points[i], points[j + 1]);
            //           }
            //       }
            //   }

            //   foreach (var po in points)
            //   {
            //       Console.WriteLine(po);
            //   }

            //   Console.WriteLine("////////////////");
            //   Point3D P3;
            //   P3 =(Point3D) P.Clone();
            //   Console.WriteLine(P3); 
            #endregion

            #region Second Project
            //Console.WriteLine(Maths.Multiply(5, 2));
            //Console.WriteLine(Maths.Subtract(5, 2));
            //Console.WriteLine(Maths.Divide(0, 2));
            //Console.WriteLine(Maths.Add(5, 2)); 
            #endregion





        }
    }
}
