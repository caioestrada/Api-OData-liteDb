using C.Estudo.LiteDb.Domain.Entitites;
using LiteDB;
using System.Collections.Generic;

namespace C.Estudo.LiteDb.Infra.Data.Repositories
{
    public class ClienteRepository
    {
        private readonly LiteCollection<Cliente> _liteCollection;

        public ClienteRepository()
        {
            using (var db = new LiteDatabase(@"C:\Users\Caio\Source\Repos\C.Estudo.LiteDb\database\Clientes.db"))
            {
                _liteCollection = db.GetCollection<Cliente>("clientes");
            }
        }

        public void Inserir(Cliente cliente)
        {
            _liteCollection.Insert(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _liteCollection.Update(cliente);
        }

        public IEnumerable<Cliente> Listar()
        {
            return _liteCollection.Find(cliente => cliente.IsActive);
        }
    }
}
