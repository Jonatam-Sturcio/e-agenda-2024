﻿using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCategoria;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloDespesa;
using eAgenda.WinApp.ModuloTarefa;

namespace eAgenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        RepositorioContato repositorioContato;
        RepositorioCompromisso repositorioCompromisso;
        RepositorioTarefa repositorioTarefa;
        RepositorioDespesa repositorioDespesa;
        RepositorioCategoria repositorioCategoria;

        public static TelaPrincipalForm Instancia { get; private set; }
        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;

            repositorioContato = new RepositorioContato();
            repositorioCompromisso = new RepositorioCompromisso();
            repositorioTarefa = new();
            repositorioDespesa = new();
            repositorioCategoria = new();

            Instancia = this;
        }
        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }
        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoria(repositorioCategoria);
            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }
        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (repositorioCategoria.ValidarPossuiRegistros())
            {
                AtualizarRodape("Não há nenhuma categoria cadastrada, por favor, cadastre uma categoria e tente novamente!");
                return;
            }

            controlador = new ControladorDespesa(repositorioDespesa, repositorioCategoria);
            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltro.ToolTipText = controladorFiltravel.ToolTipFiltrar;

            if (controladorSelecionado is IControladorSubItens controladorSubitens)
            {
                btnAdicionarItem.ToolTipText = controladorSubitens.ToolTipAdicionar;
                btnConcluirItem.ToolTipText = controladorSubitens.ToolTipConcluirItens;
            }

        }
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorFiltravel controladorFiltravel)
                controladorFiltravel.Filtrar();
        }
        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }
        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltro.Enabled = controladorSelecionado is IControladorFiltravel;
            btnAdicionarItem.Enabled = controladorSelecionado is IControladorSubItens;
            btnConcluirItem.Enabled = controladorSelecionado is IControladorSubItens;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorSubItens controladorSubItens)
                controladorSubItens.AdicionarItens();
        }

        private void btnConcluirItem_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorSubItens controladorSubItens)
                controladorSubItens.AtualizarItens();
        }
    }
}
