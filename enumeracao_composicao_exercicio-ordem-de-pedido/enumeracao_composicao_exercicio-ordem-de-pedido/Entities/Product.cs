using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace enumeracao_composicao_exercicio_ordem_de_pedido.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
