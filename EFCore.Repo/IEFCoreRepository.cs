using EFCore.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repo
{
    public interface IEFCoreRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangeAsync();
        Task<IEnumerable<Heroi>> GetAllHerois(bool incluirHeroi = false);
        Task<Heroi> GetHeroiById(int id, bool incluirHeroi = false);
        Task<Heroi[]> GetHeroisByNome(string nome, bool incluirHeroi = false);

        Task<IEnumerable<Batalha>> GetAllBatalhas(bool incluirBatalha = false);
        Task<Batalha> GetBatalhaById(int id, bool incluirBatalha = false);
    }
}
