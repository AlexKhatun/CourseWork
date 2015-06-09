using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class UserValidation
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Введите Email!")]
        [EmailAddress(ErrorMessage = "Некорректный Email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите пароль!")]
        public string Password { get; set; }
        public System.DateTime Date { get; set; }
    }

    [MetadataType(typeof(UserValidation))]
    public partial class User
    {

    }
}
