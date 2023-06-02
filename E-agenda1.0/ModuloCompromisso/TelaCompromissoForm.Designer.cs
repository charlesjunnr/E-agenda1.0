namespace E_agenda1._0.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCompromissoForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            txtAssunto = new TextBox();
            txtData = new DateTimePicker();
            txtHoraInicio = new DateTimePicker();
            txtHoraTermino = new DateTimePicker();
            checkBoxTemContato = new CheckBox();
            cboxContatos = new ComboBox();
            groupBox1 = new GroupBox();
            txtLocalPresencial = new TextBox();
            txtLocalOnline = new TextBox();
            rdbPresencial = new RadioButton();
            rdbOnline = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 35);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(269, 33);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 1;
            label2.Text = "Assunto: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 100);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 2;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(327, 100);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Reem Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(475, 100);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 4;
            label5.Text = "Término:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGravar.Location = new Point(435, 352);
            btnGravar.Margin = new Padding(3, 5, 3, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 66);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(540, 352);
            btnCancelar.Margin = new Padding(3, 5, 3, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 66);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(119, 34);
            txtId.Margin = new Padding(3, 5, 3, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(35, 29);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(351, 34);
            txtAssunto.Margin = new Padding(3, 5, 3, 5);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(291, 27);
            txtAssunto.TabIndex = 9;
            // 
            // txtData
            // 
            txtData.CustomFormat = "dd/MM/yyyy";
            txtData.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Format = DateTimePickerFormat.Custom;
            txtData.Location = new Point(119, 100);
            txtData.Margin = new Padding(3, 5, 3, 5);
            txtData.Name = "txtData";
            txtData.Size = new Size(128, 29);
            txtData.TabIndex = 10;
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(381, 100);
            txtHoraInicio.Margin = new Padding(3, 5, 3, 5);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(87, 29);
            txtHoraInicio.TabIndex = 11;
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CustomFormat = "HH:mm";
            txtHoraTermino.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoraTermino.Format = DateTimePickerFormat.Custom;
            txtHoraTermino.Location = new Point(549, 100);
            txtHoraTermino.Margin = new Padding(3, 5, 3, 5);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.ShowUpDown = true;
            txtHoraTermino.Size = new Size(93, 29);
            txtHoraTermino.TabIndex = 12;
            // 
            // checkBoxTemContato
            // 
            checkBoxTemContato.AutoSize = true;
            checkBoxTemContato.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTemContato.Location = new Point(119, 148);
            checkBoxTemContato.Margin = new Padding(3, 5, 3, 5);
            checkBoxTemContato.Name = "checkBoxTemContato";
            checkBoxTemContato.Size = new Size(410, 32);
            checkBoxTemContato.TabIndex = 13;
            checkBoxTemContato.Text = "Deseja marcar um contato nesse compromisso?";
            checkBoxTemContato.UseVisualStyleBackColor = true;
            // 
            // cboxContatos
            // 
            cboxContatos.FormattingEnabled = true;
            cboxContatos.Location = new Point(393, 181);
            cboxContatos.Margin = new Padding(3, 5, 3, 5);
            cboxContatos.Name = "cboxContatos";
            cboxContatos.Size = new Size(225, 31);
            cboxContatos.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocalPresencial);
            groupBox1.Controls.Add(txtLocalOnline);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Controls.Add(rdbOnline);
            groupBox1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(76, 212);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(566, 130);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtLocalPresencial
            // 
            txtLocalPresencial.Location = new Point(149, 86);
            txtLocalPresencial.Margin = new Padding(3, 5, 3, 5);
            txtLocalPresencial.Name = "txtLocalPresencial";
            txtLocalPresencial.Size = new Size(393, 36);
            txtLocalPresencial.TabIndex = 24;
            // 
            // txtLocalOnline
            // 
            txtLocalOnline.Location = new Point(149, 41);
            txtLocalOnline.Margin = new Padding(3, 5, 3, 5);
            txtLocalOnline.Name = "txtLocalOnline";
            txtLocalOnline.Size = new Size(393, 36);
            txtLocalOnline.TabIndex = 23;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPresencial.Location = new Point(33, 86);
            rdbPresencial.Margin = new Padding(3, 5, 3, 5);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(110, 32);
            rdbPresencial.TabIndex = 22;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial";
            rdbPresencial.UseVisualStyleBackColor = true;
            // 
            // rdbOnline
            // 
            rdbOnline.AutoSize = true;
            rdbOnline.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbOnline.Location = new Point(33, 43);
            rdbOnline.Margin = new Padding(3, 5, 3, 5);
            rdbOnline.Name = "rdbOnline";
            rdbOnline.Size = new Size(83, 32);
            rdbOnline.TabIndex = 21;
            rdbOnline.TabStop = true;
            rdbOnline.Text = "Online";
            rdbOnline.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.seguir1;
            pictureBox1.Location = new Point(14, 148);
            pictureBox1.Margin = new Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.marcacao;
            pictureBox2.Location = new Point(14, 15);
            pictureBox2.Margin = new Padding(3, 5, 3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.calendar;
            pictureBox3.Location = new Point(14, 83);
            pictureBox3.Margin = new Padding(3, 5, 3, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.mapa;
            pictureBox4.Location = new Point(15, 213);
            pictureBox4.Margin = new Padding(3, 5, 3, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.priority1;
            pictureBox5.Location = new Point(215, 15);
            pictureBox5.Margin = new Padding(3, 5, 3, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 55);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.despertador;
            pictureBox6.Location = new Point(269, 83);
            pictureBox6.Margin = new Padding(3, 5, 3, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(654, 428);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cboxContatos);
            Controls.Add(checkBoxTemContato);
            Controls.Add(txtHoraTermino);
            Controls.Add(txtHoraInicio);
            Controls.Add(txtData);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Reem Kufi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
        private TextBox txtAssunto;
        private DateTimePicker txtData;
        private DateTimePicker txtHoraInicio;
        private DateTimePicker txtHoraTermino;
        private CheckBox checkBoxTemContato;
        private ComboBox cboxContatos;
        private TextBox txtLocalizacaoRemota;
        private GroupBox groupBox1;
        private TextBox txtLocalPresencial;
        private TextBox txtLocalOnline;
        private RadioButton rdbPresencial;
        private RadioButton rdbOnline;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}