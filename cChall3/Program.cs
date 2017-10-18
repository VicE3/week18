using System;
using System.Collections.Generic;

namespace cChall3
{
    class Program
    {
        public static void Main(string[] args)
        {
			Dictionary<string, int> R2H =
			new Dictionary<string, int>();

			R2H.Add("Victoria", 23);
			R2H.Add("Malik", 21);
			R2H.Add("Chris", 21);
			R2H.Add("Lesley", 18);
            R2H.Add("Miguel", 21);
            R2H.Add("Hunter", 18);
            R2H.Add("Juan", 19);
            R2H.Add("Angel", 19);
            R2H.Add("Mickey", 19);
            R2H.Add("Ivan", 19);
            R2H.Add("Teia", 23);
            R2H.Add("Ian", 20);
            R2H.Add("Brittany", 23);
            R2H.Add("Markus", 18);
            R2H.Add("IM A RANDO STUDENT", 90);
            int R2HLength = R2H.Count;
            Console.WriteLine( "The total class number is " + R2HLength);

            R2H.Remove("IM A RANDO STUDENT");
            int R2HLength2 = R2H.Count;
            Console.WriteLine("After a student left it was " + R2HLength2);


            Console.WriteLine( "Victoria is " + R2H["Victoria"]);
            




		}
    }
}
