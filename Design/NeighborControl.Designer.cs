namespace Zork.Builder
{
    partial class NeighborControl
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
            this.NeighborscomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DirectionstextBox
            // 
            this.DirectionstextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.DirectionstextBox.Location = new System.Drawing.Point(21, 3);
            this.DirectionstextBox.Name = "DirectionstextBox";
            this.DirectionstextBox.Size = new System.Drawing.Size(100, 20);
            this.DirectionstextBox.TabIndex = 0;
            this.DirectionstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NeighborscomboBox
            // 
            this.NeighborscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NeighborscomboBox.FormattingEnabled = true;
            this.NeighborscomboBox.Location = new System.Drawing.Point(12, 28);
            this.NeighborscomboBox.Name = "NeighborscomboBox";
            this.NeighborscomboBox.Size = new System.Drawing.Size(121, 21);
            this.NeighborscomboBox.TabIndex = 1;
            // 
            // NeighborControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NeighborscomboBox);
            this.Controls.Add(this.DirectionstextBox);
            this.Name = "NeighborControl";
            this.Size = new System.Drawing.Size(139, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DirectionstextBox;
        private System.Windows.Forms.ComboBox NeighborscomboBox;
    }
}
