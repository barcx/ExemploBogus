using Bogus;
using Bogus.DataSets;
using System;
using Bogus.Extensions.Brazil;

namespace ConsoleApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Define seed para gerar sempre os mesmos dados
            Randomizer.Seed = new Random(202101);

            var funcionario = new Faker<Funcionario>("pt_BR")
                .RuleFor(f => f.Guid, f => f.Random.Guid())
                .RuleFor(f => f.CPF, f => f.Person.Cpf())
                .RuleFor(f => f.Nome, f => f.Name.FullName(Name.Gender.Male))
                .RuleFor(f => f.Cargo, f => f.Name.JobTitle())
                .RuleFor(f => f.Salario, f => f.Random.Decimal(min: 0, max: 1000000))
                .Generate();

            Imprimir(funcionario);            

            Console.WriteLine("");
            Console.WriteLine("<<<<<   EXEMPLO LISTA   >>>>>");
            Console.WriteLine("");

            var funcionarios = new Faker<Funcionario>("pt_BR")
                .RuleFor(f => f.Guid, f => f.Random.Guid())
                .RuleFor(f => f.CPF, f => f.Person.Cpf())
                .RuleFor(f => f.Nome, f => f.Name.FullName(Name.Gender.Male))
                .RuleFor(f => f.Cargo, f => f.Name.JobTitle())
                .RuleFor(f => f.Salario, f => f.Random.Decimal(min: 0, max: 1000000))
                .Generate(5);

            foreach (var item in funcionarios)
            {
                Imprimir(item);
            }
        }
        
        private static void Imprimir(Funcionario funcionario)
        {
            Console.WriteLine(@"Dados do funcionario:");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"CPF: {funcionario.CPF}");
            Console.WriteLine($"Cargo: {funcionario.Cargo}");
            Console.WriteLine($"Guid: {funcionario.Guid}");
            Console.WriteLine("------------------");
        }
    }
}
