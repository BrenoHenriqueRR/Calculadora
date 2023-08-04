namespace teste
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
            this.btsair = new System.Windows.Forms.Button();
            this.btmais = new System.Windows.Forms.Button();
            this.btdivisao = new System.Windows.Forms.Button();
            this.btmultiplicação = new System.Windows.Forms.Button();
            this.btmenos = new System.Windows.Forms.Button();
            this.Txtbnumber1 = new System.Windows.Forms.TextBox();
            this.LBnumber1 = new System.Windows.Forms.Label();
            this.lbnumber2 = new System.Windows.Forms.Label();
            this.TxtBnumber2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.Red;
            this.btsair.Location = new System.Drawing.Point(280, 295);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(107, 50);
            this.btsair.TabIndex = 2;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.button2_Click);
            // 
            // btmais
            // 
            this.btmais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmais.Location = new System.Drawing.Point(179, 161);
            this.btmais.Name = "btmais";
            this.btmais.Size = new System.Drawing.Size(42, 28);
            this.btmais.TabIndex = 3;
            this.btmais.Text = "+";
            this.btmais.UseVisualStyleBackColor = true;
            this.btmais.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btdivisao
            // 
            this.btdivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdivisao.Location = new System.Drawing.Point(179, 219);
            this.btdivisao.Name = "btdivisao";
            this.btdivisao.Size = new System.Drawing.Size(42, 28);
            this.btdivisao.TabIndex = 4;
            this.btdivisao.Text = "/";
            this.btdivisao.UseVisualStyleBackColor = true;
            this.btdivisao.Click += new System.EventHandler(this.btdivisao_Click);
            // 
            // btmultiplicação
            // 
            this.btmultiplicação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmultiplicação.Location = new System.Drawing.Point(254, 219);
            this.btmultiplicação.Name = "btmultiplicação";
            this.btmultiplicação.Size = new System.Drawing.Size(42, 28);
            this.btmultiplicação.TabIndex = 5;
            this.btmultiplicação.Text = "x";
            this.btmultiplicação.UseVisualStyleBackColor = true;
            this.btmultiplicação.Click += new System.EventHandler(this.btmultiplicação_Click);
            // 
            // btmenos
            // 
            this.btmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenos.Location = new System.Drawing.Point(254, 161);
            this.btmenos.Name = "btmenos";
            this.btmenos.Size = new System.Drawing.Size(42, 28);
            this.btmenos.TabIndex = 6;
            this.btmenos.Text = "-";
            this.btmenos.UseVisualStyleBackColor = true;
            this.btmenos.Click += new System.EventHandler(this.button4_Click);
            // 
            // Txtbnumber1
            // 
            this.Txtbnumber1.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.Txtbnumber1.Location = new System.Drawing.Point(113, 119);
            this.Txtbnumber1.Name = "Txtbnumber1";
            this.Txtbnumber1.Size = new System.Drawing.Size(52, 22);
            this.Txtbnumber1.TabIndex = 7;
            // 
            // LBnumber1
            // 
            this.LBnumber1.AutoSize = true;
            this.LBnumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnumber1.Location = new System.Drawing.Point(110, 100);
            this.LBnumber1.Name = "LBnumber1";
            this.LBnumber1.Size = new System.Drawing.Size(61, 16);
            this.LBnumber1.TabIndex = 8;
            this.LBnumber1.Text = "Numero";
            this.LBnumber1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBnumber1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbnumber2
            // 
            this.lbnumber2.AutoSize = true;
            this.lbnumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumber2.Location = new System.Drawing.Point(277, 100);
            this.lbnumber2.Name = "lbnumber2";
            this.lbnumber2.Size = new System.Drawing.Size(69, 16);
            this.lbnumber2.TabIndex = 9;
            this.lbnumber2.Text = "Numero2";
            this.lbnumber2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtBnumber2
            // 
            this.TxtBnumber2.Location = new System.Drawing.Point(280, 119);
            this.TxtBnumber2.Name = "TxtBnumber2";
            this.TxtBnumber2.Size = new System.Drawing.Size(59, 22);
            this.TxtBnumber2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "CALCULADORA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.LightGreen;
            this.btCalcular.Location = new System.Drawing.Point(64, 295);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(107, 50);
            this.btCalcular.TabIndex = 12;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 365);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBnumber2);
            this.Controls.Add(this.lbnumber2);
            this.Controls.Add(this.LBnumber1);
            this.Controls.Add(this.Txtbnumber1);
            this.Controls.Add(this.btmenos);
            this.Controls.Add(this.btmultiplicação);
            this.Controls.Add(this.btdivisao);
            this.Controls.Add(this.btmais);
            this.Controls.Add(this.btsair);
            this.Name = "Form1";
            this.Text = "TESTE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btmais;
        private System.Windows.Forms.Button btdivisao;
        private System.Windows.Forms.Button btmultiplicação;
        private System.Windows.Forms.Button btmenos;
        private System.Windows.Forms.TextBox Txtbnumber1;
        private System.Windows.Forms.Label LBnumber1;
        private System.Windows.Forms.Label lbnumber2;
        private System.Windows.Forms.TextBox TxtBnumber2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCalcular;
    }
}

