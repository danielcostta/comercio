using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSide.Models
{
    public class Cidade
    {
        [Key]
        public short IDCidade { get; set; }

        [Required]
        public string NomeCidade { get; set; }

        public byte IDEstado { get; set; }

        [ForeignKey("IDEstado")]
        public Estado Estado { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }
    }
}