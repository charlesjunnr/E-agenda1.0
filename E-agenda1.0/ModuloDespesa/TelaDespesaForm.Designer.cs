﻿namespace E_agenda1._0.ModuloDespesa
{
    partial class TelaDespesaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDespesaForm));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            dtpData = new DateTimePicker();
            cbxPagamento = new ComboBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            clbCategorias = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(123, 23);
            label2.Name = "label2";
            label2.Size = new Size(33, 28);
            label2.TabIndex = 34;
            label2.Text = "Id:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.etiqueta_de_preco;
            pictureBox1.Location = new Point(20, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 69);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 35;
            label1.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(97, 115);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 36;
            label3.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(100, 160);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 37;
            label4.Text = "Data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 202);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 38;
            label5.Text = "Forma de Pgto:";
            // 
            // txtId
            // 
            txtId.Location = new Point(162, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(40, 23);
            txtId.TabIndex = 39;
            txtId.Text = "0";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(162, 74);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(255, 23);
            txtDescricao.TabIndex = 40;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(162, 120);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(126, 23);
            txtValor.TabIndex = 41;
            // 
            // dtpData
            // 
            dtpData.CustomFormat = "dd/MM/yyyy";
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.Location = new Point(162, 165);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(126, 23);
            dtpData.TabIndex = 42;
            // 
            // cbxPagamento
            // 
            cbxPagamento.FormattingEnabled = true;
            cbxPagamento.Items.AddRange(new object[] { "Dinheiro", "Crédito", "Débito" });
            cbxPagamento.Location = new Point(162, 202);
            cbxPagamento.Name = "cbxPagamento";
            cbxPagamento.Size = new Size(126, 23);
            cbxPagamento.TabIndex = 43;
            cbxPagamento.SelectedIndexChanged += cbxPagamento_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.marcacao;
            pictureBox2.Location = new Point(75, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dollars1;
            pictureBox3.Location = new Point(49, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.despertador;
            pictureBox4.Location = new Point(294, 152);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.cartao_de_credito;
            pictureBox5.Location = new Point(294, 194);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 242);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 48;
            label6.Text = "Categorias";
            // 
            // clbCategorias
            // 
            clbCategorias.FormattingEnabled = true;
            clbCategorias.Location = new Point(20, 273);
            clbCategorias.Name = "clbCategorias";
            clbCategorias.Size = new Size(397, 220);
            clbCategorias.TabIndex = 49;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(227, 521);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(92, 51);
            btnGravar.TabIndex = 50;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(325, 521);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 51);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(440, 589);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(clbCategorias);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(cbxPagamento);
            Controls.Add(dtpData);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaDespesaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Despesas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private DateTimePicker dtpData;
        private ComboBox cbxPagamento;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label6;
        private CheckedListBox clbCategorias;
        private Button btnGravar;
        private Button btnCancelar;
    }
}