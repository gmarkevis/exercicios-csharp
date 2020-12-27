using enumeracao_composicao_exercicio_ordem_de_pedido.Entities;
using enumeracao_composicao_exercicio_ordem_de_pedido.Entities.Enums;
using System;
using System.Globalization;

namespace enumeracao_composicao_exercicio_ordem_de_pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order ? ");
            int qtdOrders = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtdOrders; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtdProducts = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(qtdProducts, productPrice, product);
                order.addItem(item);
            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order.ToString());
        }
    }
}
