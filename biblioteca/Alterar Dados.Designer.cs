namespace biblioteca
{
    partial class Alterar_Dados
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
            this.BtAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeAlterar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAutorAlterar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mkt_ano = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtAlterar
            // 
            this.BtAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAlterar.Location = new System.Drawing.Point(149, 168);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(133, 32);
            this.BtAlterar.TabIndex = 0;
            this.BtAlterar.Text = "Alterar";
            this.BtAlterar.UseVisualStyleBackColor = true;
            this.BtAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alterar Nome";
            // 
            // TxtNomeAlterar
            // 
            this.TxtNomeAlterar.Location = new System.Drawing.Point(149, 62);
            this.TxtNomeAlterar.Name = "TxtNomeAlterar";
            this.TxtNomeAlterar.Size = new System.Drawing.Size(221, 24);
            this.TxtNomeAlterar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alterar Autor";
            // 
            // TxtAutorAlterar
            // 
            this.TxtAutorAlterar.Location = new System.Drawing.Point(149, 89);
            this.TxtAutorAlterar.Name = "TxtAutorAlterar";
            this.TxtAutorAlterar.Size = new System.Drawing.Size(221, 24);
            this.TxtAutorAlterar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alterar Ano";
            // 
            // mkt_ano
            // 
            this.mkt_ano.Location = new System.Drawing.Point(149, 119);
            this.mkt_ano.Mask = "00/00/0000";
            this.mkt_ano.Name = "mkt_ano";
            this.mkt_ano.Size = new System.Drawing.Size(100, 24);
            this.mkt_ano.TabIndex = 7;
            this.mkt_ano.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mkt_ano);
            this.groupBox1.Controls.Add(this.BtAlterar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNomeAlterar);
            this.groupBox1.Controls.Add(this.TxtAutorAlterar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 279);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altera dados do livro";
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.ForeColor = System.Drawing.Color.Green;
            this.lbS.Location = new System.Drawing.Point(6, 247);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(42, 16);
            this.lbS.TabIndex = 8;
            this.lbS.Text = "label";
            this.lbS.Visible = false;
            // 
            // Alterar_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 303);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alterar_Dados";
            this.Text = "Alterar_Dados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAutorAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mkt_ano;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbS;
    }
}