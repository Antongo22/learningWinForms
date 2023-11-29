using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace learningWinForms
{
    internal static class Products
    {
        class Product
        {
            public string name;
            public string group;
            public double price;
            public string warehouse;

            public Product(string name, string group, double price, string warehouse)
            {
                this.name = name;
                this.group = group;
                this.price = price;
                this.warehouse = warehouse;
            }

            public override string ToString()
            {
                return $"Продукт - {name}, Группа - {group}, Цена - {price}, Склад - {warehouse}";
            }
        }

        static List<Product> products;

        public static void GetProducts(bool isShow = false)
        {
            products = new List<Product>();

            string[] text = File.ReadAllLines("prod.txt");

            string prT = "";

            foreach (string line in text)
            {
                string[] param = line.Split('%');

                Product p = new Product(param[0], param[1], double.Parse(param[2], CultureInfo.InvariantCulture), param[3]);
                products.Add(p);
                prT += p + "\n";
            }

            if (isShow)
            {
                MessageBox.Show(prT);
            }
        }

        public static void GetMidPrise()
        {
            List<string> warehouses = new List<string>();

            foreach (var p in products)
            {
                if (!warehouses.Contains(p.warehouse))
                {
                    warehouses.Add(p.warehouse);
                }
            }

            foreach (var warehouse in warehouses)
            {
                var productsInWarehouse = products.Where(p => p.warehouse == warehouse).ToList();

                if (productsInWarehouse.Count > 0)
                {
                    double averagePrice = productsInWarehouse.Average(p => p.price);
                    MessageBox.Show($"Средняя стоимость товаров на складе {warehouse}: {averagePrice.ToString("0.00", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    MessageBox.Show($"Нет товаров на складе {warehouse}");
                }
            }
        }

        public static void GetTotalPriceByGroup()
        {
            List<string> groups = new List<string>();

            foreach (var p in products)
            {
                if (!groups.Contains(p.group))
                {
                    groups.Add(p.group);
                }
            }

            foreach (var group in groups)
            {
                var productsInGroup = products.Where(p => p.group == group).ToList();

                if (productsInGroup.Count > 0)
                {
                    double totalPrice = productsInGroup.Sum(p => p.price);
                    MessageBox.Show($"Суммарная стоимость товаров в группе {group}: {totalPrice.ToString("0.00", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    MessageBox.Show($"Нет товаров в группе {group}");
                }
            }
        }

    }


}
