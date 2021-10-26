using System;

namespace ObjectsInCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myRectangle = new Rectangle
            //{
            //    X = 10,
            //    Y = 5,
            //    Width = 20,
            //    Height = 4,
            //};
            var myRectangle = 
                new Rectangle(10, 5, 20, 4);
            //myRectangle.X = 50;
            //Console.WriteLine(myRectangle.X);

            Console.WriteLine(myRectangle.GetX());
            myRectangle.SetX(10);
            //Console.WriteLine(myRectangle.XX);
            //myRectangle.XX = 7;
            Console.WriteLine(myRectangle.Area);


            var area = myRectangle.CalculateArea();
            var circumference = myRectangle.CalculateCircumference();

            Console.WriteLine(area);
        }

        /*
        private static int CalculateArea(Rectangle myRectangle)
        {
            return myRectangle.Height * myRectangle.Width;
        }
         
         */

        static void MainX(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             *  personA = {
                    name: 'Per',
                    age: 18,
                }
             */
            /*
            var personA = new Person
            {
                Name = "Per",
                Age = 18,
            };
            var personB = new Person
            {
                Name = "Pål",
                Age = 19,
            };
            Person.Species = "Homo Sapiens";
            */
            /*
            KeyValuePair<List<int>, Dictionary<bool, string>> x1 = new KeyValuePair<List<int>, Dictionary<bool, string>>();
            KeyValuePair<List<int>, Dictionary<bool, string>> x3 = new();
            var x2 = new KeyValuePair<List<int>, Dictionary<bool, string>>();
            */
        }
    }
}
