namespace Comercio.WindowsForms.Formularios
{
    partial class FormEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrega));
            this.lblCodigoRastreio = new System.Windows.Forms.Label();
            this.txtCodigoRastreio = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.cbPedido = new System.Windows.Forms.ComboBox();
            this.lblTipoEntrega = new System.Windows.Forms.Label();
            this.cbTipoEntrega = new System.Windows.Forms.ComboBox();
            this.btnSalvarEntrega = new System.Windows.Forms.Button();
            this.btnEditarEntrega = new System.Windows.Forms.Button();
            this.btnExcluirEntrega = new System.Windows.Forms.Button();
            this.dataGridEntrega = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoRastreio
            // 
            this.lblCodigoRastreio.AutoSize = true;
            this.lblCodigoRastreio.Location = new System.Drawing.Point(33, 31);
            this.lblCodigoRastreio.Name = "lblCodigoRastreio";
            this.lblCodigoRastreio.Size = new System.Drawing.Size(100, 13);
            this.lblCodigoRastreio.TabIndex = 0;
            this.lblCodigoRastreio.Text = "Código de Rastreio:";
            // 
            // txtCodigoRastreio
            // 
            this.txtCodigoRastreio.Location = new System.Drawing.Point(135, 28);
            this.txtCodigoRastreio.Name = "txtCodigoRastreio";
            this.txtCodigoRastreio.Size = new System.Drawing.Size(355, 20);
            this.txtCodigoRastreio.TabIndex = 1;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(90, 88);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(43, 13);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "Pedido:";
            // 
            // cbPedido
            // 
            this.cbPedido.FormattingEnabled = true;
            this.cbPedido.Location = new System.Drawing.Point(135, 88);
            this.cbPedido.Name = "cbPedido";
            this.cbPedido.Size = new System.Drawing.Size(355, 21);
            this.cbPedido.TabIndex = 3;
            // 
            // lblTipoEntrega
            // 
            this.lblTipoEntrega.AutoSize = true;
            this.lblTipoEntrega.Location = new System.Drawing.Point(62, 61);
            this.lblTipoEntrega.Name = "lblTipoEntrega";
            this.lblTipoEntrega.Size = new System.Drawing.Size(71, 13);
            this.lblTipoEntrega.TabIndex = 4;
            this.lblTipoEntrega.Text = "Tipo Entrega:";
            // 
            // cbTipoEntrega
            // 
            this.cbTipoEntrega.FormattingEnabled = true;
            this.cbTipoEntrega.Location = new System.Drawing.Point(135, 58);
            this.cbTipoEntrega.Name = "cbTipoEntrega";
            this.cbTipoEntrega.Size = new System.Drawing.Size(355, 21);
            this.cbTipoEntrega.TabIndex = 5;
            // 
            // btnSalvarEntrega
            // 
            this.btnSalvarEntrega.Location = new System.Drawing.Point(36, 130);
            this.btnSalvarEntrega.Name = "btnSalvarEntrega";
            this.btnSalvarEntrega.Size = new System.Drawing.Size(111, 23);
            this.btnSalvarEntrega.TabIndex = 6;
            this.btnSalvarEntrega.Text = "Salvar";
            this.btnSalvarEntrega.UseVisualStyleBackColor = true;
            this.btnSalvarEntrega.Click += new System.EventHandler(this.btnSalvarEntrega_Click);
            // 
            // btnEditarEntrega
            // 
            this.btnEditarEntrega.Location = new System.Drawing.Point(209, 130);
            this.btnEditarEntrega.Name = "btnEditarEntrega";
            this.btnEditarEntrega.Size = new System.Drawing.Size(111, 23);
            this.btnEditarEntrega.TabIndex = 7;
            this.btnEditarEntrega.Text = "Editar";
            this.btnEditarEntrega.UseVisualStyleBackColor = true;
            this.btnEditarEntrega.Click += new System.EventHandler(this.btnEditarEntrega_Click);
            // 
            // btnExcluirEntrega
            // 
            this.btnExcluirEntrega.Location = new System.Drawing.Point(379, 130);
            this.btnExcluirEntrega.Name = "btnExcluirEntrega";
            this.btnExcluirEntrega.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirEntrega.TabIndex = 8;
            this.btnExcluirEntrega.Text = "Excluir";
            this.btnExcluirEntrega.UseVisualStyleBackColor = true;
            this.btnExcluirEntrega.Click += new System.EventHandler(this.btnExcluirEntrega_Click);
            // 
            // dataGridEntrega
            // 
            this.dataGridEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEntrega.Location = new System.Drawing.Point(12, 171);
            this.dataGridEntrega.Name = "dataGridEntrega";
            this.dataGridEntrega.Size = new System.Drawing.Size(712, 239);
            this.dataGridEntrega.TabIndex = 9;
            // 
            // FormEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 422);
            this.Controls.Add(this.dataGridEntrega);
            this.Controls.Add(this.btnExcluirEntrega);
            this.Controls.Add(this.btnEditarEntrega);
            this.Controls.Add(this.btnSalvarEntrega);
            this.Controls.Add(this.cbTipoEntrega);
            this.Controls.Add(this.lblTipoEntrega);
            this.Controls.Add(this.cbPedido);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.txtCodigoRastreio);
            this.Controls.Add(this.lblCodigoRastreio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEntrega";
            this.Text = "FormEntrega";
            this.Load += new System.EventHandler(this.FormEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoRastreio;
        private System.Windows.Forms.TextBox txtCodigoRastreio;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.ComboBox cbPedido;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.ComboBox cbTipoEntrega;
        private System.Windows.Forms.Button btnSalvarEntrega;
        private System.Windows.Forms.Button btnEditarEntrega;
        private System.Windows.Forms.Button btnExcluirEntrega;
        private System.Windows.Forms.DataGridView dataGridEntrega;
    }
}