using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortoHouse.Repository.Entites
{
    public  class Produto
    {
        public Produto(int iD, string nome, string descrição, decimal preço, string imagem, string informaçõesNutricionais)
        {
            ID = iD;
            Nome = nome;
            Descrição = descrição;
            Preço = preço;
            Imagem = imagem;
            InformaçõesNutricionais = informaçõesNutricionais;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public decimal Preço { get; set; }
        public string Imagem { get; set; }
        public string InformaçõesNutricionais { get; set; }
    }
}
