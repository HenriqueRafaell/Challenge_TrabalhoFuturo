using System;
using System.Text;

namespace Challenge_TrabalhoFuturo
{
    public class PostoDeTrabalho
    {
        public string Nome { get; set; }
        public bool TemAcessoRampa { get; set; }
        public bool TemSoftwareLeitor { get; set; }
        public bool TemMesaAjustavel { get; set; }

        public PostoDeTrabalho(string nome, bool temRampa, bool temLeitor, bool temMesa)
        {
            Nome = nome;
            TemAcessoRampa = temRampa;
            TemSoftwareLeitor = temLeitor;
            TemMesaAjustavel = temMesa;
        }

        // Lógica de Negócio: Calcula a pontuação de acessibilidade e gera um relatório
        public string AvaliarAcessibilidade(Pessoa pessoa)
        {
            int pontuacaoAcessibilidade = 0;
            StringBuilder relatorio = new StringBuilder();

            relatorio.AppendLine($"**Análise de Posto de Trabalho para {pessoa.Nome} ({pessoa.Cargo}):**");
            relatorio.AppendLine("---");

            // 1. Usa o Polimorfismo para obter as necessidades da pessoa
            string necessidades = pessoa.GerarRelatorioNecessidades();
            relatorio.AppendLine(necessidades);

            // 2. Simulação de Cálculo de Pontuação (Lógica de Negócio)

            // Requisito Motora (Rampa/Mesa)
            if (pessoa is PessoaComDeficiencia pcd && pcd.Deficiencia == PessoaComDeficiencia.TipoDeficiencia.Motora)
            {
                if (TemAcessoRampa) pontuacaoAcessibilidade += 20;
                else relatorio.AppendLine("- **FALHA:** Não possui rampa/acesso facilitado (Necessário para Deficiência Motora).");

                if (TemMesaAjustavel) pontuacaoAcessibilidade += 20;
                else relatorio.AppendLine("- **FALHA:** Não possui mesa ajustável (Necessário para Deficiência Motora).");
            }
            // Requisito Visual (Software Leitor)
            else if (pessoa is PessoaComDeficiencia pcdVisual && pcdVisual.Deficiencia == PessoaComDeficiencia.TipoDeficiencia.Visual)
            {
                if (TemSoftwareLeitor) pontuacaoAcessibilidade += 40;
                else relatorio.AppendLine("- **FALHA:** Não possui software leitor de tela (Necessário para Deficiência Visual).");
            }

            // 3. Resultado
            if (pessoa is PessoaComDeficiencia)
            {
                relatorio.AppendLine($"\n**Pontuação de Acessibilidade do Posto:** {pontuacaoAcessibilidade} / 40");
                relatorio.AppendLine(pontuacaoAcessibilidade >= 30 ? "**Status:** Posto Adequado ou de Fácil Adaptação." : "**Status:** Adaptação Prioritária Necessária.");
            }
            else
            {
                // Para Pessoas sem deficiência, a avaliação é de 100% (40/40) por padrão
                relatorio.AppendLine("\n**Pontuação de Acessibilidade do Posto:** 40 / 40");
                relatorio.AppendLine("**Status:** Posto Adequado.");
            }

            return relatorio.ToString();
        }
    }
}