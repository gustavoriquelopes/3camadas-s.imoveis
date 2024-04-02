namespace Proj_3_Camadas_Imovel
{
    partial class Frmmenu
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
            this.btnAluguel = new System.Windows.Forms.Button();
            this.lblAnotacao = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnImovel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAluguel
            // 
            this.btnAluguel.BackColor = System.Drawing.Color.Gold;
            this.btnAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluguel.Location = new System.Drawing.Point(300, 11);
            this.btnAluguel.Name = "btnAluguel";
            this.btnAluguel.Size = new System.Drawing.Size(146, 48);
            this.btnAluguel.TabIndex = 19;
            this.btnAluguel.Text = "Cadastrar Alugueis";
            this.btnAluguel.UseVisualStyleBackColor = false;
            this.btnAluguel.Click += new System.EventHandler(this.btnAluguel_Click);
            // 
            // lblAnotacao
            // 
            this.lblAnotacao.Font = new System.Drawing.Font("Raleway Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotacao.Location = new System.Drawing.Point(6, 16);
            this.lblAnotacao.Name = "lblAnotacao";
            this.lblAnotacao.Size = new System.Drawing.Size(155, 39);
            this.lblAnotacao.TabIndex = 18;
            this.lblAnotacao.Text = "ImóvelFlex";
            this.lblAnotacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Salmon;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(25, 369);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(215, 57);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Orange;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(612, 11);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(146, 48);
            this.btnCliente.TabIndex = 16;
            this.btnCliente.Text = "Cadastrar clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnImovel
            // 
            this.btnImovel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnImovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImovel.Location = new System.Drawing.Point(469, 15);
            this.btnImovel.Name = "btnImovel";
            this.btnImovel.Size = new System.Drawing.Size(137, 40);
            this.btnImovel.TabIndex = 15;
            this.btnImovel.Text = "Cadastrar imovel";
            this.btnImovel.UseVisualStyleBackColor = false;
            this.btnImovel.Click += new System.EventHandler(this.btnImovel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAluguel);
            this.groupBox1.Controls.Add(this.lblAnotacao);
            this.groupBox1.Controls.Add(this.btnImovel);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 65);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Barlow Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fernanda e Pedro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Name = "Frmmenu";
            this.Text = "Frmmenu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAluguel;
        private System.Windows.Forms.Label lblAnotacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnImovel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}