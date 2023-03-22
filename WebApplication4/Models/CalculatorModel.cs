using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "FirstNumber является обязательным.")]
        public sbyte FirstNumber { get; set; }
        public sbyte FirstNumber2 { get; set; }

        [Range(-128, 127, ErrorMessage = "Поле SecondNumber должно быть от -128 до 127.")]

        public sbyte SecondNumber { get; set; }
        public string Operation { get; set; }
        public decimal Result { get; set; }
    }

}

