namespace HairUp
{
    partial class ExcluirClientes
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
            this.btexcluir = new System.Windows.Forms.Button();
            this.txtcodcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbcelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnao = new System.Windows.Forms.Button();
            this.btsim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(536, 41);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(135, 33);
            this.btexcluir.TabIndex = 2;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // txtcodcliente
            // 
            this.txtcodcliente.Location = new System.Drawing.Point(249, 41);
            this.txtcodcliente.Name = "txtcodcliente";
            this.txtcodcliente.Size = new System.Drawing.Size(221, 33);
            this.txtcodcliente.TabIndex = 1;
            this.txtcodcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodcliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cód. Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Deletar Clientes";
            // 
            // mtbcelular
            // 
            this.mtbcelular.Location = new System.Drawing.Point(249, 158);
            this.mtbcelular.Mask = "(00)00000-0000";
            this.mtbcelular.Name = "mtbcelular";
            this.mtbcelular.Size = new System.Drawing.Size(221, 33);
            this.mtbcelular.TabIndex = 5;
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(249, 100);
            this.mtbcpf.Mask = "000,000,000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(221, 33);
            this.mtbcpf.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(249, 216);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(221, 33);
            this.txtemail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "e-mail:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(249, 41);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(221, 33);
            this.txtnome.TabIndex = 3;
            // 
            // btnao
            // 
            this.btnao.BackColor = System.Drawing.Color.Thistle;
            this.btnao.Location = new System.Drawing.Point(543, 207);
            this.btnao.Name = "btnao";
            this.btnao.Size = new System.Drawing.Size(128, 42);
            this.btnao.TabIndex = 8;
            this.btnao.Text = "Não";
            this.btnao.UseVisualStyleBackColor = false;
            this.btnao.Click += new System.EventHandler(this.btnao_Click);
            // 
            // btsim
            // 
            this.btsim.BackColor = System.Drawing.Color.MediumPurple;
            this.btsim.Location = new System.Drawing.Point(543, 149);
            this.btsim.Name = "btsim";
            this.btsim.Size = new System.Drawing.Size(128, 42);
            this.btsim.TabIndex = 7;
            this.btsim.Text = "Sim";
            this.btsim.UseVisualStyleBackColor = false;
            this.btsim.Click += new System.EventHandler(this.btsim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nome:";
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.txtcodcliente);
            this.grupo1.Controls.Add(this.label2);
            this.grupo1.Controls.Add(this.btexcluir);
            this.grupo1.Location = new System.Drawing.Point(33, 34);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(743, 89);
            this.grupo1.TabIndex = 27;
            this.grupo1.TabStop = false;
            this.grupo1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.txtnome);
            this.grupo2.Controls.Add(this.txtemail);
            this.grupo2.Controls.Add(this.btnao);
            this.grupo2.Controls.Add(this.label7);
            this.grupo2.Controls.Add(this.btsim);
            this.grupo2.Controls.Add(this.mtbcelular);
            this.grupo2.Controls.Add(this.mtbcpf);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Controls.Add(this.label6);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Location = new System.Drawing.Point(33, 129);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(743, 318);
            this.grupo2.TabIndex = 28;
            this.grupo2.TabStop = false;
            this.grupo2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ExcluirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupo2);
            this.Controls.Add(this.grupo1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "ExcluirClientes";
            this.Text = "Deletar Clientes";
            this.Load += new System.EventHandler(this.ExcluirClientes_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.TextBox txtcodcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbcelular;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnao;
        private System.Windows.Forms.Button btsim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
    }
}