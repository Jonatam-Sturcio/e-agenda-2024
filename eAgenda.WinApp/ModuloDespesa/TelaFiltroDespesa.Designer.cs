namespace eAgenda.WinApp.ModuloDespesa
{
    partial class TelaFiltroDespesa
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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            rbCategoria = new RadioButton();
            cbCategorias = new ComboBox();
            rbTodos = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(19, 132);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(130, 132);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbCategoria);
            groupBox1.Controls.Add(cbCategorias);
            groupBox1.Controls.Add(rbTodos);
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 114);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione um filtro";
            // 
            // rbCategoria
            // 
            rbCategoria.AutoSize = true;
            rbCategoria.Location = new Point(13, 47);
            rbCategoria.Name = "rbCategoria";
            rbCategoria.Size = new Size(76, 19);
            rbCategoria.TabIndex = 6;
            rbCategoria.TabStop = true;
            rbCategoria.Text = "Categoria";
            rbCategoria.UseVisualStyleBackColor = true;
            rbCategoria.CheckedChanged += rbCategoria_CheckedChanged;
            // 
            // cbCategorias
            // 
            cbCategorias.Enabled = false;
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Location = new Point(13, 72);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(167, 23);
            cbCategorias.TabIndex = 3;
            // 
            // rbTodos
            // 
            rbTodos.AutoSize = true;
            rbTodos.Checked = true;
            rbTodos.Location = new Point(13, 22);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(56, 19);
            rbTodos.TabIndex = 5;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos";
            rbTodos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroDespesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 168);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroDespesa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Seleção de Filtro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton rbCategoria;
        private ComboBox cbCategorias;
        private RadioButton rbTodos;
    }
}