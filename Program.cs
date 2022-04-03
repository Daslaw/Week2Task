using System;

namespace week2task
{
    class Program
    {
        static void Main(string[] args)
        {
            // string Datatype
            string myName = "LAWAL, Dauda Abiola";
            int myValue = 2002;
            Console.WriteLine(myName);
            Console.WriteLine(myValue);
            // float and Double
            float payment = 200.4f;
            double money = 50234320.35d;
            Console.WriteLine(money);
            Console.WriteLine(payment);
            // Boolean
            bool status = true;
            bool lifeStatus = false;
            Console.WriteLine(status);
            Console.WriteLine(lifeStatus);
            // dynamic
            dynamic myJob = "webeveloper";
            dynamic myNumber = 07060;
            Console.WriteLine(myJob);
            Console.WriteLine(myNumber);


            // long
            long myref = 473894999344L;
            Console.WriteLine(myref);
            // ulong
            ulong myAccount = 4786432113837ul;
            Console.WriteLine(myAccount);
            // decimal
            decimal dataref = 10065.87m;
            Console.WriteLine(dataref);
            // byte
            byte newbyte = 255;
            Console.WriteLine(newbyte);
            // short
            short packmoney = 345;
            Console.WriteLine(packmoney);

            // Implicit and explicit
            int package = 345;
            float newRandom = package;
            Console.WriteLine(newRandom);
            int food = 200;
            uint secondFood = (uint)food;
            Console.WriteLine(food);
            // Anonymous
            var anoTypes = new
            {
                name = "Central Bank",
                project = "design",
                Version = 5.0,
            };
            Console.WriteLine(anoTypes.Version);
        }
    }
}
