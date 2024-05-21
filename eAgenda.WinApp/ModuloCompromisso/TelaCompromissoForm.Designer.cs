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
            txtLocal = new TextBox();
            label2 = new Label();
            txtAssunto = new TextBox();
            label3 = new Label();
            txtData = new TextBox();
            label4 = new Label();
            txtHoraInicio = new TextBox();
            label5 = new Label();
            txtHoraTermino = new TextBox();
            label6 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 43);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(68, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 12;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(221, 40);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(297, 23);
            txtLocal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 43);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Local";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(68, 80);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(450, 23);
            txtAssunto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Assunto";
            // 
            // txtData
            // 
            txtData.Location = new Point(68, 119);
            txtData.Name = "txtData";
            txtData.Size = new Size(83, 23);
            txtData.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 122);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Data";
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Location = new Point(244, 119);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.Size = new Size(77, 23);
            txtHoraInicio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 122);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 8;
            label5.Text = "Hora de Inicio";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.Location = new Point(439, 119);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.Size = new Size(79, 23);
            txtHoraTermino.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 122);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 10;
            label6.Text = "Hora de Termino";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(287, 183);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(115, 32);
            btnGravar.TabIndex = 13;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(419, 183);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 32);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 227);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtHoraTermino);
            Controls.Add(label6);
            Controls.Add(txtHoraInicio);
            Controls.Add(label5);
            Controls.Add(txtData);
            Controls.Add(label4);
            Controls.Add(txtAssunto);
            Controls.Add(label3);
            Controls.Add(txtLocal);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            Text = "Cadastro de Compromisso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtLocal;
        private Label label2;
        private TextBox txtAssunto;
        private Label label3;
        private TextBox txtData;
        private Label label4;
        private TextBox txtHoraInicio;
        private Label label5;
        private TextBox txtHoraTermino;
        private Label label6;
        private Button btnGravar;
        private Button btnCancelar;
    }
}