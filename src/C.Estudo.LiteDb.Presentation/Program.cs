using C.Estudo.LiteDb.Infra.Data.Repositories;
using System;
using System.Linq;

namespace C.Estudo.LiteDb.Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _clienteRepository = new ClienteRepository();
            //AdicionarCliente(_clienteRepository);
            ListarClientes(_clienteRepository);
            //AtualizarCliente(_clienteRepository);

            //Console.ReadKey();
        }

        private static void ListarClientes(ClienteRepository clienteRepository)
        {
            clienteRepository.Listar().ToList().ForEach(cliente => Console.WriteLine($"Id: {cliente.Id} / Nome: {cliente.Name} / Idade: {cliente.Age}"));
            Console.ReadKey();
        }

        private static void AtualizarCliente(ClienteRepository clienteRepository)
        {
            var adam = clienteRepository.Listar().ToList().FirstOrDefault(cliente => cliente.Name.Contains("Adam"));
            adam.Age = 27;
            adam.IsActive = true;
            clienteRepository.Atualizar(adam);
        }

        private static void AdicionarCliente(ClienteRepository clienteRepository)
        {
            clienteRepository.Inserir(new Domain.Entitites.Cliente { Name = "Brad", Age = 50, IsActive = true });
            clienteRepository.Inserir(new Domain.Entitites.Cliente { Name = "Leonardo", Age = 49, IsActive = true });
            clienteRepository.Inserir(new Domain.Entitites.Cliente { Name = "Tom", Age = 52, IsActive = true });
        }
    }
}
