using System.Collections.Generic;

namespace AwesomeGym.Core.Entidades
{
    public class Unidade
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string EnderecoCompleto { get; private set; }
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();
        public List<Equipamento> Equipamentos { get; private set; } = new List<Equipamento>();

        protected Unidade() { }
        public Unidade(string nome, string enderecoCompleto)
        {
            Nome = nome;
            EnderecoCompleto = enderecoCompleto;
        }
    }
}