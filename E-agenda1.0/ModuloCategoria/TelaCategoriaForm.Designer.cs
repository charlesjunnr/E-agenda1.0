namespace E_agenda1._0.ModuloCategoria
{
    partial class TelaCategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCategoriaForm));
            pictureBox2 = new PictureBox();
            txtDescricao = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.marcacao;
            pictureBox2.Location = new Point(26, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(74, 93);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(296, 23);
            txtDescricao.TabIndex = 49;
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(23, 23);
            txtId.TabIndex = 48;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 62);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 47;
            label1.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 20);
            label2.Name = "label2";
            label2.Size = new Size(33, 28);
            label2.TabIndex = 46;
            label2.Text = "Id:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.etiqueta_de_preco;
            pictureBox1.Location = new Point(26, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(194, 126);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(77, 51);
            btnGravar.TabIndex = 51;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(277, 126);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 51);
            btnCancelar.TabIndex = 52;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(388, 189);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(pictureBox2);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCategoriaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Categorias de Despesa";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private TextBox txtDescricao;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnGravar;
        private Button btnCancelar;
    }
}