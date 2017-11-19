using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSide.Models
{
    public class Endereco
    {
        [Key]
        public int IDEndereco { get; set; }

        [Required]
        [StringLength(100)]
        public string Logradouro { get; set; }

        public short Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Bairro { get; set; }

        public short IDCidade { get; set; }

        [ForeignKey("IDCidade")]
        public Cidade Cidade { get; set; }

        public int IDCliente { get; set; }

        [ForeignKey("IDCliente")]
        public Cliente Cliente { get; set; }
    }
}