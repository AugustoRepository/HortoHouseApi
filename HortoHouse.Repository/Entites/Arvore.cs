using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortoHouse.Repository.Entites
{
    public   class Arvore
    {
        public Arvore(int iD, string tipoFruta, int quantidadeEstimada, bool statusDisponibilidade)
        {
            ID = iD;
            TipoFruta = tipoFruta;
            QuantidadeEstimada = quantidadeEstimada;
            StatusDisponibilidade = statusDisponibilidade;
        }

        public int ID { get; set; }
        public string TipoFruta { get; set; }
        public int QuantidadeEstimada { get; set; }
        public bool StatusDisponibilidade { get; set; }
    }
}
