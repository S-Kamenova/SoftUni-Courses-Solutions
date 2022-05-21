using System;
using System.Collections.Generic;
using System.Linq;

namespace L06.StoreBoxes
{

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox
        {
            get
            {
                return this.Quantity * this.Item.Price;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string comand = Console.ReadLine();

            while (comand!="end")
            {
                string[] token = comand.Split();
                string serialNumber = token[0];
                string name = token[1];
                int quantity = int.Parse(token[2]);
                decimal price = decimal.Parse(token[3]);

                Box newBox = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = new Item()
                    {
                        Name = name,
                        Price = price
                    },
                    Quantity = quantity,
                };
                boxes.Add(newBox);

                comand = Console.ReadLine();

            }
            List<Box> orderBoxes = boxes.OrderByDescending(box => box.PriceBox).ToList();

            foreach (Box box in orderBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");

            }
        }
    }
}
