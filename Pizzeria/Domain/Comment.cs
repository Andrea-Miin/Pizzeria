using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Comment : EntityBase
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string User { get; set; }

        [Required]
        public int Id_Pizza { get; set; }
        public Pizza Pizza { get; set; }
    }
}
