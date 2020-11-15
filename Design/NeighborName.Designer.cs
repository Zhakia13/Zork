namespace Zork.Builder
{
    partial class NeighborName
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
            this.NeighborscomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NeighborscomboBox
            // 
            this.NeighborscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NeighborscomboBox.FormattingEnabled = true;
            this.NeighborscomboBox.Location = new System.Drawing.Point(4, 3);
            this.NeighborscomboBox.Name = "NeighborscomboBox";
            this.NeighborscomboBox.Size = new System.Drawing.Size(121, 21);
            this.NeighborscomboBox.TabIndex = 0;
            // 
            // NeighborName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NeighborscomboBox);
            this.Name = "NeighborName";
            this.Size = new System.Drawing.Size(128, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox NeighborscomboBox;
    }
}
