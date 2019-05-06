using C.Estudo.LiteDb.Domain.Entitites;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;

namespace C.Estudo.LiteDb.Infra.Data.Repositories
{
    public class ClienteRepository
    {
        private readonly LiteCollection<Cliente> _liteCollection;

        public ClienteRepository()
        {
            string pastaDb = ObterCaminhoDoBanco();
            using (var db = new LiteDatabase(pastaDb))
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

        private static string ObterCaminhoDoBanco()
        {
            string pastaDaSolucao = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\..\\"));
            return $@"{pastaDaSolucao}database\Clientes.db";
        }
    }
}
