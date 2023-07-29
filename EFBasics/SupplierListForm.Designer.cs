namespace EFBasics
{
    partial class SupplierListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSupplierUpdateForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierDeleteForm = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSupplierUpdateForm,
            this.menuSupplierDeleteForm});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // menuSupplierUpdateForm
            // 
            this.menuSupplierUpdateForm.Name = "menuSupplierUpdateForm";
            this.menuSupplierUpdateForm.Size = new System.Drawing.Size(210, 24);
            this.menuSupplierUpdateForm.Text = "Düzenle";
            this.menuSupplierUpdateForm.Click += new System.EventHandler(this.menuSupplierUpdateForm_Click);
            // 
            // menuSupplierDeleteForm
            // 
            this.menuSupplierDeleteForm.Name = "menuSupplierDeleteForm";
            this.menuSupplierDeleteForm.Size = new System.Drawing.Size(210, 24);
            this.menuSupplierDeleteForm.Text = "Sil";
            this.menuSupplierDeleteForm.Click += new System.EventHandler(this.menuSupplierDeleteForm_Click);
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Location = new System.Drawing.Point(12, 12);
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(300, 27);
            this.txtSearchSupplier.TabIndex = 1;
            this.txtSearchSupplier.TextChanged += new System.EventHandler(this.txtSearchSupplier_TextChanged);
            // 
            // SupplierListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchSupplier);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SupplierListForm";
            this.Text = "SupplierListForm";
            this.Load += new System.EventHandler(this.SupplierListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearchSupplier;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuSupplierUpdateForm;
        private ToolStripMenuItem menuSupplierDeleteForm;
    }
}