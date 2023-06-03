namespace E_agenda1._0
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            tarefasMenuItem = new ToolStripMenuItem();
            despesasMenuItem = new ToolStripMenuItem();
            despesasMenuItem1 = new ToolStripMenuItem();
            categoriasMenuItem = new ToolStripMenuItem();
            relatóriosMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnAdicionarTarefa = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnFinalizarEtapas = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripOrganizarTarefas = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButtonDespesasCategorias = new ToolStripButton();
            labelTipoCadastro = new ToolStripLabel();
            painelRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem, relatóriosMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7);
            menuStrip1.Size = new Size(984, 53);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.BackColor = SystemColors.MenuHighlight;
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasMenuItem, despesasMenuItem });
            cadastrosMenuItem.ForeColor = Color.White;
            cadastrosMenuItem.Image = Properties.Resources.folder;
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(129, 39);
            cadastrosMenuItem.Text = "Cadastros";
            cadastrosMenuItem.Click += cadastrosMenuItem_Click;
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.BackColor = SystemColors.MenuHighlight;
            contatosMenuItem.ForeColor = Color.White;
            contatosMenuItem.Image = Properties.Resources.boy;
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Padding = new Padding(0);
            contatosMenuItem.Size = new Size(212, 38);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.BackColor = SystemColors.MenuHighlight;
            compromissosMenuItem.ForeColor = Color.White;
            compromissosMenuItem.Image = Properties.Resources.calendar_1_;
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(212, 40);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += compromissosMenuItem_Click;
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.BackColor = SystemColors.MenuHighlight;
            tarefasMenuItem.ForeColor = Color.White;
            tarefasMenuItem.Image = Properties.Resources.to_do_list1;
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(212, 40);
            tarefasMenuItem.Text = "Tarefas";
            tarefasMenuItem.Click += tarefasMenuItem_Click;
            // 
            // despesasMenuItem
            // 
            despesasMenuItem.BackColor = SystemColors.MenuHighlight;
            despesasMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasMenuItem1, categoriasMenuItem });
            despesasMenuItem.ForeColor = Color.White;
            despesasMenuItem.Image = Properties.Resources.dollars;
            despesasMenuItem.Name = "despesasMenuItem";
            despesasMenuItem.Size = new Size(212, 40);
            despesasMenuItem.Text = "Despesas";
            // 
            // despesasMenuItem1
            // 
            despesasMenuItem1.BackColor = SystemColors.MenuHighlight;
            despesasMenuItem1.ForeColor = Color.White;
            despesasMenuItem1.Image = Properties.Resources.decrease1;
            despesasMenuItem1.Name = "despesasMenuItem1";
            despesasMenuItem1.Size = new Size(183, 40);
            despesasMenuItem1.Text = "Despesas";
            despesasMenuItem1.Click += despesasMenuItem1_Click;
            // 
            // categoriasMenuItem
            // 
            categoriasMenuItem.BackColor = SystemColors.MenuHighlight;
            categoriasMenuItem.ForeColor = Color.White;
            categoriasMenuItem.Image = Properties.Resources.camada;
            categoriasMenuItem.Name = "categoriasMenuItem";
            categoriasMenuItem.Size = new Size(183, 40);
            categoriasMenuItem.Text = "Categorias";
            categoriasMenuItem.Click += categoriasMenuItem_Click;
            // 
            // relatóriosMenuItem
            // 
            relatóriosMenuItem.ForeColor = Color.White;
            relatóriosMenuItem.Image = Properties.Resources.caderno;
            relatóriosMenuItem.Name = "relatóriosMenuItem";
            relatóriosMenuItem.Size = new Size(129, 39);
            relatóriosMenuItem.Text = "Relatórios";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.MenuHighlight;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblStatus });
            statusStrip1.Location = new Point(0, 557);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.ForeColor = SystemColors.ActiveCaptionText;
            lblStatus.Image = Properties.Resources.priority;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(44, 17);
            lblStatus.Text = "Olá!";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.HotTrack;
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator3, btnAdicionarTarefa, toolStripSeparator2, btnFinalizarEtapas, toolStripSeparator5, toolStripOrganizarTarefas, toolStripSeparator4, toolStripButtonDespesasCategorias, labelTipoCadastro });
            toolStrip1.Location = new Point(0, 53);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(984, 51);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.adicionar_amigo;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(48, 48);
            btnInserir.Text = "Inserir";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.lapis1;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(48, 48);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.lixeira;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(48, 48);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 51);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = Properties.Resources.lupa;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(7);
            btnFiltrar.Size = new Size(48, 48);
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 51);
            // 
            // btnAdicionarTarefa
            // 
            btnAdicionarTarefa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarTarefa.Image = Properties.Resources.checklist;
            btnAdicionarTarefa.ImageTransparentColor = Color.Magenta;
            btnAdicionarTarefa.Name = "btnAdicionarTarefa";
            btnAdicionarTarefa.Padding = new Padding(7);
            btnAdicionarTarefa.Size = new Size(48, 48);
            btnAdicionarTarefa.Text = "Adicionar Tarefa";
            btnAdicionarTarefa.Click += btnAdicionarTarefa_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 51);
            // 
            // btnFinalizarEtapas
            // 
            btnFinalizarEtapas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFinalizarEtapas.Image = Properties.Resources.checkbox1;
            btnFinalizarEtapas.ImageTransparentColor = Color.Magenta;
            btnFinalizarEtapas.Name = "btnFinalizarEtapas";
            btnFinalizarEtapas.Padding = new Padding(7);
            btnFinalizarEtapas.Size = new Size(48, 48);
            btnFinalizarEtapas.Text = "Finalizar Etapas";
            btnFinalizarEtapas.ToolTipText = "Finalizar Etapas";
            btnFinalizarEtapas.Click += btnFinalizarEtapas_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 51);
            // 
            // toolStripOrganizarTarefas
            // 
            toolStripOrganizarTarefas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripOrganizarTarefas.Image = Properties.Resources.prioritize;
            toolStripOrganizarTarefas.ImageTransparentColor = Color.Magenta;
            toolStripOrganizarTarefas.Name = "toolStripOrganizarTarefas";
            toolStripOrganizarTarefas.Padding = new Padding(7);
            toolStripOrganizarTarefas.Size = new Size(48, 48);
            toolStripOrganizarTarefas.Text = "Organizar Tarefas";
            toolStripOrganizarTarefas.ToolTipText = "Finalizar Etapas";
            toolStripOrganizarTarefas.Click += toolStripOrganizarTarefas_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 51);
            // 
            // toolStripButtonDespesasCategorias
            // 
            toolStripButtonDespesasCategorias.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDespesasCategorias.Image = Properties.Resources.pesquisa_paga;
            toolStripButtonDespesasCategorias.ImageTransparentColor = Color.Magenta;
            toolStripButtonDespesasCategorias.Name = "toolStripButtonDespesasCategorias";
            toolStripButtonDespesasCategorias.Padding = new Padding(7);
            toolStripButtonDespesasCategorias.Size = new Size(48, 48);
            toolStripButtonDespesasCategorias.Text = "Visualizar Despesas da Categoria";
            toolStripButtonDespesasCategorias.ToolTipText = "Finalizar Etapas";
            toolStripButtonDespesasCategorias.Click += toolStripButtonDespesasCategorias_Click;
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipoCadastro.ForeColor = Color.White;
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(77, 48);
            labelTipoCadastro.Text = "E-Agenda";
            // 
            // painelRegistros
            // 
            painelRegistros.BackColor = SystemColors.Control;
            painelRegistros.BorderStyle = BorderStyle.FixedSingle;
            painelRegistros.Dock = DockStyle.Fill;
            painelRegistros.Location = new Point(0, 104);
            painelRegistros.Margin = new Padding(4, 6, 4, 6);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(984, 453);
            painelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(984, 579);
            Controls.Add(painelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 6, 4, 6);
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Agenda 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem despesasMenuItem;
        private ToolStripMenuItem despesasMenuItem1;
        private ToolStripMenuItem categoriasMenuItem;
        private ToolStripMenuItem relatóriosMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel painelRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripStatusLabel lblStatus;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAdicionarTarefa;
        private ToolStripButton btnFinalizarEtapas;
        private ToolStripSeparator toolStripSeparator4;
        internal protected ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripOrganizarTarefas;
        private ToolStripButton toolStripButtonDespesasCategorias;
    }
}