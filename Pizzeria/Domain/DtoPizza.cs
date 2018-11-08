using System.Collections.Generic;

namespace Domain
{
    public class DtoPizza
    {
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public ICollection<Ingredient> Collection_Ingredient { get; set; } 
    }
}