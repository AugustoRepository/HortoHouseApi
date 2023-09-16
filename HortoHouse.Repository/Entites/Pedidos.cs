using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortoHouse.Repository.Entites
{
    public  class Pedidos
    {
        public Pedidos(int iD, List<Produto> produtos, DateTime dataCriação, string statusEntrega, string endereçoEntrega)
        {
            ID = iD;
            Produtos = produtos;
            DataCriação = dataCriação;
            StatusEntrega = statusEntrega;
            EndereçoEntrega = endereçoEntrega;
        }

        public int ID { get; set; }
        public List<Produto> Produtos { get; set; }
        public DateTime DataCriação { get; set; }
        public string StatusEntrega { get; set; }
        public string EndereçoEntrega { get; set; }
    }
}
