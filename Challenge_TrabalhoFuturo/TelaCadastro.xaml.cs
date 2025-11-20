using System.Windows;
using System.Windows.Controls;
using System;

namespace Challenge_TrabalhoFuturo
{
    public partial class TelaCadastro : UserControl
    {
        // Variável estática para armazenar a pessoa cadastrada (disponível para outras telas)
        public static Pessoa ColaboradorAtual { get; private set; }

        public TelaCadastro()
        {
            InitializeComponent();
            // Popula o ComboBox com os tipos de deficiência (Enum)
            cmbDeficiencia.ItemsSource = Enum.GetValues(typeof(PessoaComDeficiencia.TipoDeficiencia));
            cmbDeficiencia.SelectedItem = PessoaComDeficiencia.TipoDeficiencia.Motora; // Sugere um valor inicial
        }

        private void SalvarColaborador_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string cargo = txtCargo.Text;
                int idade = int.Parse(txtIdade.Text);
                PessoaComDeficiencia.TipoDeficiencia deficiencia = (PessoaComDeficiencia.TipoDeficiencia)cmbDeficiencia.SelectedItem;

                // Instanciação da classe filha (Herança em ação)
                ColaboradorAtual = new PessoaComDeficiencia(nome, cargo, idade, deficiencia);

                txtFeedback.Text = $"Colaborador '{nome}' (Deficiência: {deficiencia}) cadastrado com sucesso! ";
            }
            catch (FormatException)
            {
                txtFeedback.Text = "ERRO: Verifique se a Idade foi digitada corretamente (apenas números).";
                txtFeedback.Foreground = System.Windows.Media.Brushes.Red;
            }
            catch (Exception ex)
            {
                txtFeedback.Text = $"ERRO: {ex.Message}";
                txtFeedback.Foreground = System.Windows.Media.Brushes.Red;
            }
        }
    }
}