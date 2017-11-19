namespace Comercio.WindowsForms.Formularios
{
    partial class FormTipoEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoEntrega));
            this.lblDescricaoTipoEntrega = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvarTipoEntrega = new System.Windows.Forms.Button();
            this.btnEditarTipoEntrega = new System.Windows.Forms.Button();
            this.btnExcluirTipoEntrega = new System.Windows.Forms.Button();
            this.dataGridTipoEntrega = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricaoTipoEntrega
            // 
            this.lblDescricaoTipoEntrega.AutoSize = true;
            this.lblDescricaoTipoEntrega.Location = new System.Drawing.Point(23, 27);
            this.lblDescricaoTipoEntrega.Name = "lblDescricaoTipoEntrega";
            this.lblDescricaoTipoEntrega.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoTipoEntrega.TabIndex = 0;
            this.lblDescricaoTipoEntrega.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(78, 24);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(355, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // btnSalvarTipoEntrega
            // 
            this.btnSalvarTipoEntrega.Location = new System.Drawing.Point(26, 69);
            this.btnSalvarTipoEntrega.Name = "btnSalvarTipoEntrega";
            this.btnSalvarTipoEntrega.Size = new System.Drawing.Size(111, 23);
            this.btnSalvarTipoEntrega.TabIndex = 2;
            this.btnSalvarTipoEntrega.Text = "Salvar";
            this.btnSalvarTipoEntrega.UseVisualStyleBackColor = true;
            this.btnSalvarTipoEntrega.Click += new System.EventHandler(this.btnSalvarTipoEntrega_Click);
            // 
            // btnEditarTipoEntrega
            // 
            this.btnEditarTipoEntrega.Location = new System.Drawing.Point(178, 69);
            this.btnEditarTipoEntrega.Name = "btnEditarTipoEntrega";
            this.btnEditarTipoEntrega.Size = new System.Drawing.Size(111, 23);
            this.btnEditarTipoEntrega.TabIndex = 3;
            this.btnEditarTipoEntrega.Text = "Editar";
            this.btnEditarTipoEntrega.UseVisualStyleBackColor = true;
            this.btnEditarTipoEntrega.Click += new System.EventHandler(this.btnEditarTipoEntrega_Click);
            // 
            // btnExcluirTipoEntrega
            // 
            this.btnExcluirTipoEntrega.Location = new System.Drawing.Point(322, 69);
            this.btnExcluirTipoEntrega.Name = "btnExcluirTipoEntrega";
            this.btnExcluirTipoEntrega.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirTipoEntrega.TabIndex = 4;
            this.btnExcluirTipoEntrega.Text = "Excluir";
            this.btnExcluirTipoEntrega.UseVisualStyleBackColor = true;
            this.btnExcluirTipoEntrega.Click += new System.EventHandler(this.btnExcluirTipoEntrega_Click);
            // 
            // dataGridTipoEntrega
            // 
            this.dataGridTipoEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTipoEntrega.Location = new System.Drawing.Point(12, 171);
            this.dataGridTipoEntrega.Name = "dataGridTipoEntrega";
            this.dataGridTipoEntrega.Size = new System.Drawing.Size(712, 239);
            this.dataGridTipoEntrega.TabIndex = 5;
            // 
            // FormTipoEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 422);
            this.Controls.Add(this.dataGridTipoEntrega);
            this.Controls.Add(this.btnExcluirTipoEntrega);
            this.Controls.Add(this.btnEditarTipoEntrega);
            this.Controls.Add(this.btnSalvarTipoEntrega);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricaoTipoEntrega);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTipoEntrega";
            this.Text = "FormTipoEntrega";
            this.Load += new System.EventHandler(this.FormTipoEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricaoTipoEntrega;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvarTipoEntrega;
        private System.Windows.Forms.Button btnEditarTipoEntrega;
        private System.Windows.Forms.Button btnExcluirTipoEntrega;
        private System.Windows.Forms.DataGridView dataGridTipoEntrega;
    }
}