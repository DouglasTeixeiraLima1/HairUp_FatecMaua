namespace HairUp
{
    partial class AtualizarServicos
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
            this.btcancelar = new System.Windows.Forms.Button();
            this.btalterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcodservico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtnomeservico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Atualizar Serviços";
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Thistle;
            this.btcancelar.Location = new System.Drawing.Point(581, 239);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(128, 42);
            this.btcancelar.TabIndex = 7;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btalterar
            // 
            this.btalterar.BackColor = System.Drawing.Color.MediumPurple;
            this.btalterar.Location = new System.Drawing.Point(581, 194);
            this.btalterar.Name = "btalterar";
            this.btalterar.Size = new System.Drawing.Size(128, 42);
            this.btalterar.TabIndex = 6;
            this.btalterar.Text = "Alterar";
            this.btalterar.UseVisualStyleBackColor = false;
            this.btalterar.Click += new System.EventHandler(this.btalterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Alterar";
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(574, 24);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(135, 33);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtcodservico
            // 
            this.txtcodservico.Location = new System.Drawing.Point(270, 21);
            this.txtcodservico.Name = "txtcodservico";
            this.txtcodservico.Size = new System.Drawing.Size(267, 33);
            this.txtcodservico.TabIndex = 1;
            this.txtcodservico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodservico_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cód. Serviço:";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(270, 248);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(267, 33);
            this.txtpreco.TabIndex = 5;
            this.txtpreco.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(270, 114);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(267, 125);
            this.txtdescricao.TabIndex = 4;
            this.txtdescricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtnomeservico
            // 
            this.txtnomeservico.Location = new System.Drawing.Point(270, 64);
            this.txtnomeservico.Name = "txtnomeservico";
            this.txtnomeservico.Size = new System.Drawing.Size(267, 33);
            this.txtnomeservico.TabIndex = 3;
            this.txtnomeservico.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nome do Serviço:";
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.txtcodservico);
            this.grupo1.Controls.Add(this.label2);
            this.grupo1.Controls.Add(this.btpesquisar);
            this.grupo1.Location = new System.Drawing.Point(12, 51);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(765, 66);
            this.grupo1.TabIndex = 32;
            this.grupo1.TabStop = false;
            this.grupo1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.txtdescricao);
            this.grupo2.Controls.Add(this.txtnomeservico);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.btcancelar);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.txtpreco);
            this.grupo2.Controls.Add(this.btalterar);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Controls.Add(this.label6);
            this.grupo2.Location = new System.Drawing.Point(12, 123);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(765, 315);
            this.grupo2.TabIndex = 33;
            this.grupo2.TabStop = false;
            this.grupo2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AtualizarServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "AtualizarServicos";
            this.Text = "Atualizar Servicos";
            this.Load += new System.EventHandler(this.AtualizarServicos_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btalterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtcodservico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtnomeservico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
    }
}