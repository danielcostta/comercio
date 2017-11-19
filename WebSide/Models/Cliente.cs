using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSide.Models
{
    public class Cliente
    {
        [Key]
        public int IDCliente { get; set; }

        [Required]
        public string NomeCliente { get; set; }

        [Required]
        public long CPF { get; set; }
    }
}