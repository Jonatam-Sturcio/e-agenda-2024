namespace eAgenda.WinApp.ModuloDespesa
{
    partial class TelaDespesaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            dtpData = new DateTimePicker();
            cbFormaPagamento = new ComboBox();
            listCategoria = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(173, 302);
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
            button2.Location = new Point(254, 302);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 55);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 84);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 117);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 5;
            label4.Text = "Forma de Pagamento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 84);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 6;
            label5.Text = "Data:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 148);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 7;
            label6.Text = "Categoria(s):";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(74, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "0";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(74, 51);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(255, 23);
            txtDescricao.TabIndex = 9;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(74, 80);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 10;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(227, 80);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(102, 23);
            dtpData.TabIndex = 11;
            // 
            // cbFormaPagamento
            // 
            cbFormaPagamento.FormattingEnabled = true;
            cbFormaPagamento.Location = new Point(137, 114);
            cbFormaPagamento.Name = "cbFormaPagamento";
            cbFormaPagamento.Size = new Size(97, 23);
            cbFormaPagamento.TabIndex = 12;
            // 
            // listCategoria
            // 
            listCategoria.FormattingEnabled = true;
            listCategoria.Location = new Point(7, 166);
            listCategoria.Name = "listCategoria";
            listCategoria.Size = new Size(322, 130);
            listCategoria.TabIndex = 13;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 336);
            Controls.Add(listCategoria);
            Controls.Add(cbFormaPagamento);
            Controls.Add(dtpData);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDespesaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Despesa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private DateTimePicker dtpData;
        private ComboBox cbFormaPagamento;
        private CheckedListBox listCategoria;
    }
}