namespace HairUp
{
    partial class CadastrarAgenda
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
            this.label5 = new System.Windows.Forms.Label();
            this.mtbagenda = new System.Windows.Forms.MaskedTextBox();
            this.mtbhora = new System.Windows.Forms.MaskedTextBox();
            this.cboboxcodcliente = new System.Windows.Forms.ComboBox();
            this.cboboxcodprofissional = new System.Windows.Forms.ComboBox();
            this.cboboxcodservico = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblcodcliente = new System.Windows.Forms.Label();
            this.lblcodprofissional = new System.Windows.Forms.Label();
            this.lblcodservico = new System.Windows.Forms.Label();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cód. Profissional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cód. Serviço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data da agenda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora:";
            // 
            // mtbagenda
            // 
            this.mtbagenda.Location = new System.Drawing.Point(283, 301);
            this.mtbagenda.Mask = "00/00/0000";
            this.mtbagenda.Name = "mtbagenda";
            this.mtbagenda.Size = new System.Drawing.Size(200, 33);
            this.mtbagenda.TabIndex = 4;
            this.mtbagenda.ValidatingType = typeof(System.DateTime);
            // 
            // mtbhora
            // 
            this.mtbhora.Location = new System.Drawing.Point(283, 376);
            this.mtbhora.Mask = "90:00";
            this.mtbhora.Name = "mtbhora";
            this.mtbhora.Size = new System.Drawing.Size(200, 33);
            this.mtbhora.TabIndex = 5;
            this.mtbhora.ValidatingType = typeof(System.DateTime);
            // 
            // cboboxcodcliente
            // 
            this.cboboxcodcliente.FormattingEnabled = true;
            this.cboboxcodcliente.Location = new System.Drawing.Point(283, 86);
            this.cboboxcodcliente.Name = "cboboxcodcliente";
            this.cboboxcodcliente.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodcliente.TabIndex = 1;
            this.cboboxcodcliente.SelectedIndexChanged += new System.EventHandler(this.cboboxcodcliente_SelectedIndexChanged);
            // 
            // cboboxcodprofissional
            // 
            this.cboboxcodprofissional.FormattingEnabled = true;
            this.cboboxcodprofissional.Location = new System.Drawing.Point(283, 160);
            this.cboboxcodprofissional.Name = "cboboxcodprofissional";
            this.cboboxcodprofissional.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodprofissional.TabIndex = 2;
            this.cboboxcodprofissional.SelectedIndexChanged += new System.EventHandler(this.cboboxcodprofissional_SelectedIndexChanged);
            // 
            // cboboxcodservico
            // 
            this.cboboxcodservico.FormattingEnabled = true;
            this.cboboxcodservico.Location = new System.Drawing.Point(283, 230);
            this.cboboxcodservico.Name = "cboboxcodservico";
            this.cboboxcodservico.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodservico.TabIndex = 3;
            this.cboboxcodservico.SelectedIndexChanged += new System.EventHandler(this.cboboxcodservico_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cadastrar Na Agenda";
            // 
            // lblcodcliente
            // 
            this.lblcodcliente.AutoSize = true;
            this.lblcodcliente.Location = new System.Drawing.Point(6, 18);
            this.lblcodcliente.Name = "lblcodcliente";
            this.lblcodcliente.Size = new System.Drawing.Size(36, 25);
            this.lblcodcliente.TabIndex = 15;
            this.lblcodcliente.Text = "...";
            this.lblcodcliente.Click += new System.EventHandler(this.lblcodcliente_Click);
            // 
            // lblcodprofissional
            // 
            this.lblcodprofissional.AutoSize = true;
            this.lblcodprofissional.Location = new System.Drawing.Point(6, 16);
            this.lblcodprofissional.Name = "lblcodprofissional";
            this.lblcodprofissional.Size = new System.Drawing.Size(36, 25);
            this.lblcodprofissional.TabIndex = 16;
            this.lblcodprofissional.Text = "...";
            // 
            // lblcodservico
            // 
            this.lblcodservico.AutoSize = true;
            this.lblcodservico.Location = new System.Drawing.Point(6, 18);
            this.lblcodservico.Name = "lblcodservico";
            this.lblcodservico.Size = new System.Drawing.Size(36, 25);
            this.lblcodservico.TabIndex = 17;
            this.lblcodservico.Text = "...";
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.MediumPurple;
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btcancelar.Location = new System.Drawing.Point(522, 361);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(130, 48);
            this.btcancelar.TabIndex = 7;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.SlateBlue;
            this.btcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btcadastrar.Location = new System.Drawing.Point(522, 286);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(130, 48);
            this.btcadastrar.TabIndex = 6;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcodcliente);
            this.groupBox1.Location = new System.Drawing.Point(522, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 46);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcodprofissional);
            this.groupBox2.Location = new System.Drawing.Point(522, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 46);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblcodservico);
            this.groupBox3.Location = new System.Drawing.Point(522, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 46);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // CadastrarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboboxcodservico);
            this.Controls.Add(this.cboboxcodprofissional);
            this.Controls.Add(this.cboboxcodcliente);
            this.Controls.Add(this.mtbhora);
            this.Controls.Add(this.mtbagenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "CadastrarAgenda";
            this.Text = "Cadastrar na Agenda";
            this.Load += new System.EventHandler(this.CadastrarAgenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbagenda;
        private System.Windows.Forms.MaskedTextBox mtbhora;
        private System.Windows.Forms.ComboBox cboboxcodcliente;
        private System.Windows.Forms.ComboBox cboboxcodprofissional;
        private System.Windows.Forms.ComboBox cboboxcodservico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblcodcliente;
        private System.Windows.Forms.Label lblcodprofissional;
        private System.Windows.Forms.Label lblcodservico;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}