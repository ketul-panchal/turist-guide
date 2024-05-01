namespace TouristGuide
{
    partial class ViewPlace
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
            this.PlaceDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaceDGV
            // 
            this.PlaceDGV.BackgroundColor = System.Drawing.Color.White;
            this.PlaceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaceDGV.Location = new System.Drawing.Point(42, 76);
            this.PlaceDGV.Name = "PlaceDGV";
            this.PlaceDGV.RowTemplate.Height = 24;
            this.PlaceDGV.Size = new System.Drawing.Size(1277, 385);
            this.PlaceDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "View All Our Best Selected Places For Your Tour";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlaceDGV);
            this.Name = "ViewPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPlace";
            ((System.ComponentModel.ISupportInitialize)(this.PlaceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlaceDGV;
        private System.Windows.Forms.Label label1;
    }
}