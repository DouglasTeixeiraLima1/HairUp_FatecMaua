namespace HairUp
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionaisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionaisToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionaisToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HairUp.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(48, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 26);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarToolStripMenuItem});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarToolStripMenuItem});
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.profissionaisToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // profissionaisToolStripMenuItem
            // 
            this.profissionaisToolStripMenuItem.Name = "profissionaisToolStripMenuItem";
            this.profissionaisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profissionaisToolStripMenuItem.Text = "Profissionais";
            this.profissionaisToolStripMenuItem.Click += new System.EventHandler(this.profissionaisToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem1,
            this.clientesToolStripMenuItem1,
            this.profissionaisToolStripMenuItem1,
            this.serviçosToolStripMenuItem1});
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alterarToolStripMenuItem.Text = "Alterar";
            // 
            // agendaToolStripMenuItem1
            // 
            this.agendaToolStripMenuItem1.Name = "agendaToolStripMenuItem1";
            this.agendaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.agendaToolStripMenuItem1.Text = "Agenda";
            this.agendaToolStripMenuItem1.Click += new System.EventHandler(this.agendaToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // profissionaisToolStripMenuItem1
            // 
            this.profissionaisToolStripMenuItem1.Name = "profissionaisToolStripMenuItem1";
            this.profissionaisToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.profissionaisToolStripMenuItem1.Text = "Profissionais";
            this.profissionaisToolStripMenuItem1.Click += new System.EventHandler(this.profissionaisToolStripMenuItem1_Click);
            // 
            // serviçosToolStripMenuItem1
            // 
            this.serviçosToolStripMenuItem1.Name = "serviçosToolStripMenuItem1";
            this.serviçosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.serviçosToolStripMenuItem1.Text = "Serviços";
            this.serviçosToolStripMenuItem1.Click += new System.EventHandler(this.serviçosToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem2,
            this.clientesToolStripMenuItem2,
            this.profissionaisToolStripMenuItem2,
            this.serviçosToolStripMenuItem2});
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // agendaToolStripMenuItem2
            // 
            this.agendaToolStripMenuItem2.Name = "agendaToolStripMenuItem2";
            this.agendaToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.agendaToolStripMenuItem2.Text = "Agenda";
            this.agendaToolStripMenuItem2.Click += new System.EventHandler(this.agendaToolStripMenuItem2_Click);
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem2.Text = "Clientes";
            this.clientesToolStripMenuItem2.Click += new System.EventHandler(this.clientesToolStripMenuItem2_Click);
            // 
            // profissionaisToolStripMenuItem2
            // 
            this.profissionaisToolStripMenuItem2.Name = "profissionaisToolStripMenuItem2";
            this.profissionaisToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.profissionaisToolStripMenuItem2.Text = "Profissionais";
            this.profissionaisToolStripMenuItem2.Click += new System.EventHandler(this.profissionaisToolStripMenuItem2_Click);
            // 
            // serviçosToolStripMenuItem2
            // 
            this.serviçosToolStripMenuItem2.Name = "serviçosToolStripMenuItem2";
            this.serviçosToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.serviçosToolStripMenuItem2.Text = "Serviços";
            this.serviçosToolStripMenuItem2.Click += new System.EventHandler(this.serviçosToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem3,
            this.clientesToolStripMenuItem3,
            this.profissionaisToolStripMenuItem3,
            this.serviçosToolStripMenuItem3});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // agendaToolStripMenuItem3
            // 
            this.agendaToolStripMenuItem3.Name = "agendaToolStripMenuItem3";
            this.agendaToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.agendaToolStripMenuItem3.Text = "Agenda";
            this.agendaToolStripMenuItem3.Click += new System.EventHandler(this.agendaToolStripMenuItem3_Click);
            // 
            // clientesToolStripMenuItem3
            // 
            this.clientesToolStripMenuItem3.Name = "clientesToolStripMenuItem3";
            this.clientesToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem3.Text = "Clientes";
            this.clientesToolStripMenuItem3.Click += new System.EventHandler(this.clientesToolStripMenuItem3_Click);
            // 
            // profissionaisToolStripMenuItem3
            // 
            this.profissionaisToolStripMenuItem3.Name = "profissionaisToolStripMenuItem3";
            this.profissionaisToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.profissionaisToolStripMenuItem3.Text = "Profissionais";
            this.profissionaisToolStripMenuItem3.Click += new System.EventHandler(this.profissionaisToolStripMenuItem3_Click);
            // 
            // serviçosToolStripMenuItem3
            // 
            this.serviçosToolStripMenuItem3.Name = "serviçosToolStripMenuItem3";
            this.serviçosToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.serviçosToolStripMenuItem3.Text = "Serviços";
            this.serviçosToolStripMenuItem3.Click += new System.EventHandler(this.serviçosToolStripMenuItem3_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Orchid;
            this.label1.Location = new System.Drawing.Point(156, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu ERP - Salão de Beleza Feminino";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "HairUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profissionaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profissionaisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem profissionaisToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem profissionaisToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem3;
        private System.Windows.Forms.Label label1;
    }
}