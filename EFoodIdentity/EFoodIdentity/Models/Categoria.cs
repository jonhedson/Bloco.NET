using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFoodIdentity.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<ProdutoCategoria> ProdutoCategorias { get; set; }
    }
}
