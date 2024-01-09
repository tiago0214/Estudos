using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuApp.Classes
{
    public class Enums
    {

    }
    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProduct Produto;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}