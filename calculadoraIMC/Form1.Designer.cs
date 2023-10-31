namespace calculadoraIMC
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
            this.Lbtitulo = new System.Windows.Forms.Label();
            this.Lbpeso = new System.Windows.Forms.Label();
            this.Lbaltura = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.LbIMC = new System.Windows.Forms.Label();
            this.Lbsituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbtitulo
            // 
            this.Lbtitulo.AutoSize = true;
            this.Lbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbtitulo.Location = new System.Drawing.Point(22, 38);
            this.Lbtitulo.Name = "Lbtitulo";
            this.Lbtitulo.Size = new System.Drawing.Size(228, 31);
            this.Lbtitulo.TabIndex = 0;
            this.Lbtitulo.Text = "Calcule seu IMC";
            this.Lbtitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbpeso
            // 
            this.Lbpeso.AutoSize = true;
            this.Lbpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbpeso.Location = new System.Drawing.Point(24, 108);
            this.Lbpeso.Name = "Lbpeso";
            this.Lbpeso.Size = new System.Drawing.Size(45, 20);
            this.Lbpeso.TabIndex = 1;
            this.Lbpeso.Text = "Peso";
            // 
            // Lbaltura
            // 
            this.Lbaltura.AutoSize = true;
            this.Lbaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbaltura.Location = new System.Drawing.Point(24, 162);
            this.Lbaltura.Name = "Lbaltura";
            this.Lbaltura.Size = new System.Drawing.Size(51, 20);
            this.Lbaltura.TabIndex = 2;
            this.Lbaltura.Text = "Altura";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(97, 110);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(153, 20);
            this.txtpeso.TabIndex = 3;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(97, 164);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(153, 20);
            this.txtaltura.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Lime;
            this.btncalcular.Location = new System.Drawing.Point(28, 215);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(222, 50);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(80, 281);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(170, 20);
            this.txtIMC.TabIndex = 7;
            // 
            // LbIMC
            // 
            this.LbIMC.AutoSize = true;
            this.LbIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIMC.Location = new System.Drawing.Point(24, 281);
            this.LbIMC.Name = "LbIMC";
            this.LbIMC.Size = new System.Drawing.Size(38, 20);
            this.LbIMC.TabIndex = 6;
            this.LbIMC.Text = "IMC";
            this.LbIMC.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Lbsituacao
            // 
            this.Lbsituacao.AutoSize = true;
            this.Lbsituacao.Location = new System.Drawing.Point(25, 332);
            this.Lbsituacao.Name = "Lbsituacao";
            this.Lbsituacao.Size = new System.Drawing.Size(0, 13);
            this.Lbsituacao.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 363);
            this.Controls.Add(this.Lbsituacao);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.LbIMC);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.Lbaltura);
            this.Controls.Add(this.Lbpeso);
            this.Controls.Add(this.Lbtitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbtitulo;
        private System.Windows.Forms.Label Lbpeso;
        private System.Windows.Forms.Label Lbaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label LbIMC;
        private System.Windows.Forms.Label Lbsituacao;
    }
}

