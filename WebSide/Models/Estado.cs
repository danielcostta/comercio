using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSide.Models
{
    public class Estado
    {
        [Key]
        public byte IDEstado { get; set; }

        [Required(ErrorMessage = "Nome do Estado é obrigatório")]
        [StringLength(2, ErrorMessage = "Tamanho máximo: 2 caracteres")]
        public string NomeEstado { get; set; }

        public ICollection<Cidade> Cidade { get; set; }
    }
}