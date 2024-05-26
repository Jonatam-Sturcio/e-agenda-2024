namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromisso
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
            groupBox1 = new GroupBox();
            rbFuturos = new RadioButton();
            rbPassados = new RadioButton();
            rbTodos = new RadioButton();
            btnCancelar = new Button();
            btnFiltrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFuturos);
            groupBox1.Controls.Add(rbPassados);
            groupBox1.Controls.Add(rbTodos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione um Filtro:";
            // 
            // rbFuturos
            // 
            rbFuturos.AutoSize = true;
            rbFuturos.Location = new Point(6, 72);
            rbFuturos.Name = "rbFuturos";
            rbFuturos.Size = new Size(146, 19);
            rbFuturos.TabIndex = 2;
            rbFuturos.Text = "Compromissos futuros";
            rbFuturos.UseVisualStyleBackColor = true;
            // 
            // rbPassados
            // 
            rbPassados.AutoSize = true;
            rbPassados.Location = new Point(6, 47);
            rbPassados.Name = "rbPassados";
            rbPassados.Size = new Size(156, 19);
            rbPassados.TabIndex = 1;
            rbPassados.Text = "Compromissos passados";
            rbPassados.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Checked = true;
            rbTodos.Location = new Point(6, 22);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(147, 19);
            rbTodos.TabIndex = 0;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos os compromisso";
            rbTodos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(283, 123);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(202, 123);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // TelaFiltroCompromisso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 153);
            Controls.Add(btnFiltrar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromisso";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filtro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbFuturos;
        private RadioButton rbPassados;
        private RadioButton rbTodos;
        private Button btnCancelar;
        private Button btnFiltrar;
    }
}