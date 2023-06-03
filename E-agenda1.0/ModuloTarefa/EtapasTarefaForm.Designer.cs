namespace E_agenda1._0.ModuloTarefa
{
    partial class EtapasTarefaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtapasTarefaForm));
            btnAdicionar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtEtapa = new TextBox();
            clbEtapas = new CheckedListBox();
            lblTarefa = new Label();
            txtTarefa = new TextBox();
            bntInserir = new Button();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.DialogResult = DialogResult.Yes;
            btnAdicionar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(100, 378);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(104, 49);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(210, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 2;
            label1.Text = "Etapa:";
            // 
            // txtEtapa
            // 
            txtEtapa.BackColor = SystemColors.InactiveBorder;
            txtEtapa.Location = new Point(127, 52);
            txtEtapa.Name = "txtEtapa";
            txtEtapa.Size = new Size(104, 23);
            txtEtapa.TabIndex = 3;
            // 
            // clbEtapas
            // 
            clbEtapas.BackColor = SystemColors.InactiveBorder;
            clbEtapas.Enabled = false;
            clbEtapas.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clbEtapas.FormattingEnabled = true;
            clbEtapas.Location = new Point(15, 105);
            clbEtapas.Name = "clbEtapas";
            clbEtapas.Size = new Size(291, 252);
            clbEtapas.TabIndex = 6;
            // 
            // lblTarefa
            // 
            lblTarefa.AutoSize = true;
            lblTarefa.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTarefa.Location = new Point(57, 8);
            lblTarefa.Name = "lblTarefa";
            lblTarefa.Size = new Size(68, 28);
            lblTarefa.TabIndex = 9;
            lblTarefa.Text = "Tarefa:";
            // 
            // txtTarefa
            // 
            txtTarefa.BackColor = SystemColors.InactiveBorder;
            txtTarefa.Location = new Point(126, 14);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(180, 23);
            txtTarefa.TabIndex = 10;
            // 
            // bntInserir
            // 
            bntInserir.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bntInserir.Location = new Point(237, 52);
            bntInserir.Name = "bntInserir";
            bntInserir.Size = new Size(70, 47);
            bntInserir.TabIndex = 11;
            bntInserir.Text = "Inserir";
            bntInserir.UseVisualStyleBackColor = true;
            bntInserir.Click += bntInserir_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.livro;
            pictureBox5.Location = new Point(15, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.camada;
            pictureBox1.Location = new Point(16, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // EtapasTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(332, 434);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(bntInserir);
            Controls.Add(txtTarefa);
            Controls.Add(clbEtapas);
            Controls.Add(txtEtapa);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(lblTarefa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EtapasTarefaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Etapas da Tarefa";
            Load += EtapasTarefaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtEtapa;
        private CheckedListBox clbEtapas;
        private Label lblTarefa;
        private TextBox txtTarefa;
        private Button bntInserir;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
    }
}