using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_IDZ
{
    internal class Sklad
    {
        public static Dictionary<Client,Tovar> dictionary = new Dictionary<Client,Tovar>();
        public static List<Tovar> tovars = new List<Tovar>();
        public static List<Client> clients = new List<Client>();

        public static void Initial()
        {
            var tovar=new Tovar();
            tovar.price = 1999;
            tovar.name = "Avokado";
            tovar.count = 12;
            tovars.Add(tovar);
            tovar = new Tovar();
            tovar.price = 199;
            tovar.name = "Knife";
            tovar.count = 1;
            tovars.Add(tovar);
            Client client = new Client("Magnit", "001");
            Client client2 = new Client("5opka", "002");
            clients.Add(client);
            clients.Add(client2);
            dictionary.Add(clients[0], tovars[1]);
            dictionary.Add(clients[1], tovars[0]);
        }

        public static void Zakaz(Client client)
        {
            foreach (Client client2 in clients)
            {
                if (client.id == client2.id)
                {
                    foreach (var client1 in dictionary.Keys)
                    {
                        if (client.id == client1.id)
                        {
                            string name = dictionary[client1].name;
                            int price = dictionary[client1].price;
                            Console.WriteLine($"Ваш заказ: {price}  {name} " + "\n" +
                                "Оформить вывоз?\n" +
                                "1- Да\n" +
                                "2- Нет");
                            int doIt = int.Parse(Console.ReadLine());
                            switch (doIt)
                            {
                                case 1:
                                    Console.WriteLine("Заказ оформлен.");
                                    break;
                                case 2:
                                    break;
                                default: break;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("У покупателя нет заказов.");
                            break;
                        }
                    }
                    break;

                }
                else
                {
                    Console.WriteLine("Данного покупателя нет в базе!");
                    break;
                }
            }
        }

        public static void TovarsList()
        {
            if (tovars.Count != 0)
            {
                foreach (Tovar tariff in tovars)
                {
                    Console.WriteLine(tariff.name + "\n" + tariff.price + "\n" + tariff.count);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Список товаров на складе пуст");
            }
        }
    }
}
