namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            clbObjetivos = new CheckedListBox();
            SuspendLayout();
            // 
            // clbObjetivos
            // 
            clbObjetivos.FormattingEnabled = true;
            clbObjetivos.Location = new Point(12, 249);
            clbObjetivos.Name = "clbObjetivos";
            clbObjetivos.Size = new Size(280, 112);
            clbObjetivos.TabIndex = 0;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clbObjetivos);
            Name = "TelaTarefaForm";
            Text = "TelaTarefaForm";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox clbObjetivos;
    }
}