namespace TouristGuide
{
    partial class viewfeedback
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
            this.FDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FDGV
            // 
            this.FDGV.BackgroundColor = System.Drawing.Color.White;
            this.FDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FDGV.Location = new System.Drawing.Point(12, 105);
            this.FDGV.Name = "FDGV";
            this.FDGV.RowTemplate.Height = 24;
            this.FDGV.Size = new System.Drawing.Size(1215, 480);
            this.FDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Feedbacks";
            // 
            // viewfeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FDGV);
            this.Name = "viewfeedback";
            this.Text = "viewfeedback";
            ((System.ComponentModel.ISupportInitialize)(this.FDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FDGV;
        private System.Windows.Forms.Label label1;
    }
}