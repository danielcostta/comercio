namespace Comercio.WindowsForms.Formularios
{
    partial class FormVendedor
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
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.btnSalvarVendedor = new System.Windows.Forms.Button();
            this.btnEditarVendedor = new System.Windows.Forms.Button();
            this.btnExcluirVendedor = new System.Windows.Forms.Button();
            this.dataGridVendedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Location = new System.Drawing.Point(23, 28);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(87, 13);
            this.lblNomeVendedor.TabIndex = 0;
            this.lblNomeVendedor.Text = "Nome Vendedor:";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(107, 25);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(361, 20);
            this.txtNomeVendedor.TabIndex = 1;
            // 
            // btnSalvarVendedor
            // 
            this.btnSalvarVendedor.Location = new System.Drawing.Point(40, 86);
            this.btnSalvarVendedor.Name = "btnSalvarVendedor";
            this.btnSalvarVendedor.Size = new System.Drawing.Size(111, 23);
            this.btnSalvarVendedor.TabIndex = 2;
            this.btnSalvarVendedor.Text = "Salvar";
            this.btnSalvarVendedor.UseVisualStyleBackColor = true;
            this.btnSalvarVendedor.Click += new System.EventHandler(this.btnSalvarVendedor_Click);
            // 
            // btnEditarVendedor
            // 
            this.btnEditarVendedor.Location = new System.Drawing.Point(225, 86);
            this.btnEditarVendedor.Name = "btnEditarVendedor";
            this.btnEditarVendedor.Size = new System.Drawing.Size(111, 23);
            this.btnEditarVendedor.TabIndex = 3;
            this.btnEditarVendedor.Text = "Editar";
            this.btnEditarVendedor.UseVisualStyleBackColor = true;
            this.btnEditarVendedor.Click += new System.EventHandler(this.btnEditarVendedor_Click);
            // 
            // btnExcluirVendedor
            // 
            this.btnExcluirVendedor.Location = new System.Drawing.Point(410, 86);
            this.btnExcluirVendedor.Name = "btnExcluirVendedor";
            this.btnExcluirVendedor.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirVendedor.TabIndex = 4;
            this.btnExcluirVendedor.Text = "Excluir";
            this.btnExcluirVendedor.UseVisualStyleBackColor = true;
            this.btnExcluirVendedor.Click += new System.EventHandler(this.btnExcluirVendedor_Click);
            // 
            // dataGridVendedor
            // 
            this.dataGridVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVendedor.Location = new System.Drawing.Point(3, 154);
            this.dataGridVendedor.Name = "dataGridVendedor";
            this.dataGridVendedor.Size = new System.Drawing.Size(589, 150);
            this.dataGridVendedor.TabIndex = 5;
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 307);
            this.Controls.Add(this.dataGridVendedor);
            this.Controls.Add(this.btnExcluirVendedor);
            this.Controls.Add(this.btnEditarVendedor);
            this.Controls.Add(this.btnSalvarVendedor);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.lblNomeVendedor);
            this.Name = "FormVendedor";
            this.Text = "Controle de Vendedores";
            this.Load += new System.EventHandler(this.FormVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Button btnSalvarVendedor;
        private System.Windows.Forms.Button btnEditarVendedor;
        private System.Windows.Forms.Button btnExcluirVendedor;
        private System.Windows.Forms.DataGridView dataGridVendedor;
    }
}