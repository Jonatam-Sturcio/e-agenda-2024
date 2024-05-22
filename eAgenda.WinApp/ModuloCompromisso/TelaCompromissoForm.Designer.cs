namespace eAgenda.WinApp.ModuloCompromisso
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
            label1 = new Label();
            txtId = new TextBox();
            txtAssunto = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            dtpData = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            dtpHoraTermino = new DateTimePicker();
            chkPossuiContato = new CheckBox();
            cmbContatos = new ComboBox();
            GroupBox1 = new GroupBox();
            txtPresencial = new TextBox();
            txtRemoto = new TextBox();
            rbPresencial = new RadioButton();
            rbRemoto = new RadioButton();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(66, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(70, 23);
            txtId.TabIndex = 12;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(66, 63);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(333, 23);
            txtAssunto.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 66);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Assunto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 108);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 145);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 8;
            label5.Text = "Início:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 145);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "Término:";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(132, 405);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(115, 32);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(284, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 32);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(66, 102);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(135, 23);
            dtpData.TabIndex = 2;
            dtpData.Value = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(66, 141);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(135, 23);
            dtpHoraInicio.TabIndex = 3;
            dtpHoraInicio.Value = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // dtpHoraTermino
            // 
            dtpHoraTermino.CustomFormat = "HH:mm";
            dtpHoraTermino.Format = DateTimePickerFormat.Custom;
            dtpHoraTermino.Location = new Point(264, 141);
            dtpHoraTermino.Name = "dtpHoraTermino";
            dtpHoraTermino.ShowUpDown = true;
            dtpHoraTermino.Size = new Size(135, 23);
            dtpHoraTermino.TabIndex = 13;
            dtpHoraTermino.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // chkPossuiContato
            // 
            chkPossuiContato.AutoSize = true;
            chkPossuiContato.Location = new Point(66, 198);
            chkPossuiContato.Name = "chkPossuiContato";
            chkPossuiContato.Size = new Size(277, 19);
            chkPossuiContato.TabIndex = 14;
            chkPossuiContato.Text = "Deseja marcar um contato neste compromisso?";
            chkPossuiContato.UseVisualStyleBackColor = true;
            chkPossuiContato.CheckedChanged += chkPossuiContato_CheckedChanged;
            // 
            // cmbContatos
            // 
            cmbContatos.Enabled = false;
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(66, 223);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(121, 23);
            cmbContatos.TabIndex = 15;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(txtPresencial);
            GroupBox1.Controls.Add(txtRemoto);
            GroupBox1.Controls.Add(rbPresencial);
            GroupBox1.Controls.Add(rbRemoto);
            GroupBox1.Location = new Point(66, 263);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(333, 121);
            GroupBox1.TabIndex = 16;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Localização";
            // 
            // txtPresencial
            // 
            txtPresencial.Enabled = false;
            txtPresencial.Location = new Point(106, 61);
            txtPresencial.Name = "txtPresencial";
            txtPresencial.Size = new Size(221, 23);
            txtPresencial.TabIndex = 3;
            // 
            // txtRemoto
            // 
            txtRemoto.Enabled = false;
            txtRemoto.Location = new Point(106, 32);
            txtRemoto.Name = "txtRemoto";
            txtRemoto.Size = new Size(221, 23);
            txtRemoto.TabIndex = 2;
            // 
            // rbPresencial
            // 
            rbPresencial.AutoSize = true;
            rbPresencial.Location = new Point(16, 63);
            rbPresencial.Name = "rbPresencial";
            rbPresencial.Size = new Size(81, 19);
            rbPresencial.TabIndex = 1;
            rbPresencial.TabStop = true;
            rbPresencial.Text = "Presencial:";
            rbPresencial.UseVisualStyleBackColor = true;
            rbPresencial.CheckedChanged += rbPresencial_CheckedChanged;
            // 
            // rbRemoto
            // 
            rbRemoto.AutoSize = true;
            rbRemoto.Location = new Point(16, 34);
            rbRemoto.Name = "rbRemoto";
            rbRemoto.Size = new Size(70, 19);
            rbRemoto.TabIndex = 0;
            rbRemoto.TabStop = true;
            rbRemoto.Text = "Remoto:";
            rbRemoto.UseVisualStyleBackColor = true;
            rbRemoto.CheckedChanged += rbRemoto_CheckedChanged;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 449);
            Controls.Add(GroupBox1);
            Controls.Add(cmbContatos);
            Controls.Add(chkPossuiContato);
            Controls.Add(dtpHoraTermino);
            Controls.Add(dtpHoraInicio);
            Controls.Add(dtpData);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAssunto);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Compromisso";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtAssunto;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGravar;
        private Button btnCancelar;
        private DateTimePicker dtpData;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraTermino;
        private CheckBox chkPossuiContato;
        private ComboBox cmbContatos;
        private GroupBox GroupBox1;
        private RadioButton rbPresencial;
        private RadioButton rbRemoto;
        private TextBox txtPresencial;
        private TextBox txtRemoto;
    }
}