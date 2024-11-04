using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneGroup.Class
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Localizacao { get; set; }
        public int Saida { get; set; }
        public int Entrada { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string MotivoEntrada { get; set; }
        public string MotivoSaida { get; set; }
        public int QuantidadeDisponivel { get; set; }
    }
}
