using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_IDZ
{
    class Programm
    {
        static void Main(string[] args)
        {

            Sklad.Initial();
            Console.WriteLine("Система учета товарно-материальных запасов готова к работе");
            Console.Write("Введите название компании? ");
            string fio = Console.ReadLine();
            Console.Write(fio + ", Введите id компании ");
            string id = Console.ReadLine();
            Client client=new Client(fio, id);
            Console.WriteLine("Уважаемый " + client.fio + ", выберите действие\n" +
                "1-Вывод списка товаров на складе\n" +
                "2-Проверить заказы\n" +
                "0-Выход");
            int doIt = int.MaxValue;
            while (doIt > 0)
            {
                Console.Write("Ваш выбор: ");
                doIt = int.Parse(Console.ReadLine());
                switch (doIt)
                {
                    case 1:
                        Sklad.TovarsList();
                        break;
                    case 2:
                        Sklad.Zakaz(client);
                        break;
                    case 0:
                        doIt = 0;
                        break;
                    default: break;

                }
            }
            Console.ReadLine();
        }
    }
}