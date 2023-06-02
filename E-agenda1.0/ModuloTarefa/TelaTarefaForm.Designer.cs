namespace E_agenda1._0.ModuloTarefa
{
    partial class TelaTarefaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTarefaForm));
            lblId = new Label();
            lblTitulo = new Label();
            lblDataInicio = new Label();
            lblDataTermino = new Label();
            lblPrioridade = new Label();
            txtId = new TextBox();
            txtTitulo = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            rdbPrioridadeBaixa = new RadioButton();
            rdbPrioridadeNormal = new RadioButton();
            rdbPrioridadeAlta = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(69, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 28);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(47, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(64, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Título:";
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataInicio.Location = new Point(52, 99);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(110, 28);
            lblDataInicio.TabIndex = 2;
            lblDataInicio.Text = "Data Inicial:";
            // 
            // lblDataTermino
            // 
            lblDataTermino.AutoSize = true;
            lblDataTermino.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataTermino.Location = new Point(53, 128);
            lblDataTermino.Name = "lblDataTermino";
            lblDataTermino.Size = new Size(101, 28);
            lblDataTermino.TabIndex = 3;
            lblDataTermino.Text = "Data Final:";
            lblDataTermino.Click += lblDataTermino_Click;
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrioridade.Location = new Point(52, 157);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(102, 28);
            lblPrioridade.TabIndex = 4;
            lblPrioridade.Text = "Prioridade:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveBorder;
            txtId.Enabled = false;
            txtId.Location = new Point(118, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(30, 23);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.InactiveBorder;
            txtTitulo.Location = new Point(118, 56);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(149, 23);
            txtTitulo.TabIndex = 6;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(61, 268);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 42);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(147, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 42);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.CustomFormat = "dd/MM/yyyy";
            dtpDataFinal.Format = DateTimePickerFormat.Custom;
            dtpDataFinal.Location = new Point(168, 130);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(99, 23);
            dtpDataFinal.TabIndex = 10;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.CustomFormat = "dd/MM/yyyy";
            dtpDataInicial.Format = DateTimePickerFormat.Custom;
            dtpDataInicial.Location = new Point(168, 101);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(99, 23);
            dtpDataInicial.TabIndex = 9;
            // 
            // rdbPrioridadeBaixa
            // 
            rdbPrioridadeBaixa.AutoSize = true;
            rdbPrioridadeBaixa.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPrioridadeBaixa.Location = new Point(61, 234);
            rdbPrioridadeBaixa.Name = "rdbPrioridadeBaixa";
            rdbPrioridadeBaixa.Size = new Size(66, 28);
            rdbPrioridadeBaixa.TabIndex = 11;
            rdbPrioridadeBaixa.TabStop = true;
            rdbPrioridadeBaixa.Text = "Baixa";
            rdbPrioridadeBaixa.UseVisualStyleBackColor = true;
            // 
            // rdbPrioridadeNormal
            // 
            rdbPrioridadeNormal.AutoSize = true;
            rdbPrioridadeNormal.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPrioridadeNormal.Location = new Point(61, 209);
            rdbPrioridadeNormal.Name = "rdbPrioridadeNormal";
            rdbPrioridadeNormal.Size = new Size(80, 28);
            rdbPrioridadeNormal.TabIndex = 12;
            rdbPrioridadeNormal.TabStop = true;
            rdbPrioridadeNormal.Text = "Normal";
            rdbPrioridadeNormal.UseVisualStyleBackColor = true;
            // 
            // rdbPrioridadeAlta
            // 
            rdbPrioridadeAlta.AutoSize = true;
            rdbPrioridadeAlta.Font = new Font("Segoe Print", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPrioridadeAlta.Location = new Point(61, 184);
            rdbPrioridadeAlta.Name = "rdbPrioridadeAlta";
            rdbPrioridadeAlta.Size = new Size(58, 28);
            rdbPrioridadeAlta.TabIndex = 13;
            rdbPrioridadeAlta.TabStop = true;
            rdbPrioridadeAlta.Text = "Alta";
            rdbPrioridadeAlta.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.marcacao;
            pictureBox1.Location = new Point(4, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.despertador;
            pictureBox2.Location = new Point(4, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.priority1;
            pictureBox3.Location = new Point(4, 157);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.lapis1;
            pictureBox4.Location = new Point(4, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 96);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 2;
            label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 125);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 3;
            label2.Text = "Data Final:";
            label2.Click += lblDataTermino_Click;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(284, 326);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rdbPrioridadeAlta);
            Controls.Add(rdbPrioridadeNormal);
            Controls.Add(rdbPrioridadeBaixa);
            Controls.Add(dtpDataFinal);
            Controls.Add(dtpDataInicial);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            Controls.Add(lblPrioridade);
            Controls.Add(label2);
            Controls.Add(lblDataTermino);
            Controls.Add(label1);
            Controls.Add(lblDataInicio);
            Controls.Add(lblTitulo);
            Controls.Add(lblId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tarefas";
            Load += TelaTarefaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblTitulo;
        private Label lblDataInicio;
        private Label lblDataTermino;
        private Label lblPrioridade;
        private TextBox txtId;
        private TextBox txtTitulo;
        private Button btnGravar;
        private Button btnCancelar;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private RadioButton rdbPrioridadeBaixa;
        private RadioButton rdbPrioridadeNormal;
        private RadioButton rdbPrioridadeAlta;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
    }
}