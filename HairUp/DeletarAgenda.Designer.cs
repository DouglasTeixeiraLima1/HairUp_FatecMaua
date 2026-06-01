namespace HairUp
{
    partial class DeletarAgenda
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
            this.btexcluir = new System.Windows.Forms.Button();
            this.txtcodagenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboboxcodservico = new System.Windows.Forms.ComboBox();
            this.cboboxcodprofissional = new System.Windows.Forms.ComboBox();
            this.cboboxcodcliente = new System.Windows.Forms.ComboBox();
            this.mtbhora = new System.Windows.Forms.MaskedTextBox();
            this.mtbdateagenda = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnao = new System.Windows.Forms.Button();
            this.btsim = new System.Windows.Forms.Button();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.grupo2 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblcodcliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcodprofissional = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblcodservico = new System.Windows.Forms.Label();
            this.grupo1.SuspendLayout();
            this.grupo2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Deletar Agenda";
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(534, 23);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(138, 33);
            this.btexcluir.TabIndex = 2;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // txtcodagenda
            // 
            this.txtcodagenda.Location = new System.Drawing.Point(313, 24);
            this.txtcodagenda.Name = "txtcodagenda";
            this.txtcodagenda.Size = new System.Drawing.Size(200, 33);
            this.txtcodagenda.TabIndex = 1;
            this.txtcodagenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodagenda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cód. Agenda:";
            // 
            // cboboxcodservico
            // 
            this.cboboxcodservico.FormattingEnabled = true;
            this.cboboxcodservico.Location = new System.Drawing.Point(313, 147);
            this.cboboxcodservico.Name = "cboboxcodservico";
            this.cboboxcodservico.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodservico.TabIndex = 5;
            // 
            // cboboxcodprofissional
            // 
            this.cboboxcodprofissional.FormattingEnabled = true;
            this.cboboxcodprofissional.Location = new System.Drawing.Point(313, 98);
            this.cboboxcodprofissional.Name = "cboboxcodprofissional";
            this.cboboxcodprofissional.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodprofissional.TabIndex = 4;
            // 
            // cboboxcodcliente
            // 
            this.cboboxcodcliente.FormattingEnabled = true;
            this.cboboxcodcliente.Location = new System.Drawing.Point(313, 50);
            this.cboboxcodcliente.Name = "cboboxcodcliente";
            this.cboboxcodcliente.Size = new System.Drawing.Size(200, 33);
            this.cboboxcodcliente.TabIndex = 3;
            // 
            // mtbhora
            // 
            this.mtbhora.Location = new System.Drawing.Point(313, 250);
            this.mtbhora.Mask = "90:00";
            this.mtbhora.Name = "mtbhora";
            this.mtbhora.Size = new System.Drawing.Size(200, 33);
            this.mtbhora.TabIndex = 7;
            this.mtbhora.ValidatingType = typeof(System.DateTime);
            // 
            // mtbdateagenda
            // 
            this.mtbdateagenda.Location = new System.Drawing.Point(313, 198);
            this.mtbdateagenda.Mask = "00/00/0000";
            this.mtbdateagenda.Name = "mtbdateagenda";
            this.mtbdateagenda.Size = new System.Drawing.Size(200, 33);
            this.mtbdateagenda.TabIndex = 6;
            this.mtbdateagenda.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data da agenda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cód. Serviço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cód. Profissional:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cód. Cliente:";
            // 
            // btnao
            // 
            this.btnao.BackColor = System.Drawing.Color.Thistle;
            this.btnao.Location = new System.Drawing.Point(534, 241);
            this.btnao.Name = "btnao";
            this.btnao.Size = new System.Drawing.Size(128, 42);
            this.btnao.TabIndex = 9;
            this.btnao.Text = "Não";
            this.btnao.UseVisualStyleBackColor = false;
            this.btnao.Click += new System.EventHandler(this.btnao_Click);
            // 
            // btsim
            // 
            this.btsim.BackColor = System.Drawing.Color.MediumPurple;
            this.btsim.Location = new System.Drawing.Point(534, 189);
            this.btsim.Name = "btsim";
            this.btsim.Size = new System.Drawing.Size(128, 42);
            this.btsim.TabIndex = 8;
            this.btsim.Text = "Sim";
            this.btsim.UseVisualStyleBackColor = false;
            this.btsim.Click += new System.EventHandler(this.btsim_Click);
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.btexcluir);
            this.grupo1.Controls.Add(this.label2);
            this.grupo1.Controls.Add(this.txtcodagenda);
            this.grupo1.Location = new System.Drawing.Point(27, 37);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(718, 72);
            this.grupo1.TabIndex = 44;
            this.grupo1.TabStop = false;
            // 
            // grupo2
            // 
            this.grupo2.Controls.Add(this.groupBox2);
            this.grupo2.Controls.Add(this.groupBox1);
            this.grupo2.Controls.Add(this.groupBox3);
            this.grupo2.Controls.Add(this.btsim);
            this.grupo2.Controls.Add(this.label5);
            this.grupo2.Controls.Add(this.btnao);
            this.grupo2.Controls.Add(this.label4);
            this.grupo2.Controls.Add(this.cboboxcodservico);
            this.grupo2.Controls.Add(this.label3);
            this.grupo2.Controls.Add(this.label6);
            this.grupo2.Controls.Add(this.label10);
            this.grupo2.Controls.Add(this.cboboxcodprofissional);
            this.grupo2.Controls.Add(this.cboboxcodcliente);
            this.grupo2.Controls.Add(this.mtbhora);
            this.grupo2.Controls.Add(this.mtbdateagenda);
            this.grupo2.Location = new System.Drawing.Point(27, 115);
            this.grupo2.Name = "grupo2";
            this.grupo2.Size = new System.Drawing.Size(718, 323);
            this.grupo2.TabIndex = 45;
            this.grupo2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcodcliente);
            this.groupBox2.Location = new System.Drawing.Point(534, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(77, 47);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // lblcodcliente
            // 
            this.lblcodcliente.AutoSize = true;
            this.lblcodcliente.Location = new System.Drawing.Point(5, 19);
            this.lblcodcliente.Name = "lblcodcliente";
            this.lblcodcliente.Size = new System.Drawing.Size(36, 25);
            this.lblcodcliente.TabIndex = 41;
            this.lblcodcliente.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcodprofissional);
            this.groupBox1.Location = new System.Drawing.Point(534, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(77, 47);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // lblcodprofissional
            // 
            this.lblcodprofissional.AutoSize = true;
            this.lblcodprofissional.Location = new System.Drawing.Point(5, 19);
            this.lblcodprofissional.Name = "lblcodprofissional";
            this.lblcodprofissional.Size = new System.Drawing.Size(36, 25);
            this.lblcodprofissional.TabIndex = 41;
            this.lblcodprofissional.Text = "...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblcodservico);
            this.groupBox3.Location = new System.Drawing.Point(534, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(77, 47);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // lblcodservico
            // 
            this.lblcodservico.AutoSize = true;
            this.lblcodservico.Location = new System.Drawing.Point(5, 19);
            this.lblcodservico.Name = "lblcodservico";
            this.lblcodservico.Size = new System.Drawing.Size(36, 25);
            this.lblcodservico.TabIndex = 41;
            this.lblcodservico.Text = "...";
            // 
            // DeletarAgenda
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
            this.Name = "DeletarAgenda";
            this.Text = "Deletar Agenda";
            this.Load += new System.EventHandler(this.DeletarAgenda_Load);
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.grupo2.ResumeLayout(false);
            this.grupo2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.TextBox txtcodagenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboboxcodservico;
        private System.Windows.Forms.ComboBox cboboxcodprofissional;
        private System.Windows.Forms.ComboBox cboboxcodcliente;
        private System.Windows.Forms.MaskedTextBox mtbhora;
        private System.Windows.Forms.MaskedTextBox mtbdateagenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnao;
        private System.Windows.Forms.Button btsim;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox grupo2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblcodcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcodprofissional;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblcodservico;
    }
}