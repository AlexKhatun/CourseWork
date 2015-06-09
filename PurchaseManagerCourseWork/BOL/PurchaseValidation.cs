using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class PurchaseValidation
    {
        [Required(ErrorMessage = "Введите имя!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите стоимость!")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Выберите приоритет!")]
        public int Priority { get; set; }

        [Required(ErrorMessage = "Введите дату!")]
        [DataType(DataType.Date, ErrorMessage = "Введите дату!")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Period { get; set; }
        public virtual Pouch Pouch { get; set; }
        public virtual User User { get; set; }
    }

    [MetadataType(typeof(PurchaseValidation))]
    public partial class Purchase
    {
        
    }
}
