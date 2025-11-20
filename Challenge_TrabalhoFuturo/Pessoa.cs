namespace Challenge_TrabalhoFuturo
{
    // Classe base: Define a estrutura fundamental e o método polimórfico
    public abstract class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int Idade { get; set; }

        // Construtor
        public Pessoa(string nome, string cargo, int idade)
        {
            Nome = nome;
            Cargo = cargo;
            Idade = idade;
        }

        // Método Polimórfico: Deve ser implementado pelas classes filhas
        // Retorna um relatório de necessidades específicas
        public abstract string GerarRelatorioNecessidades();
    }
}