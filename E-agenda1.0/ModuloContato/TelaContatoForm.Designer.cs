namespace E_agenda1._0.ModuloContato
{
    partial class TelaContatoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaContatoForm));
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmpresa = new TextBox();
            txtCargo = new TextBox();
            txtEmail = new TextBox();
            ptbTelefone = new PictureBox();
            ptbNome = new PictureBox();
            ptbEmpresa = new PictureBox();
            ptbCargo = new PictureBox();
            ptbEmail = new PictureBox();
            ptbId = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbTelefone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbNome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbEmpresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbCargo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbId).BeginInit();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.None;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(398, 159);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(89, 41);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(493, 159);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 41);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveBorder;
            txtId.Enabled = false;
            txtId.Location = new Point(106, 13);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(31, 25);
            txtId.TabIndex = 9;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.InactiveBorder;
            txtNome.Location = new Point(279, 16);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(303, 25);
            txtNome.TabIndex = 10;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.InactiveBorder;
            txtTelefone.Location = new Point(142, 65);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(152, 25);
            txtTelefone.TabIndex = 11;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BackColor = SystemColors.InactiveBorder;
            txtEmpresa.Location = new Point(142, 117);
            txtEmpresa.Margin = new Padding(3, 4, 3, 4);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(152, 25);
            txtEmpresa.TabIndex = 12;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = SystemColors.InactiveBorder;
            txtCargo.Location = new Point(430, 120);
            txtCargo.Margin = new Padding(3, 4, 3, 4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(152, 25);
            txtCargo.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveBorder;
            txtEmail.Location = new Point(430, 68);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 25);
            txtEmail.TabIndex = 13;
            // 
            // ptbTelefone
            // 
            ptbTelefone.ErrorImage = Properties.Resources.error;
            ptbTelefone.Image = Properties.Resources.celular;
            ptbTelefone.InitialImage = Properties.Resources.cavaleiro;
            ptbTelefone.Location = new Point(4, 62);
            ptbTelefone.Margin = new Padding(3, 4, 3, 4);
            ptbTelefone.Name = "ptbTelefone";
            ptbTelefone.Size = new Size(45, 44);
            ptbTelefone.SizeMode = PictureBoxSizeMode.Zoom;
            ptbTelefone.TabIndex = 15;
            ptbTelefone.TabStop = false;
            // 
            // ptbNome
            // 
            ptbNome.ErrorImage = Properties.Resources.error;
            ptbNome.Image = Properties.Resources.boy1;
            ptbNome.InitialImage = Properties.Resources.cavaleiro;
            ptbNome.Location = new Point(156, 10);
            ptbNome.Margin = new Padding(3, 4, 3, 4);
            ptbNome.Name = "ptbNome";
            ptbNome.Size = new Size(45, 44);
            ptbNome.SizeMode = PictureBoxSizeMode.Zoom;
            ptbNome.TabIndex = 16;
            ptbNome.TabStop = false;
            // 
            // ptbEmpresa
            // 
            ptbEmpresa.ErrorImage = Properties.Resources.error;
            ptbEmpresa.Image = Properties.Resources.escritorio;
            ptbEmpresa.InitialImage = Properties.Resources.cavaleiro;
            ptbEmpresa.Location = new Point(4, 114);
            ptbEmpresa.Margin = new Padding(3, 4, 3, 4);
            ptbEmpresa.Name = "ptbEmpresa";
            ptbEmpresa.Size = new Size(45, 44);
            ptbEmpresa.SizeMode = PictureBoxSizeMode.Zoom;
            ptbEmpresa.TabIndex = 17;
            ptbEmpresa.TabStop = false;
            // 
            // ptbCargo
            // 
            ptbCargo.ErrorImage = Properties.Resources.error;
            ptbCargo.Image = Properties.Resources.soldador;
            ptbCargo.InitialImage = Properties.Resources.cavaleiro;
            ptbCargo.Location = new Point(300, 101);
            ptbCargo.Margin = new Padding(3, 4, 3, 4);
            ptbCargo.Name = "ptbCargo";
            ptbCargo.Size = new Size(45, 44);
            ptbCargo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbCargo.TabIndex = 18;
            ptbCargo.TabStop = false;
            // 
            // ptbEmail
            // 
            ptbEmail.ErrorImage = Properties.Resources.error;
            ptbEmail.Image = Properties.Resources.o_email;
            ptbEmail.InitialImage = Properties.Resources.cavaleiro;
            ptbEmail.Location = new Point(300, 49);
            ptbEmail.Margin = new Padding(3, 4, 3, 4);
            ptbEmail.Name = "ptbEmail";
            ptbEmail.Size = new Size(45, 44);
            ptbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            ptbEmail.TabIndex = 19;
            ptbEmail.TabStop = false;
            // 
            // ptbId
            // 
            ptbId.ErrorImage = Properties.Resources.error;
            ptbId.Image = Properties.Resources.carteira_de_identidade;
            ptbId.InitialImage = Properties.Resources.cavaleiro;
            ptbId.Location = new Point(4, 10);
            ptbId.Margin = new Padding(3, 4, 3, 4);
            ptbId.Name = "ptbId";
            ptbId.Size = new Size(45, 44);
            ptbId.SizeMode = PictureBoxSizeMode.Zoom;
            ptbId.TabIndex = 20;
            ptbId.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(207, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 21;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 62);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 22;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 114);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 23;
            label3.Text = "Empresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(351, 65);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 24;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(351, 117);
            label5.Name = "label5";
            label5.Size = new Size(63, 28);
            label5.TabIndex = 25;
            label5.Text = "Cargo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 13);
            label6.Name = "label6";
            label6.Size = new Size(33, 28);
            label6.TabIndex = 26;
            label6.Text = "Id:";
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(632, 206);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ptbId);
            Controls.Add(ptbEmail);
            Controls.Add(ptbCargo);
            Controls.Add(ptbEmpresa);
            Controls.Add(ptbNome);
            Controls.Add(ptbTelefone);
            Controls.Add(txtCargo);
            Controls.Add(txtEmail);
            Controls.Add(txtEmpresa);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Font = new Font("Reem Kufi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Contatos";
            ((System.ComponentModel.ISupportInitialize)ptbTelefone).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbNome).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbEmpresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbCargo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmpresa;
        private TextBox txtCargo;
        private TextBox txtEmail;
        private PictureBox ptbTelefone;
        private PictureBox ptbNome;
        private PictureBox ptbEmpresa;
        private PictureBox ptbCargo;
        private PictureBox ptbEmail;
        private PictureBox ptbId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}