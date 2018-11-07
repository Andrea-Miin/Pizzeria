using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Pizza : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Ingredient> Id_Ingredient { get; set; }
        public virtual ICollection<Comment> Id_Comment { get; set; }
        [Required]
        public byte[] Photo { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}