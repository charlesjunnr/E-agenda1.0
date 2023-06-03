namespace E_agenda1._0.ModuloTarefa
{
    partial class ConcluirEtapasTarefasForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcluirEtapasTarefasForms));
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            progressBarEtapas = new ProgressBar();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtTarefa = new TextBox();
            clbEtapasTarefa = new CheckedListBox();
            btnConcluir = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.camada;
            pictureBox1.Location = new Point(12, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.livro;
            pictureBox5.Location = new Point(12, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // progressBarEtapas
            // 
            progressBarEtapas.ForeColor = Color.Lime;
            progressBarEtapas.Location = new Point(7, 78);
            progressBarEtapas.Name = "progressBarEtapas";
            progressBarEtapas.Size = new Size(303, 23);
            progressBarEtapas.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(121, 47);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 32;
            label2.Text = "Progresso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 116);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 33;
            label1.Text = "Etapas:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 12);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 34;
            label3.Text = "Tarefa:";
            // 
            // txtTarefa
            // 
            txtTarefa.Enabled = false;
            txtTarefa.Location = new Point(120, 17);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(190, 23);
            txtTarefa.TabIndex = 35;
            // 
            // clbEtapasTarefa
            // 
            clbEtapasTarefa.FormattingEnabled = true;
            clbEtapasTarefa.Location = new Point(12, 168);
            clbEtapasTarefa.Name = "clbEtapasTarefa";
            clbEtapasTarefa.Size = new Size(298, 202);
            clbEtapasTarefa.TabIndex = 36;
            // 
            // btnConcluir
            // 
            btnConcluir.DialogResult = DialogResult.OK;
            btnConcluir.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConcluir.Location = new Point(118, 387);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(93, 46);
            btnConcluir.TabIndex = 37;
            btnConcluir.Text = "Concluir";
            btnConcluir.UseVisualStyleBackColor = true;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(217, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 46);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ConcluirEtapasTarefasForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(322, 445);
            Controls.Add(btnCancelar);
            Controls.Add(btnConcluir);
            Controls.Add(clbEtapasTarefa);
            Controls.Add(txtTarefa);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(progressBarEtapas);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConcluirEtapasTarefasForms";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Concluir Etapas";
            Load += ConcluirEtapasTarefasForms_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private ProgressBar progressBarEtapas;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtTarefa;
        private CheckedListBox clbEtapasTarefa;
        private Button btnConcluir;
        private Button btnCancelar;
    }
}