using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class PouchValidation
    {
        [Required(ErrorMessage = "Введите название!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите сумму!")]
        public decimal Money { get; set; }
    }
}
