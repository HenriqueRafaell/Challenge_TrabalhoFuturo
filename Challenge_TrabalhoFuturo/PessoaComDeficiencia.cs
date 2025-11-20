namespace Challenge_TrabalhoFuturo
{
    // Classe filha: Implementa as necessidades de adaptação específicas (Herança)
    public class PessoaComDeficiencia : Pessoa
    {
        // Enum para representar o Tipo de Deficiência
        public enum TipoDeficiencia
        {
            Visual,
            Motora,
            Auditiva,
            Outra
        }

        // Atributo específico
        public TipoDeficiencia Deficiencia { get; set; }

        // Construtor que chama o construtor da classe base (base)
        public PessoaComDeficiencia(string nome, string cargo, int idade, TipoDeficiencia deficiencia)
            : base(nome, cargo, idade)
        {
            Deficiencia = deficiencia;
        }

        // Implementação Polimórfica: Gera o relatório de acordo com a deficiência
        public override string GerarRelatorioNecessidades()
        {
            string necessidades = $"**Necessidades de Adaptação para Deficiência {Deficiencia}:**\n";

            switch (Deficiencia)
            {
                case TipoDeficiencia.Visual:
                    necessidades += "- Software leitor de tela (Ex: NVDA).\n";
                    necessidades += "- Documentos digitais em formato acessível.\n";
                    break;
                case TipoDeficiencia.Motora:
                    necessidades += "- Cadeira ergonômica e ajustável.\n";
                    necessidades += "- Mesa com altura ajustável eletricamente.\n";
                    necessidades += "- Acesso facilitado ao prédio e ao posto de trabalho.\n";
                    break;
                case TipoDeficiencia.Auditiva:
                    necessidades += "- Sinalização visual de emergência.\n";
                    necessidades += "- Transcrição em tempo real (closed caption) em reuniões virtuais.\n";
                    break;
                default:
                    necessidades += "- Necessário avaliação individualizada.\n";
                    break;
            }

            return necessidades;
        }
    }
}