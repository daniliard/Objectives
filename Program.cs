using System;
using System.Collections.Generic;

namespace ProductList
{
    class Program
    {
        enum ProductGroup
        {
            КухоннiПрилади,
            Оргтехнiка,
            КомпютериТаКопмпоненти
        }

        enum ProductName
        {
            Блендер,
            Мультиварка,
            Мiксер,
            Тостер,
            Принтер,
            Сканер,
            Телефон,
            ПК,
            Ноутбук,
            Вiдекокарта,
            Оперативка,
            ЖорсткийДиск
            
        }

        static Dictionary<ProductGroup, List<ProductName>> products = new Dictionary<ProductGroup, List<ProductName>>()
        {
            { ProductGroup.КухоннiПрилади, new List<ProductName>() { ProductName.Блендер, ProductName.Мультиварка, ProductName.Мiксер, ProductName.Тостер } },
            { ProductGroup.Оргтехнiка, new List<ProductName>() { ProductName.Принтер, ProductName.Сканер, ProductName.Телефон } },
            { ProductGroup.КомпютериТаКопмпоненти, new List<ProductName>() { ProductName.ПК, ProductName.Ноутбук, ProductName.Вiдекокарта, ProductName.Оперативка, ProductName.ЖорсткийДиск } }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Список товарiв:");
            foreach (ProductGroup group in Enum.GetValues(typeof(ProductGroup)))
            {
                Console.WriteLine($"Група: {group}");
                foreach (ProductName product in products[group])
                {
                    Console.WriteLine($"{(int)product} - {product}");
                }
                Console.WriteLine();
            }

            Console.Write("Введiть номер товару: ");
            string input = Console.ReadLine();
            string[] productNumbers = input.Split(',');
            List<ProductName> selectedProducts = new List<ProductName>();
            foreach (string productNumber in productNumbers)
            {
                if (Enum.TryParse(productNumber.Trim(), out ProductName productName))
                {
                    selectedProducts.Add(productName);
                }
            }

            Console.WriteLine("Обраний товар:");
            foreach (ProductGroup group in Enum.GetValues(typeof(ProductGroup)))
            {
                Console.WriteLine($"Група: {group}");
                foreach (ProductName product in selectedProducts)
                {
                    if (products[group].Contains(product))
                    {
                        Console.WriteLine($"{(int)product} - {product}");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Автор: Молодорич Данiл");
            Console.ReadKey();
        }
    }
}


