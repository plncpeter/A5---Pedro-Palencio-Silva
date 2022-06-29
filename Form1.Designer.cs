namespace A5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            this.lblTitulo5 = new System.Windows.Forms.Label();
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblTitulo6 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo1.Location = new System.Drawing.Point(65, 19);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(97, 18);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Calculadora de";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo2.Location = new System.Drawing.Point(80, 39);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(64, 18);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Triangulo";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Location = new System.Drawing.Point(12, 145);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(31, 13);
            this.lblTitulo3.TabIndex = 2;
            this.lblTitulo3.Text = "Base";
            this.lblTitulo3.Click += new System.EventHandler(this.lblTitulo3_Click);
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.AutoSize = true;
            this.lblTitulo4.Location = new System.Drawing.Point(12, 194);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(34, 13);
            this.lblTitulo4.TabIndex = 3;
            this.lblTitulo4.Text = "Altura";
            // 
            // lblTitulo5
            // 
            this.lblTitulo5.AutoSize = true;
            this.lblTitulo5.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo5.Location = new System.Drawing.Point(12, 112);
            this.lblTitulo5.Name = "lblTitulo5";
            this.lblTitulo5.Size = new System.Drawing.Size(134, 18);
            this.lblTitulo5.TabIndex = 4;
            this.lblTitulo5.Text = "Insira as informações";
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(49, 142);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(155, 20);
            this.txbN1.TabIndex = 5;
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(49, 191);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(155, 20);
            this.txbN2.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn.Location = new System.Drawing.Point(147, 257);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblTitulo6
            // 
            this.lblTitulo6.AutoSize = true;
            this.lblTitulo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo6.Location = new System.Drawing.Point(33, 340);
            this.lblTitulo6.Name = "lblTitulo6";
            this.lblTitulo6.Size = new System.Drawing.Size(39, 16);
            this.lblTitulo6.TabIndex = 8;
            this.lblTitulo6.Text = "Area:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(169, 340);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 16);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "NaN";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(234, 418);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTitulo6);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.txbN1);
            this.Controls.Add(this.lblTitulo5);
            this.Controls.Add(this.lblTitulo4);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblTitulo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblTitulo4;
        private System.Windows.Forms.Label lblTitulo5;
        private System.Windows.Forms.TextBox txbN1;
        private System.Windows.Forms.TextBox txbN2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblTitulo6;
        private System.Windows.Forms.Label lblResultado;
    }
}

