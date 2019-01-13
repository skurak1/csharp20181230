using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            ListCars();
        }
        private static void ListCars()
        {
            var cars = new List<Car>
 {
 { new Car() { Name = "car1", Color = "blue", Speed = 20}},
 { new Car() { Name = "car2", Color = "red", Speed = 50}},
 { new Car() { Name = "car3", Color = "green", Speed = 10}},
 { new Car() { Name = "car4", Color = "blue", Speed = 50}},
 { new Car() { Name = "car5", Color = "blue", Speed = 30}},
 { new Car() { Name = "car6", Color = "red", Speed = 60}},
 { new Car() { Name = "car7", Color = "green", Speed = 50}}
 };
            cars.Sort();

            foreach (Car thisCar in cars)
            {
                Console.Write(thisCar.Color.PadRight(5) + " ");
                Console.Write(thisCar.Speed.ToString() + " ");
                Console.Write(thisCar.Name);
                Console.WriteLine();
            }
        }
        //리턴값이 음수면 그대로, 양수면 뒤짚음
        public class Car : IComparable<Car>
        {
            public string Name { get; set; }
            public int Speed { get; set; }
            public string Color { get; set; }
            public int CompareTo(Car other)
            {

                // Compare the colors.
                int compare;

                //Compare는 문자열을 비교하여 왼쪽것이 작으면 음수, 크면 양수, 같으면 0을 리턴한다.
                //true는 대소문자를 무시하고 비교한다는 의미
                compare = String.Compare(this.Color, other.Color, true);
                if (compare == 0)
                {
                    compare = this.Speed.CompareTo(other.Speed);

                    compare = -compare;
                }
                return compare;
            }
        }
    }
}