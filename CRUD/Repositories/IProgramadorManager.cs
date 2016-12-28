using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Repositories
{
    public interface IProgramadorManager: IDisposable
    {
        Task Create(Programador input);
        Task Update(Programador input);
        Task Delete(int id);
        Task<List<Programador>> GetAll();
        Task<Programador> Get(int id);
    }
}
