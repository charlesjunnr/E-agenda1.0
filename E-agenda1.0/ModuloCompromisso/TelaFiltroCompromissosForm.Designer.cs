namespace E_agenda1._0.ModuloCompromisso
{
    partial class TelaFiltroCompromissosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFiltroCompromissosForm));
            btnFiltrar = new Button();
            btnCancelar = new Button();
            rdbVisualizarTodos = new RadioButton();
            rdbVisualizarCompromissosPassados = new RadioButton();
            rdbVisualizarCompromissosFuturos = new RadioButton();
            lblDataInicial = new Label();
            lblDataFinal = new Label();
            txtDataFinal = new DateTimePicker();
            txtDataInicial = new DateTimePicker();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFiltrar.Location = new Point(132, 252);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 57);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(213, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 57);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbVisualizarTodos
            // 
            rdbVisualizarTodos.AutoSize = true;
            rdbVisualizarTodos.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbVisualizarTodos.Location = new Point(58, 22);
            rdbVisualizarTodos.Name = "rdbVisualizarTodos";
            rdbVisualizarTodos.Size = new Size(302, 32);
            rdbVisualizarTodos.TabIndex = 2;
            rdbVisualizarTodos.TabStop = true;
            rdbVisualizarTodos.Text = "Visualizar Todos os Compromissos";
            rdbVisualizarTodos.UseVisualStyleBackColor = true;
            // 
            // rdbVisualizarCompromissosPassados
            // 
            rdbVisualizarCompromissosPassados.AutoSize = true;
            rdbVisualizarCompromissosPassados.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbVisualizarCompromissosPassados.Location = new Point(58, 65);
            rdbVisualizarCompromissosPassados.Name = "rdbVisualizarCompromissosPassados";
            rdbVisualizarCompromissosPassados.Size = new Size(303, 32);
            rdbVisualizarCompromissosPassados.TabIndex = 3;
            rdbVisualizarCompromissosPassados.TabStop = true;
            rdbVisualizarCompromissosPassados.Text = "Visualizar Compromissos Passados";
            rdbVisualizarCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // rdbVisualizarCompromissosFuturos
            // 
            rdbVisualizarCompromissosFuturos.AutoSize = true;
            rdbVisualizarCompromissosFuturos.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbVisualizarCompromissosFuturos.Location = new Point(58, 110);
            rdbVisualizarCompromissosFuturos.Name = "rdbVisualizarCompromissosFuturos";
            rdbVisualizarCompromissosFuturos.Size = new Size(294, 32);
            rdbVisualizarCompromissosFuturos.TabIndex = 4;
            rdbVisualizarCompromissosFuturos.TabStop = true;
            rdbVisualizarCompromissosFuturos.Text = "Visualizar Compromissos Futuros";
            rdbVisualizarCompromissosFuturos.UseVisualStyleBackColor = true;
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataInicial.Location = new Point(58, 165);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(110, 28);
            lblDataInicial.TabIndex = 5;
            lblDataInicial.Text = "Data Inicial:";
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataFinal.Location = new Point(58, 195);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(107, 28);
            lblDataFinal.TabIndex = 6;
            lblDataFinal.Text = "Data Final: ";
            // 
            // txtDataFinal
            // 
            txtDataFinal.CustomFormat = "dd/MM/yyyy";
            txtDataFinal.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataFinal.Format = DateTimePickerFormat.Custom;
            txtDataFinal.Location = new Point(174, 199);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(141, 29);
            txtDataFinal.TabIndex = 7;
            // 
            // txtDataInicial
            // 
            txtDataInicial.CustomFormat = "dd/MM/yyyy";
            txtDataInicial.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataInicial.Format = DateTimePickerFormat.Custom;
            txtDataInicial.Location = new Point(174, 163);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(141, 29);
            txtDataInicial.TabIndex = 8;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.despertador;
            pictureBox5.Location = new Point(10, 165);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.folders;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arquivo_anexo1;
            pictureBox2.Location = new Point(10, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.folder1;
            pictureBox3.Location = new Point(10, 96);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // TelaFiltroCompromissosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(376, 321);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(txtDataInicial);
            Controls.Add(txtDataFinal);
            Controls.Add(lblDataFinal);
            Controls.Add(lblDataInicial);
            Controls.Add(rdbVisualizarCompromissosFuturos);
            Controls.Add(rdbVisualizarCompromissosPassados);
            Controls.Add(rdbVisualizarTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissosForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro de Compromissos";
            Load += TelaFiltroCompromissosForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnCancelar;
        private RadioButton rdbVisualizarTodos;
        private RadioButton rdbVisualizarCompromissosPassados;
        private RadioButton rdbVisualizarCompromissosFuturos;
        private Label lblDataInicial;
        private Label lblDataFinal;
        private DateTimePicker txtDataFinal;
        private DateTimePicker txtDataInicial;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}