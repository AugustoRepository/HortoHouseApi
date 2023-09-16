using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortoHouse.Repository.Entites
{
    public class Comprador : Usuario
    {       
        public Comprador(int iD, string nome, string email, string senha, string endereço, string tipoUsuário, List<Pedidos>? pedidos, string preferênciasEntrega) : base(iD, nome, email, senha, endereço, tipoUsuário)
        {
            Pedidos = pedidos;
            PreferênciasEntrega = preferênciasEntrega;
        }

        public List<Pedidos> ?Pedidos { get; set; }
        public string PreferênciasEntrega { get; set; }
    }
}
