using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminalK.DiamondFebruary2019
{
    class Product
    {
        public string Name;
        public string Category;
        public string Description;      
        public double Price;
        
        public Product(string Name, string Category, string Description, double Price)

        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.Price = Price;
        
        }
    }

}