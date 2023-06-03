namespace E_agenda1._0.ModuloDespesa
{
    partial class VisualizacaoDespesasCategoriaForm
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblCategoria = new Label();
            label2 = new Label();
            listBoxDespesas = new ListBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 34);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 42;
            label1.Text = "Categoria:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fluxo_de_trabalho_1_;
            pictureBox1.Location = new Point(12, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCategoria.Location = new Point(159, 34);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(177, 28);
            lblCategoria.TabIndex = 44;
            lblCategoria.Text = "categoriaSelecionada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 74);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 45;
            label2.Text = "Despesas";
            // 
            // listBoxDespesas
            // 
            listBoxDespesas.FormattingEnabled = true;
            listBoxDespesas.ItemHeight = 15;
            listBoxDespesas.Location = new Point(60, 105);
            listBoxDespesas.Name = "listBoxDespesas";
            listBoxDespesas.Size = new Size(496, 244);
            listBoxDespesas.TabIndex = 46;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(481, 355);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 47;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cartao;
            pictureBox2.Location = new Point(12, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // VisualizacaoDespesasCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(569, 410);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(listBoxDespesas);
            Controls.Add(label2);
            Controls.Add(lblCategoria);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "VisualizacaoDespesasCategoriaForm";
            Text = "Visualização de Despesas da Categoria";
            Load += VisualizacaoDespesasCategoriaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lblCategoria;
        private Label label2;
        private ListBox listBoxDespesas;
        private Button button1;
        private PictureBox pictureBox2;
    }
}