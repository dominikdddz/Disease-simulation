namespace DiseaseSimulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxGrid
            // 
            this.PictureBoxGrid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PictureBoxGrid.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxGrid.Name = "PictureBoxGrid";
            this.PictureBoxGrid.Size = new System.Drawing.Size(500, 500);
            this.PictureBoxGrid.TabIndex = 0;
            this.PictureBoxGrid.TabStop = false;
            this.PictureBoxGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 525);
            this.Controls.Add(this.PictureBoxGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PictureBoxGrid;
    }
}