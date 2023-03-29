using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class HardDrive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }

        public HardDrive(int id, string name, int capacity, double price)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            Price = price;
        }
    }
}
