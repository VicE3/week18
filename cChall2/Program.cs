using System;

namespace cChall2
{
    class Program
    {
        class Car
        {
			public string Model { get; set; }
			public int Tires { get; set; }
            public int Year { get; set; }
        }

		class MainClass
		{
			static void Main()
			{
				var car1 = new Car
				{
					Model = "Nissan",
					Tires = 4,
                    Year = 2015
				};
				
                Console.WriteLine($"Model: {car1.Model}. Tires: {car1.Tires}. Year: {car1.Year}");

				var car2 = new Car
				{
					Model = "Honda",
					Tires = 4,
					Year = 2007
				};

				Console.WriteLine($"Model: {car2.Model}. Tires: {car2.Tires}. Year: {car2.Year}");

				var car3 = new Car
				{
					Model = "Toyota",
					Tires = 4,
					Year = 2009
				};

				Console.WriteLine($"Model: {car3.Model}. Tires: {car3.Tires}. Year: {car3.Year}");
				
			}
		}
    }
}
