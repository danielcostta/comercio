using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSide.Models
{
    public class WebSideContext : DbContext
    {
    
        public WebSideContext() : base("name=WebSideContext")
        {
            
        }

        public System.Data.Entity.DbSet<WebSide.Models.Cliente> Clientes { get; set; }
        public System.Data.Entity.DbSet<WebSide.Models.Estado> Estados { get; set; }
        public System.Data.Entity.DbSet<WebSide.Models.Cidade> Cidades { get; set; }
        public System.Data.Entity.DbSet<WebSide.Models.Endereco> Enderecos { get; set; }
    }
}
