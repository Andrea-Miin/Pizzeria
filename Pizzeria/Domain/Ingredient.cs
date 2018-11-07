using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ingredient : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Pizza Pizza { get; set; }
        static void create() { }
    }
}
