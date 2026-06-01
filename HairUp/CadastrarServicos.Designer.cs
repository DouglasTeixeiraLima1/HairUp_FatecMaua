namespace HairUp
{
    partial class CadastrarServicos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtservico = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastrar Serviços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome do Serviço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descrição:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Preço:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtservico
            // 
            this.txtservico.Location = new System.Drawing.Point(273, 83);
            this.txtservico.Name = "txtservico";
            this.txtservico.Size = new System.Drawing.Size(267, 33);
            this.txtservico.TabIndex = 1;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(273, 156);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(267, 125);
            this.txtdescricao.TabIndex = 2;
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.MediumPurple;
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btcancelar.Location = new System.Drawing.Point(658, 390);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(130, 48);
            this.btcancelar.TabIndex = 5;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.SlateBlue;
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btcadastrar.Location = new System.Drawing.Point(505, 390);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(130, 48);
            this.btcadastrar.TabIndex = 4;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(273, 324);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(267, 33);
            this.txtpreco.TabIndex = 3;
            this.txtpreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreco_KeyPress);
            // 
            // CadastrarServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtservico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "CadastrarServicos";
            this.Text = "Cadastrar Servicos";
            this.Load += new System.EventHandler(this.CadastrarServicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtservico;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.TextBox txtpreco;
    }
}