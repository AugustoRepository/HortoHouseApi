using HortoHouse.Repository.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortoHouse.Repository.Contracts
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {        
        Usuario GetByEmailAndSenha(string email, string senha);
        Usuario GetbyEmail(string email);
    }
}
