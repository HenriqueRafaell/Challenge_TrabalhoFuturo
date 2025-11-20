using System.Windows;
using System.Windows.Controls;

namespace Challenge_TrabalhoFuturo
{
    public partial class TelaAvaliacao : UserControl
    {
        public TelaAvaliacao()
        {
            InitializeComponent();
        }

        private void AnalisarPosto_Click(object sender, RoutedEventArgs e)
        {
            // 1. Verifica se há um colaborador cadastrado
            Pessoa colaborador = TelaCadastro.ColaboradorAtual;

            if (colaborador == null)
            {
                txtResultado.Text = "ERRO: Por favor, cadastre um colaborador na 'Tela Cadastro de Perfil' primeiro.";
                return;
            }

            // 2. Instancia o Posto de Trabalho
            PostoDeTrabalho posto = new PostoDeTrabalho(
                nome: "Posto de Trabalho Atual",
                temRampa: chkRampa.IsChecked ?? false,
                temLeitor: chkLeitor.IsChecked ?? false,
                temMesa: chkMesa.IsChecked ?? false
            );

            // 3. Avalia acessibilidade
            string relatorio = posto.AvaliarAcessibilidade(colaborador);

            // 4. Mostra o resultado
            txtResultado.Text = relatorio;
        }
    }
}
