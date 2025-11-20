HENRIQUE RAFAEL GOMES DE SOUZA RM - 553945

Objetivo da Solução
O Agente de Adaptação simula um sistema capaz de realizar duas tarefas principais:

Cadastrar o Perfil de um colaborador (PCD), identificando sua deficiência.


Avaliar um Posto de Trabalho e gerar um relatório que indica o quão bem o posto atende às necessidades específicas daquele colaborador.

O projeto atende aos requisitos do Challenge, aplicando Programação Orientada a Objetos (POO), herança, polimorfismo e uma interface gráfica funcional (WPF).

Requisitos Técnicos e Implementação:

Recurso,Descrição da Implementação,Requisito Atendido
Interface Gráfica,Aplicação desenvolvida com WPF (Windows Presentation Foundation). Possui 2 telas (UserControls) principais para navegação: TelaCadastro e TelaAvaliacao.,✅ Mín. 2 Telas WPF
Herança (POO),"A classe PessoaComDeficiencia herda de Pessoa, compartilhando atributos básicos (Nome, Cargo, Idade) e adicionando atributos específicos (TipoDeficiencia).",✅ Classes com Herança
Polimorfismo (POO),"A classe PostoDeTrabalho possui o método AvaliarAcessibilidade(Pessoa colaborador). Este método se comporta de forma diferente dependendo se o objeto colaborador é uma Pessoa ou uma PessoaComDeficiencia, usando lógica específica para calcular a pontuação de acessibilidade.",✅ Classes com Polimorfismo
Lógica de Negócio,"O método AvaliarAcessibilidade realiza um cálculo/simulação que pontua a adequação do posto de trabalho (Rampa, Leitor de Tela, Mesa Ajustável) em relação ao tipo de deficiência cadastrada.",✅ Lógica/Simulação

Estrutura do Código
Classes (Lógica de Negócio)
Pessoa.cs: Classe base para qualquer colaborador.

PessoaComDeficiencia.cs: Herda de Pessoa. Contém a lógica de verificação de necessidade (VerificaNecessidade(...)) para determinar o que o colaborador precisa para trabalhar.

PostoDeTrabalho.cs: Contém a lógica da simulação. O método AvaliarAcessibilidade recebe o colaborador e retorna um relatório textual e a pontuação de acessibilidade (Polimorfismo).

Interfaces Gráficas (WPF)
MainWindow.xaml / MainWindow.xaml.cs: Janela principal que gerencia a navegação entre as telas usando um ContentControl (x:Name="MainContent").

TelaCadastro.xaml / TelaCadastro.xaml.cs:

Interface para inserir dados do colaborador e sua deficiência.

Guarda o objeto PessoaComDeficiencia criado em uma variável estática (ColaboradorAtual) para que a TelaAvaliacao possa acessá-lo.

TelaAvaliacao.xaml / TelaAvaliacao.xaml.cs:

Interface para selecionar as características do posto de trabalho (Checkboxes).

Ao clicar em "Analisar Posto", ele resgata o colaborador cadastrado e chama o método de simulação (posto.AvaliarAcessibilidade(...)).

Como Usar (Passo a Passo)
Iniciar a Aplicação (Pressione F5 no Visual Studio).

Tela Cadastro de Perfil (Passo 1):

Preencha o Nome, Cargo e Idade.

Selecione o Tipo de Deficiência na lista.

Clique em "Salvar Colaborador".

Tela Avaliação do Posto (Passo 2):

Clique no botão "2. Avaliação do Posto" na parte superior.

Marque ou desmarque as opções de Acessibilidade do posto (Rampa, Leitor de Tela, Mesa).

Clique em "Iniciar Análise do Posto".

Visualizar Resultado: O relatório final será exibido na parte inferior da tela, mostrando a pontuação do posto em relação ao perfil do colaborador cadastrado.
