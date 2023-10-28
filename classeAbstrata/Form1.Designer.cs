namespace classeAbstrata
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnDesigner = new System.Windows.Forms.RadioButton();
            this.btnProgramador = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDWeb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salário:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(46, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(308, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(46, 151);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(119, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // btnDesigner
            // 
            this.btnDesigner.AutoSize = true;
            this.btnDesigner.Location = new System.Drawing.Point(27, 209);
            this.btnDesigner.Name = "btnDesigner";
            this.btnDesigner.Size = new System.Drawing.Size(67, 17);
            this.btnDesigner.TabIndex = 3;
            this.btnDesigner.TabStop = true;
            this.btnDesigner.Text = "Designer";
            this.btnDesigner.UseVisualStyleBackColor = true;
            // 
            // btnProgramador
            // 
            this.btnProgramador.AutoSize = true;
            this.btnProgramador.Location = new System.Drawing.Point(121, 209);
            this.btnProgramador.Name = "btnProgramador";
            this.btnProgramador.Size = new System.Drawing.Size(85, 17);
            this.btnProgramador.TabIndex = 3;
            this.btnProgramador.TabStop = true;
            this.btnProgramador.Text = "Programador";
            this.btnProgramador.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reajustar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(192, 381);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 6;
            // 
            // btnDWeb
            // 
            this.btnDWeb.AutoSize = true;
            this.btnDWeb.Location = new System.Drawing.Point(231, 209);
            this.btnDWeb.Name = "btnDWeb";
            this.btnDWeb.Size = new System.Drawing.Size(123, 17);
            this.btnDWeb.TabIndex = 7;
            this.btnDWeb.TabStop = true;
            this.btnDWeb.Text = "Desenvolvedor Web";
            this.btnDWeb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 434);
            this.Controls.Add(this.btnDWeb);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProgramador);
            this.Controls.Add(this.btnDesigner);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton btnDesigner;
        private System.Windows.Forms.RadioButton btnProgramador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton btnDWeb;
    }
}

