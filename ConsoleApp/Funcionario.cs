using System;

namespace ConsoleApp
{
    public class Funcionario
    {
        public Guid Guid { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }

        public string Cargo { get; set; }

        public decimal Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, string cargo, decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public string Apresentar() => $"Oi! Meu nome é {Nome} e o meu cargo é {Cargo}.";

        public void ConcederAumentoSalarial(decimal percentual)
        {
            if (percentual < 0)
            {
                return;
            }
            Salario += Salario * (percentual / 100);
        }
    }
}
