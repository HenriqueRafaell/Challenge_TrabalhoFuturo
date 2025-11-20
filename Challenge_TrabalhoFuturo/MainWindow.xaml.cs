using System.Windows;
using System.Windows.Controls;

namespace Challenge_TrabalhoFuturo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // CHAMA O MÉTODO SEGURO: Exibe a Tela de Cadastro por padrão ao iniciar
            ExibirTelaCadastro();
        }

        // Método interno seguro para exibir a Tela de Cadastro
        private void ExibirTelaCadastro()
        {
            MainContent.Content = new TelaCadastro();
        }

        // Método interno seguro para exibir a Tela de Avaliação
        private void ExibirTelaAvaliacao()
        {
            MainContent.Content = new TelaAvaliacao();
        }

        // EVENTO DO BOTÃO (Chamado pelo Click="AbrirTelaCadastro_Click" no XAML)
        private void AbrirTelaCadastro_Click(object sender, RoutedEventArgs e)
        {
            ExibirTelaCadastro();
        }

        // ESTE MÉTODO ESTAVA FALTANDO OU INCOMPLETO
        // EVENTO DO BOTÃO (Chamado pelo Click="AbrirTelaAvaliacao_Click" no XAML)
        private void AbrirTelaAvaliacao_Click(object sender, RoutedEventArgs e)
        {
            ExibirTelaAvaliacao();
        }
    }
}