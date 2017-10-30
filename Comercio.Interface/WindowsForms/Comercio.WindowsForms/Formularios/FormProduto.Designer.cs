namespace Comercio.WindowsForms.Formularios
{
    partial class FormProduto
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
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.lblMarcaProduto = new System.Windows.Forms.Label();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.cbMarcaProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(35, 26);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(93, 13);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome do Produto:";
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Location = new System.Drawing.Point(35, 57);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(89, 13);
            this.lblValorProduto.TabIndex = 1;
            this.lblValorProduto.Text = "Valor do Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(130, 23);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(355, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(130, 54);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(355, 20);
            this.txtValorProduto.TabIndex = 3;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(38, 125);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(111, 23);
            this.btnSalvarProduto.TabIndex = 4;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(206, 125);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(111, 23);
            this.btnEditarProduto.TabIndex = 5;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(374, 125);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirProduto.TabIndex = 6;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // lblMarcaProduto
            // 
            this.lblMarcaProduto.AutoSize = true;
            this.lblMarcaProduto.Location = new System.Drawing.Point(29, 89);
            this.lblMarcaProduto.Name = "lblMarcaProduto";
            this.lblMarcaProduto.Size = new System.Drawing.Size(95, 13);
            this.lblMarcaProduto.TabIndex = 7;
            this.lblMarcaProduto.Text = "Marca do Produto:";
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Location = new System.Drawing.Point(12, 171);
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.Size = new System.Drawing.Size(712, 239);
            this.dataGridProduto.TabIndex = 9;
            // 
            // cbMarcaProduto
            // 
            this.cbMarcaProduto.FormattingEnabled = true;
            this.cbMarcaProduto.Location = new System.Drawing.Point(130, 86);
            this.cbMarcaProduto.Name = "cbMarcaProduto";
            this.cbMarcaProduto.Size = new System.Drawing.Size(355, 21);
            this.cbMarcaProduto.TabIndex = 11;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 422);
            this.Controls.Add(this.cbMarcaProduto);
            this.Controls.Add(this.dataGridProduto);
            this.Controls.Add(this.lblMarcaProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Label lblMarcaProduto;
        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.ComboBox cbMarcaProduto;
    }
}