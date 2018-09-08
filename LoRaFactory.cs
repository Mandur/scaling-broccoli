using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject
{

    public static class LoRaFactory{

        public static GenericLora create(bool _isOne)
        {
            if (_isOne)
                return new LoRaImplem1(1);
            else
                return new LoRaImplem2();
        }
    }


    public abstract class GenericLora
    {
    
        //common properties and methods
        public int DemoField { get; set; }
        public string GetDemo()
        {
            return "it works";
        }

    }
    class LoRaImplem1 : GenericLora
    {
        //specific field
        public int HowDoIAccessMe { get; set; }

        public LoRaImplem1(int _howDoIAccessMe)
        {
            HowDoIAccessMe = _howDoIAccessMe;
        }
    }

    class LoRaImplem2 : GenericLora
    {
        //No specific field here
    }
}
