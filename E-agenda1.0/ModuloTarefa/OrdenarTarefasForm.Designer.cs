namespace E_agenda1._0.ModuloTarefa
{
    partial class OrdenarTarefasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenarTarefasForm));
            button1 = new Button();
            button2 = new Button();
            ptbEmail = new PictureBox();
            label1 = new Label();
            rdbPendentes = new RadioButton();
            rdbPrioritarias = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)ptbEmail).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(107, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 0;
            button1.Text = "Selecionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(188, 96);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ptbEmail
            // 
            ptbEmail.ErrorImage = Properties.Resources.error;
            ptbEmail.Image = Properties.Resources.agenda;
            ptbEmail.InitialImage = Properties.Resources.cavaleiro;
            ptbEmail.Location = new Point(12, 13);
            ptbEmail.Margin = new Padding(3, 4, 3, 4);
            ptbEmail.Name = "ptbEmail";
            ptbEmail.Size = new Size(45, 44);
            ptbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            ptbEmail.TabIndex = 20;
            ptbEmail.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 13);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 21;
            label1.Text = "Selecionar Tarefas:";
            // 
            // rdbPendentes
            // 
            rdbPendentes.AutoSize = true;
            rdbPendentes.Location = new Point(77, 56);
            rdbPendentes.Name = "rdbPendentes";
            rdbPendentes.Size = new Size(80, 19);
            rdbPendentes.TabIndex = 22;
            rdbPendentes.TabStop = true;
            rdbPendentes.Text = "Pendentes";
            rdbPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbPrioritarias
            // 
            rdbPrioritarias.AutoSize = true;
            rdbPrioritarias.Location = new Point(163, 56);
            rdbPrioritarias.Name = "rdbPrioritarias";
            rdbPrioritarias.Size = new Size(81, 19);
            rdbPrioritarias.TabIndex = 23;
            rdbPrioritarias.TabStop = true;
            rdbPrioritarias.Text = "Prioritárias";
            rdbPrioritarias.UseVisualStyleBackColor = true;
            // 
            // OrdenarTarefasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(283, 147);
            Controls.Add(rdbPrioritarias);
            Controls.Add(rdbPendentes);
            Controls.Add(label1);
            Controls.Add(ptbEmail);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrdenarTarefasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ordenar Tarefas";
            ((System.ComponentModel.ISupportInitialize)ptbEmail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox ptbEmail;
        private Label label1;
        private RadioButton rdbPendentes;
        private RadioButton rdbPrioritarias;
    }
}