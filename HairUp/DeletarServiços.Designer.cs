namespace HairUp
{
    partial class DeletarServiços
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
            this.btnao = new System.Windows.Forms.Button();
            this.btsim = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.txtcodservico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtnomeservico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Deletar Serviços";
            // 
            // btnao
            // 
            this.btnao.BackColor = System.Drawing.Color.Thistle;
            this.btnao.Location = new System.Drawing.Point(557, 232);
            this.btnao.Name = "btnao";
            this.btnao.Size = new System.Drawing.Size(128, 42);
            this.btnao.TabIndex = 7;
            this.btnao.Text = "Não";
            this.btnao.UseVisualStyleBackColor = false;
            this.btnao.Click += new System.EventHandler(this.btnao_Click);
            // 
            // btsim
            // 
            this.btsim.BackColor = System.Drawing.Color.MediumPurple;
            this.btsim.Location = new System.Drawing.Point(557, 184);
            this.btsim.Name = "btsim";
            this.btsim.Size = new System.Drawing.Size(128, 42);
            this.btsim.TabIndex = 6;
            this.btsim.Text = "Sim";
            this.btsim.UseVisualStyleBackColor = false;
            this.btsim.Click += new System.EventHandler(this.btsim_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(550, 28);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(135, 33);
            this.btexcluir.TabIndex = 2;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // txtcodservico
            // 
            this.txtcodservico.Location = new System.Drawing.Point(267, 28);
            this.txtcodservico.Name = "txtcodservico";
            this.txtcodservico.Size = new System.Drawing.Size(267, 33);
            this.txtcodservico.TabIndex = 1;
            this.txtcodservico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodservico_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cód. Serviço:";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(267, 241);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(267, 33);
            this.txtpreco.TabIndex = 5;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(267, 101);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(267, 125);
            this.txtdescricao.TabIndex = 4;
            // 
            // txtnomeservico
            // 
            this.txtnomeservico.Location = new System.Drawing.Point(267, 47);
            this.txtnomeservico.Name = "txtnomeservico";
            this.txtnomeservico.Size = new System.Drawing.Size(267, 33);
            this.txtnomeservico.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Preço:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Descrição:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nome do Serviço:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.txtcodservico);
            this.grupo1.Controls.Add(this.label2);
            this.grupo1.Controls.Add(this.btexcluir);
            this.grupo1.Location = new System.Drawing.Point(41, 44);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(723, 71);
            this.grupo1.TabIndex = 44;
            this.grupo1.TabStop = false;
            this.grupo1.Enter += new System.EventHandler(this.grupo1_Enter);
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.txtpreco);
            this.grupo2.Controls.Add(this.txtdescricao);
            this.grupo2.Controls.Add(this.btnao);
            this.grupo2.Controls.Add(this.btsim);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.txtnomeservico);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Location = new System.Drawing.Point(41, 121);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(723, 317);
            this.grupo2.TabIndex = 45;
            this.grupo2.TabStop = false;
            this.grupo2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DeletarServiços
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
            this.Name = "DeletarServiços";
            this.Text = "Deletar Serviços";
            this.Load += new System.EventHandler(this.DeletarServiços_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnao;
        private System.Windows.Forms.Button btsim;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.TextBox txtcodservico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtnomeservico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
    }
}