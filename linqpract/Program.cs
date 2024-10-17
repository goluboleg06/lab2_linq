using linqpract;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product{Code = 1, Name= "Ручка", Price = 10, Quantity= 100},
                new Product{Code = 2, Name= "Зошит", Price = 15, Quantity= 35},
                new Product{Code = 3, Name= "Лінійка", Price = 30, Quantity= 50},
                new Product{Code = 4, Name= "Олівець", Price = 10, Quantity= 100},
                new Product{Code = 5, Name= "Зошит", Price = 15, Quantity= 35},
                new Product{Code = 6, Name= "Лінійка", Price = 30, Quantity= 50},
                new Product{Code = 7, Name= "Ручка", Price = 10, Quantity= 100},
                new Product{Code = 8, Name= "Зошит", Price = 15, Quantity= 35},
                new Product{Code = 9, Name= "Лінійка", Price = 30, Quantity= 50},
                new Product{Code = 10, Name= "Ручка", Price = 10, Quantity= 100},
                new Product{Code = 11, Name= "Зошит", Price = 15, Quantity= 35},
                new Product{Code = 12, Name= "Лінійка", Price = 30, Quantity= 50},
                new Product{Code = 13, Name= "Ручка", Price = 10, Quantity= 100},
                new Product{Code = 14, Name= "Зошит", Price = 15, Quantity= 35},
                new Product{Code = 15, Name= "Лінійка", Price = 30, Quantity= 50},
                new Product{Code = 16, Name= "Ручка", Price = 10, Quantity= 100},
                new Product{Code = 17, Name= "Зошит", Price = 15, Quantity= 35},
                new Product{Code = 18, Name= "Лінійка", Price = 30, Quantity= 50},
                new Product{Code = 19, Name= "Ручка", Price = 10, Quantity= 100},
                new Product{Code = 20, Name= "Зошит", Price = 15, Quantity= 35}


            };
            var supplies = new List<Supply>
            {
                new Supply {Code = 1, Date= new DateTime(2023,9,12), Price = 12, VendorName= "Василишин Устина", SupplyQuantity = 200},
                new Supply {Code = 2, Date= new DateTime(2023,6,4), Price = 17, VendorName= "Горовенко Тиміш", SupplyQuantity = 500},
                new Supply {Code = 3, Date= new DateTime(2023,8,12), Price = 23, VendorName= "Думка Фаїна", SupplyQuantity = 130},
                new Supply {Code = 4, Date= new DateTime(2024,9,12), Price = 7, VendorName= "Колодницький Добриня", SupplyQuantity = 200},
                new Supply {Code = 5, Date= new DateTime(2024,6,4), Price = 10, VendorName= "Штанько Любислава", SupplyQuantity = 500},
                new Supply {Code = 6, Date= new DateTime(2024,8,12), Price = 25, VendorName= "Щербатюк Захарій", SupplyQuantity = 130},
                new Supply {Code = 7, Date= new DateTime(2024,9,12), Price = 10, VendorName= "Ємельяненко Славобор", SupplyQuantity = 200},
                new Supply {Code = 8, Date= new DateTime(2024,6,4), Price = 10, VendorName= "Головач Батко", SupplyQuantity = 500},
                new Supply {Code = 9, Date= new DateTime(2024,8,12), Price = 25, VendorName= "Ерстенюк Квітан", SupplyQuantity = 130},
                new Supply {Code = 10, Date= new DateTime(2024,9,12), Price = 10, VendorName= "Івановський Ігор", SupplyQuantity = 200},
                new Supply {Code = 11, Date= new DateTime(2024,6,4), Price = 10, VendorName= "Удовенко Устина", SupplyQuantity = 500},
                new Supply {Code = 12, Date= new DateTime(2024,8,12), Price = 25, VendorName= "Щербацький Іларіон", SupplyQuantity = 130},
                new Supply {Code = 13, Date= new DateTime(2024,9,12), Price = 10, VendorName= "Андрійченко Гордомисл", SupplyQuantity = 200},
                new Supply {Code = 14, Date= new DateTime(2024,6,4), Price = 10, VendorName= "Кропивницька Христина", SupplyQuantity = 500},
                new Supply {Code = 15, Date= new DateTime(2024,8,12), Price = 25, VendorName= "Щурат Курило", SupplyQuantity = 130},
                new Supply {Code = 16, Date= new DateTime(2024,9,12), Price = 10, VendorName= "Голубничий Фота", SupplyQuantity = 200},
                new Supply {Code = 17, Date= new DateTime(2024,6,4), Price = 10, VendorName= "Їжак Єгор", SupplyQuantity = 500},
                new Supply {Code = 18, Date= new DateTime(2024,8,12), Price = 25, VendorName= "Банах Назарій", SupplyQuantity = 130},
                new Supply {Code = 19, Date= new DateTime(2024,9,12), Price = 10, VendorName= "Юрчишин Божемир", SupplyQuantity = 200},
                new Supply {Code = 20, Date= new DateTime(2024,6,4), Price = 10, VendorName= "Шкіль Микола", SupplyQuantity = 500},

            };

            //Сортування списку поставок за ціною
            IEnumerable<Supply> orderByPrice = supplies.OrderBy(supplies => supplies.Price);

            foreach (var el in orderByPrice)
            {
                Console.WriteLine($"Код: {el.Code}; Дата: {el.Date}; Ціна: {el.Price}; Ім'я поставщика: {el.VendorName}; Обсяг товару: {el.SupplyQuantity};");
            }

            /* Вивести середній обсяг поставок товару з заданим кодом,здійснених
             протягом другого півріччя минулого року*/
            double avrg = 0;
            Console.WriteLine("Код=");
            int code = Convert.ToInt32(Console.ReadLine());
            var SecondHalfLastYear = new DateTime[]
            {
                new DateTime(2023,7,1),
                new DateTime(2023,12,31)
            };
            IEnumerable<Supply> suppliesByCode = supplies.Where(s => s.Code == code && s.Date >= SecondHalfLastYear[0] && s.Date <= SecondHalfLastYear[1]);


            foreach (var el in suppliesByCode)
            {
                avrg += el.SupplyQuantity;
            }
            if (suppliesByCode.Any())
            {
                avrg /= suppliesByCode.Count();
                Console.WriteLine($"Середній обсяг поставок: {avrg}");
            }

            /*Вивести постачальників, які поставили товар із заданою назвою за найменшою ціною*/
            Console.WriteLine("Назва товару: ");
            string inputName = Console.ReadLine();
            var suppliers = supplies
                .Where(s => products.Any(p => p.Code == s.Code && p.Name == inputName))
                .GroupBy(s => s.VendorName)
                .OrderBy(g => g.Min(s => s.Price))
                .Select(g => new { Supplier = g.Key, Price = g.Min(s => s.Price) });
            if (suppliers.Any())
            {

            Console.WriteLine($"Постачальники товару з назвою {inputName} за найменшою ціною:");
            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"Постачальник: {supplier.Supplier}, Ціна за одиницю: {supplier.Price}");

            }
            }
            else
            {
                Console.WriteLine($"Постачальників товару з назвою {inputName} не знаЙдено.");
            }
        }
    }
}
