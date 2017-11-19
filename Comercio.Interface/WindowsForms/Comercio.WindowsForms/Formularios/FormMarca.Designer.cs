namespace Comercio.WindowsForms.Formularios
{
    partial class FormMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarca));
            this.lblNomeMarca = new System.Windows.Forms.Label();
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.btnSalvarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.dataGridMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeMarca
            // 
            this.lblNomeMarca.AutoSize = true;
            this.lblNomeMarca.Location = new System.Drawing.Point(25, 27);
            this.lblNomeMarca.Name = "lblNomeMarca";
            this.lblNomeMarca.Size = new System.Drawing.Size(86, 13);
            this.lblNomeMarca.TabIndex = 0;
            this.lblNomeMarca.Text = "Nome da Marca:";
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Location = new System.Drawing.Point(117, 24);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(355, 20);
            this.txtNomeMarca.TabIndex = 1;
            // 
            // btnSalvarMarca
            // 
            this.btnSalvarMarca.Location = new System.Drawing.Point(28, 72);
            this.btnSalvarMarca.Name = "btnSalvarMarca";
            this.btnSalvarMarca.Size = new System.Drawing.Size(111, 23);
            this.btnSalvarMarca.TabIndex = 2;
            this.btnSalvarMarca.Text = "Salvar";
            this.btnSalvarMarca.UseVisualStyleBackColor = true;
            this.btnSalvarMarca.Click += new System.EventHandler(this.btnSalvarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Location = new System.Drawing.Point(190, 72);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(111, 23);
            this.btnEditarMarca.TabIndex = 3;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.Location = new System.Drawing.Point(361, 72);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirMarca.TabIndex = 4;
            this.btnExcluirMarca.Text = "Excluir";
            this.btnExcluirMarca.UseVisualStyleBackColor = true;
            this.btnExcluirMarca.Click += new System.EventHandler(this.btnExcluirMarca_Click);
            // 
            // dataGridMarca
            // 
            this.dataGridMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMarca.Location = new System.Drawing.Point(12, 171);
            this.dataGridMarca.Name = "dataGridMarca";
            this.dataGridMarca.Size = new System.Drawing.Size(712, 239);
            this.dataGridMarca.TabIndex = 5;
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 422);
            this.Controls.Add(this.dataGridMarca);
            this.Controls.Add(this.btnExcluirMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnSalvarMarca);
            this.Controls.Add(this.txtNomeMarca);
            this.Controls.Add(this.lblNomeMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMarca";
            this.Text = "FormMarca";
            this.Load += new System.EventHandler(this.FormMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeMarca;
        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.Button btnSalvarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.DataGridView dataGridMarca;
    }
}