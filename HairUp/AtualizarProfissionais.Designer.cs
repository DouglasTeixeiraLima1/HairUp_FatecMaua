namespace HairUp
{
    partial class AtualizarProfissionais
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
            this.mtbcelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btalterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcodprofissional = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atualizar Profissionais";
            // 
            // mtbcelular
            // 
            this.mtbcelular.Location = new System.Drawing.Point(247, 176);
            this.mtbcelular.Mask = "(00)00000-0000";
            this.mtbcelular.Name = "mtbcelular";
            this.mtbcelular.Size = new System.Drawing.Size(221, 33);
            this.mtbcelular.TabIndex = 5;
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(247, 118);
            this.mtbcpf.Mask = "000,000,000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(221, 33);
            this.mtbcpf.TabIndex = 4;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(247, 234);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(221, 33);
            this.txtcargo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cargo:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(247, 59);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(221, 33);
            this.txtnome.TabIndex = 3;
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Thistle;
            this.btcancelar.Location = new System.Drawing.Point(528, 225);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(128, 42);
            this.btcancelar.TabIndex = 8;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btalterar
            // 
            this.btalterar.BackColor = System.Drawing.Color.MediumPurple;
            this.btalterar.Location = new System.Drawing.Point(528, 167);
            this.btalterar.Name = "btalterar";
            this.btalterar.Size = new System.Drawing.Size(128, 42);
            this.btalterar.TabIndex = 7;
            this.btalterar.Text = "Alterar";
            this.btalterar.UseVisualStyleBackColor = false;
            this.btalterar.Click += new System.EventHandler(this.btalterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Alterar";
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(521, 30);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(135, 34);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcodprofissional
            // 
            this.txtcodprofissional.Location = new System.Drawing.Point(247, 32);
            this.txtcodprofissional.Name = "txtcodprofissional";
            this.txtcodprofissional.Size = new System.Drawing.Size(221, 33);
            this.txtcodprofissional.TabIndex = 1;
            this.txtcodprofissional.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtcodprofissional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodprofissional_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cód. Profissional:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.txtcodprofissional);
            this.grupo1.Controls.Add(this.label2);
            this.grupo1.Controls.Add(this.btpesquisar);
            this.grupo1.Location = new System.Drawing.Point(35, 37);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(703, 89);
            this.grupo1.TabIndex = 34;
            this.grupo1.TabStop = false;
            this.grupo1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.mtbcpf);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.btcancelar);
            this.grupo2.Controls.Add(this.btalterar);
            this.grupo2.Controls.Add(this.txtnome);
            this.grupo2.Controls.Add(this.txtcargo);
            this.grupo2.Controls.Add(this.mtbcelular);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Controls.Add(this.label6);
            this.grupo2.Controls.Add(this.label7);
            this.grupo2.Location = new System.Drawing.Point(35, 132);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(703, 314);
            this.grupo2.TabIndex = 35;
            this.grupo2.TabStop = false;
            this.grupo2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AtualizarProfissionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "AtualizarProfissionais";
            this.Text = "Atualizar Profissionais";
            this.Load += new System.EventHandler(this.AtualizarProfissionais_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbcelular;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btalterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtcodprofissional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
    }
}