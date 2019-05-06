using C.Estudo.LiteDb.Infra.Data.Repositories;
using System;
using System.Linq;

namespace C.Estudo.LiteDb.Presentation
{
    public class Program
    {
        public static ClienteRepository _clienteRepository;

        static void Main(string[] args)
        {
            _clienteRepository = new ClienteRepository();

            //Adicionar
            //_clienteRepository.Inserir(new Domain.Entitites.Cliente { Name = "Adam", Age = 40, IsActive = true });

            //Listar
            _clienteRepository.Listar().ToList().ForEach(cliente => Console.WriteLine($"Id: {cliente.Id} / Nome: {cliente.Name} / Idade: {cliente.Age}"));
            Console.ReadKey();

            //Atualizar
            //var travis = _clienteRepository.Listar().ToList().FirstOrDefault(cliente => cliente.Name.Contains("Adam"));
            //travis.Age = 27;
            //travis.IsActive = true;
            //_clienteRepository.Atualizar(travis);

            //Console.ReadKey();
        }
    }
}
