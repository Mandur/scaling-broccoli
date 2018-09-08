using System;

namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = LoRaFactory.create(true);
            //How do I access result.HowDoIAccessMe without a cast now?
        }
    }
}
