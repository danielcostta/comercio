namespace Comercio.WindowsForms.Formularios
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciadorDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciadorDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciadorDeTipoDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciadorDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciadorDeEntregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciadorDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciadorDeVendedoresToolStripMenuItem,
            this.gerenciadorDeMarcasToolStripMenuItem,
            this.gerenciadorDeTipoDeEntregaToolStripMenuItem,
            this.gerenciadorDeProdutosToolStripMenuItem,
            this.gerenciadorDeEntregasToolStripMenuItem,
            this.gerenciadorDePedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciadorDeVendedoresToolStripMenuItem
            // 
            this.gerenciadorDeVendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedoresToolStripMenuItem});
            this.gerenciadorDeVendedoresToolStripMenuItem.Name = "gerenciadorDeVendedoresToolStripMenuItem";
            this.gerenciadorDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.gerenciadorDeVendedoresToolStripMenuItem.Text = "Gerenciador de Vendedores";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // gerenciadorDeMarcasToolStripMenuItem
            // 
            this.gerenciadorDeMarcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem});
            this.gerenciadorDeMarcasToolStripMenuItem.Name = "gerenciadorDeMarcasToolStripMenuItem";
            this.gerenciadorDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gerenciadorDeMarcasToolStripMenuItem.Text = "Marcas";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // gerenciadorDeTipoDeEntregaToolStripMenuItem
            // 
            this.gerenciadorDeTipoDeEntregaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeEntregaToolStripMenuItem});
            this.gerenciadorDeTipoDeEntregaToolStripMenuItem.Name = "gerenciadorDeTipoDeEntregaToolStripMenuItem";
            this.gerenciadorDeTipoDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.gerenciadorDeTipoDeEntregaToolStripMenuItem.Text = "Tipo de Entrega";
            this.gerenciadorDeTipoDeEntregaToolStripMenuItem.Click += new System.EventHandler(this.gerenciadorDeTipoDeEntregaToolStripMenuItem_Click);
            // 
            // tipoDeEntregaToolStripMenuItem
            // 
            this.tipoDeEntregaToolStripMenuItem.Name = "tipoDeEntregaToolStripMenuItem";
            this.tipoDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tipoDeEntregaToolStripMenuItem.Text = "Tipo de Entrega";
            this.tipoDeEntregaToolStripMenuItem.Click += new System.EventHandler(this.tipoDeEntregaToolStripMenuItem_Click);
            // 
            // gerenciadorDeProdutosToolStripMenuItem
            // 
            this.gerenciadorDeProdutosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem});
            this.gerenciadorDeProdutosToolStripMenuItem.Name = "gerenciadorDeProdutosToolStripMenuItem";
            this.gerenciadorDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.gerenciadorDeProdutosToolStripMenuItem.Text = "Gerenciador de Produtos";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // gerenciadorDeEntregasToolStripMenuItem
            // 
            this.gerenciadorDeEntregasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entregasToolStripMenuItem});
            this.gerenciadorDeEntregasToolStripMenuItem.Name = "gerenciadorDeEntregasToolStripMenuItem";
            this.gerenciadorDeEntregasToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.gerenciadorDeEntregasToolStripMenuItem.Text = "Gerenciador de Entregas";
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            this.entregasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.entregasToolStripMenuItem.Text = "Entregas";
            this.entregasToolStripMenuItem.Click += new System.EventHandler(this.entregasToolStripMenuItem_Click);
            // 
            // gerenciadorDePedidosToolStripMenuItem
            // 
            this.gerenciadorDePedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem});
            this.gerenciadorDePedidosToolStripMenuItem.Name = "gerenciadorDePedidosToolStripMenuItem";
            this.gerenciadorDePedidosToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.gerenciadorDePedidosToolStripMenuItem.Text = "Gerenciador de Pedidos";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 433);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciadorDeVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciadorDeMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciadorDeTipoDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciadorDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciadorDeEntregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciadorDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
    }
}