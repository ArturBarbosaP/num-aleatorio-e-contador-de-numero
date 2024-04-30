
namespace While_2_3
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltx_imprimir = new System.Windows.Forms.ListBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltx_imprimir
            // 
            this.ltx_imprimir.FormattingEnabled = true;
            this.ltx_imprimir.Location = new System.Drawing.Point(10, 12);
            this.ltx_imprimir.Name = "ltx_imprimir";
            this.ltx_imprimir.Size = new System.Drawing.Size(300, 303);
            this.ltx_imprimir.TabIndex = 0;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(10, 331);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(300, 45);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 388);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.ltx_imprimir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltx_imprimir;
        private System.Windows.Forms.Button btn_calcular;
    }
}

