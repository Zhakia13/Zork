namespace Zork.Builder
{
    partial class DirectionsNeighbor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DirectionstextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DirectionstextBox
            // 
            this.DirectionstextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectionstextBox.Location = new System.Drawing.Point(13, 3);
            this.DirectionstextBox.Name = "DirectionstextBox";
            this.DirectionstextBox.ReadOnly = true;
            this.DirectionstextBox.Size = new System.Drawing.Size(100, 20);
            this.DirectionstextBox.TabIndex = 0;
            this.DirectionstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DirectionsNeighbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DirectionstextBox);
            this.Name = "DirectionsNeighbor";
            this.Size = new System.Drawing.Size(123, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DirectionstextBox;
    }
}
