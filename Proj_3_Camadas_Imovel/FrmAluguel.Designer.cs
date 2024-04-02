namespace Proj_3_Camadas_Imovel
{
    partial class FrmAluguel
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
            this.bntListar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDimovel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgImovel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImovel)).BeginInit();
            this.SuspendLayout();
            // 
            // bntListar
            // 
            this.bntListar.Location = new System.Drawing.Point(31, 319);
            this.bntListar.Name = "bntListar";
            this.bntListar.Size = new System.Drawing.Size(75, 23);
            this.bntListar.TabIndex = 68;
            this.bntListar.Text = "Listar";
            this.bntListar.UseVisualStyleBackColor = true;
            this.bntListar.Click += new System.EventHandler(this.bntListar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(430, 319);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 67;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(129, 319);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 66;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(225, 319);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 65;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(328, 319);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 64;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(107, 259);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "ID do Cliente:";
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(107, 214);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDcliente.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "ID do Imovel:";
            // 
            // txtIDimovel
            // 
            this.txtIDimovel.Location = new System.Drawing.Point(107, 167);
            this.txtIDimovel.Name = "txtIDimovel";
            this.txtIDimovel.Size = new System.Drawing.Size(100, 20);
            this.txtIDimovel.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "ID:";
            // 
            // dtgImovel
            // 
            this.dtgImovel.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dtgImovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImovel.Location = new System.Drawing.Point(393, 79);
            this.dtgImovel.Name = "dtgImovel";
            this.dtgImovel.Size = new System.Drawing.Size(395, 217);
            this.dtgImovel.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Cadastro de Aluguel";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(107, 125);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 54;
            // 
            // FrmAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntListar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDimovel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgImovel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "FrmAluguel";
            this.Text = "FrmAluguel";
            ((System.ComponentModel.ISupportInitialize)(this.dtgImovel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntListar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDimovel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgImovel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
    }
}