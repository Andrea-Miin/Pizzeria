using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DtoPizza
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public ICollection<Ingredient> Id_Ingredient { get; set; }
    }
}
