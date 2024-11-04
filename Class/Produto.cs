using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Class
{
    public class Produto
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public int IdEstoque { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
