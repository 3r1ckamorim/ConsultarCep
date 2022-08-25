namespace WfConsultaCeps
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
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarCep.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCep.Location = new System.Drawing.Point(415, 37);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(79, 38);
            this.btnBuscarCep.TabIndex = 2;
            this.btnBuscarCep.Text = "BuscarCep";
            this.btnBuscarCep.UseVisualStyleBackColor = false;
            this.btnBuscarCep.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Location = new System.Drawing.Point(12, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(397, 20);
            this.textBox4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Endereço";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnBuscarCep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarCep;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
    }
}

