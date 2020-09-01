using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFoodIdentity.Models
{
    public class ProdutoCategoria
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
