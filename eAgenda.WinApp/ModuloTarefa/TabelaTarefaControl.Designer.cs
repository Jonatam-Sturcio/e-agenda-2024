namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TabelaTarefaControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            listTarefas = new ListView();
            SuspendLayout();
            // 
            // listTarefas
            // 
            listTarefas.Dock = DockStyle.Fill;
            listTarefas.Location = new Point(0, 0);
            listTarefas.Name = "listTarefas";
            listTarefas.Size = new Size(452, 367);
            listTarefas.TabIndex = 0;
            listTarefas.UseCompatibleStateImageBehavior = false;
            // 
            // TabelaTarefaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTarefas);
            Name = "TabelaTarefaControl";
            Size = new Size(452, 367);
            ResumeLayout(false);
        }

        #endregion

        private ListView listTarefas;
    }
}
