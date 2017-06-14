namespace SolarDataManager
{
    partial class Form2
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
            this.accountTableAdapter1 = new SolarDataManager.SolarDataSetTableAdapters.accountTableAdapter();
            this.hierarchicalGridView1 = new HierarchicalGrid.HierarchicalGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hierarchicalGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountTableAdapter1
            // 
            this.accountTableAdapter1.ClearBeforeFill = true;
            // 
            // hierarchicalGridView1
            // 
            this.hierarchicalGridView1.AllowUserToAddRows = false;
            this.hierarchicalGridView1.AllowUserToDeleteRows = false;
            this.hierarchicalGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.hierarchicalGridView1.ImageList = null;
            this.hierarchicalGridView1.Location = new System.Drawing.Point(12, 12);
            this.hierarchicalGridView1.Name = "hierarchicalGridView1";
            this.hierarchicalGridView1.Size = new System.Drawing.Size(664, 365);
            this.hierarchicalGridView1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 606);
            this.Controls.Add(this.hierarchicalGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hierarchicalGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SolarDataSetTableAdapters.accountTableAdapter accountTableAdapter1;
        private HierarchicalGrid.HierarchicalGridView hierarchicalGridView1;
    }
}