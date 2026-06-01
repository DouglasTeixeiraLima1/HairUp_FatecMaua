namespace HairUp
{
    partial class AtualizarAgenda
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
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcodagenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboboxcodservico = new System.Windows.Forms.ComboBox();
            this.cboboxcodprofissional = new System.Windows.Forms.ComboBox();
            this.cboboxcodcliente = new System.Windows.Forms.ComboBox();
            this.mtbhora = new System.Windows.Forms.MaskedTextBox();
            this.mtbdateagenda = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btalterar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.lblcodprofissional = new System.Windows.Forms.Label();
            this.lblcodservico = new System.Windows.Forms.Label();
            this.lblcodcliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(560, 23);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(135, 34);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtcodagenda
            // 
            this.txtcodagenda.Location = new System.Drawing.Point(312, 24);
            this.txtcodagenda.Name = "txtcodagenda";
            this.txtcodagenda.Size = new System.Drawing.Size(200, 33);
            this.txtcodagenda.TabIndex = 1;
            this.txtcodagenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodagenda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cód. Agenda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Atualizar Agenda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Alterar";
            // 
            // cboboxcodservico
            // 
            this.cboboxcodservico.FormattingEnabled = true;
            this.cboboxcodservico.Location = new System.Drawing.Point(312, 160);
            this.cboboxcodservico.Name = "cboboxcodservico";
            this.cboboxcodservico.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodservico.TabIndex = 5;
            this.cboboxcodservico.SelectedIndexChanged += new System.EventHandler(this.cboboxcodservico_SelectedIndexChanged);
            // 
            // cboboxcodprofissional
            // 
            this.cboboxcodprofissional.FormattingEnabled = true;
            this.cboboxcodprofissional.Location = new System.Drawing.Point(312, 109);
            this.cboboxcodprofissional.Name = "cboboxcodprofissional";
            this.cboboxcodprofissional.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodprofissional.TabIndex = 4;
            this.cboboxcodprofissional.SelectedIndexChanged += new System.EventHandler(this.cboboxcodprofissional_SelectedIndexChanged);
            // 
            // cboboxcodcliente
            // 
            this.cboboxcodcliente.FormattingEnabled = true;
            this.cboboxcodcliente.Location = new System.Drawing.Point(312, 57);
            this.cboboxcodcliente.Name = "cboboxcodcliente";
            this.cboboxcodcliente.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodcliente.TabIndex = 3;
            this.cboboxcodcliente.SelectedIndexChanged += new System.EventHandler(this.cboboxcodcliente_SelectedIndexChanged);
            // 
            // mtbhora
            // 
            this.mtbhora.Location = new System.Drawing.Point(312, 263);
            this.mtbhora.Mask = "90:00";
            this.mtbhora.Name = "mtbhora";
            this.mtbhora.Size = new System.Drawing.Size(200, 33);
            this.mtbhora.TabIndex = 7;
            this.mtbhora.ValidatingType = typeof(System.DateTime);
            // 
            // mtbdateagenda
            // 
            this.mtbdateagenda.Location = new System.Drawing.Point(312, 210);
            this.mtbdateagenda.Mask = "00/00/0000";
            this.mtbdateagenda.Name = "mtbdateagenda";
            this.mtbdateagenda.Size = new System.Drawing.Size(200, 33);
            this.mtbdateagenda.TabIndex = 6;
            this.mtbdateagenda.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Data da agenda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cód. Serviço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cód. Profissional:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "Cód. Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 40;
            this.label11.Text = "Hora:";
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Thistle;
            this.btcancelar.Location = new System.Drawing.Point(560, 254);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(128, 42);
            this.btcancelar.TabIndex = 9;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btalterar
            // 
            this.btalterar.BackColor = System.Drawing.Color.MediumPurple;
            this.btalterar.Location = new System.Drawing.Point(560, 201);
            this.btalterar.Name = "btalterar";
            this.btalterar.Size = new System.Drawing.Size(128, 42);
            this.btalterar.TabIndex = 8;
            this.btalterar.Text = "Alterar";
            this.btalterar.UseVisualStyleBackColor = false;
            this.btalterar.Click += new System.EventHandler(this.btalterar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcodprofissional);
            this.groupBox2.Location = new System.Drawing.Point(560, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 46);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblcodservico);
            this.groupBox3.Location = new System.Drawing.Point(560, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 46);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.txtcodagenda);
            this.grupo1.Controls.Add(this.label2);
            this.grupo1.Controls.Add(this.btpesquisar);
            this.grupo1.Location = new System.Drawing.Point(24, 37);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(764, 73);
            this.grupo1.TabIndex = 42;
            this.grupo1.TabStop = false;
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.cboboxcodcliente);
            this.grupo2.Controls.Add(this.label10);
            this.grupo2.Controls.Add(this.label6);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.label11);
            this.grupo2.Controls.Add(this.cboboxcodprofissional);
            this.grupo2.Controls.Add(this.cboboxcodservico);
            this.grupo2.Controls.Add(this.mtbdateagenda);
            this.grupo2.Controls.Add(this.mtbhora);
            this.grupo2.Controls.Add(this.btcancelar);
            this.grupo2.Controls.Add(this.groupBox1);
            this.grupo2.Controls.Add(this.btalterar);
            this.grupo2.Controls.Add(this.groupBox2);
            this.grupo2.Controls.Add(this.groupBox3);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Location = new System.Drawing.Point(24, 113);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(764, 325);
            this.grupo2.TabIndex = 43;
            this.grupo2.TabStop = false;
            // 
            // lblcodprofissional
            // 
            this.lblcodprofissional.AutoSize = true;
            this.lblcodprofissional.Location = new System.Drawing.Point(6, 18);
            this.lblcodprofissional.Name = "lblcodprofissional";
            this.lblcodprofissional.Size = new System.Drawing.Size(36, 25);
            this.lblcodprofissional.TabIndex = 42;
            this.lblcodprofissional.Text = "...";
            // 
            // lblcodservico
            // 
            this.lblcodservico.AutoSize = true;
            this.lblcodservico.Location = new System.Drawing.Point(6, 18);
            this.lblcodservico.Name = "lblcodservico";
            this.lblcodservico.Size = new System.Drawing.Size(36, 25);
            this.lblcodservico.TabIndex = 0;
            this.lblcodservico.Text = "...";
            // 
            // lblcodcliente
            // 
            this.lblcodcliente.AutoSize = true;
            this.lblcodcliente.Location = new System.Drawing.Point(6, 18);
            this.lblcodcliente.Name = "lblcodcliente";
            this.lblcodcliente.Size = new System.Drawing.Size(36, 25);
            this.lblcodcliente.TabIndex = 15;
            this.lblcodcliente.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcodcliente);
            this.groupBox1.Location = new System.Drawing.Point(560, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 46);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // AtualizarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grupo2);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "AtualizarAgenda";
            this.Text = "Atualizar Agenda";
            this.Load += new System.EventHandler(this.AtualizarAgenda_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtcodagenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboboxcodservico;
        private System.Windows.Forms.ComboBox cboboxcodprofissional;
        private System.Windows.Forms.ComboBox cboboxcodcliente;
        private System.Windows.Forms.MaskedTextBox mtbhora;
        private System.Windows.Forms.MaskedTextBox mtbdateagenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btalterar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
        private System.Windows.Forms.Label lblcodprofissional;
        private System.Windows.Forms.Label lblcodservico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcodcliente;
    }
}