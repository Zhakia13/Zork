namespace Zork.Builder
{
    partial class NeighborsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DirectiontextBox = new System.Windows.Forms.TextBox();
            this.NeighborRoomlabel = new System.Windows.Forms.Label();
            this.OKNeighborbutton = new System.Windows.Forms.Button();
            this.DeleteNeighborbutton = new System.Windows.Forms.Button();
            this.RoomscomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direction: ";
            // 
            // DirectiontextBox
            // 
            this.DirectiontextBox.Location = new System.Drawing.Point(12, 25);
            this.DirectiontextBox.Name = "DirectiontextBox";
            this.DirectiontextBox.Size = new System.Drawing.Size(100, 20);
            this.DirectiontextBox.TabIndex = 1;
            // 
            // NeighborRoomlabel
            // 
            this.NeighborRoomlabel.AutoSize = true;
            this.NeighborRoomlabel.Location = new System.Drawing.Point(12, 48);
            this.NeighborRoomlabel.Name = "NeighborRoomlabel";
            this.NeighborRoomlabel.Size = new System.Drawing.Size(41, 13);
            this.NeighborRoomlabel.TabIndex = 2;
            this.NeighborRoomlabel.Text = "Room: ";
            // 
            // OKNeighborbutton
            // 
            this.OKNeighborbutton.Location = new System.Drawing.Point(75, 90);
            this.OKNeighborbutton.Name = "OKNeighborbutton";
            this.OKNeighborbutton.Size = new System.Drawing.Size(75, 23);
            this.OKNeighborbutton.TabIndex = 4;
            this.OKNeighborbutton.Text = "OK";
            this.OKNeighborbutton.UseVisualStyleBackColor = true;
            // 
            // DeleteNeighborbutton
            // 
            this.DeleteNeighborbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DeleteNeighborbutton.Location = new System.Drawing.Point(156, 90);
            this.DeleteNeighborbutton.Name = "DeleteNeighborbutton";
            this.DeleteNeighborbutton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNeighborbutton.TabIndex = 5;
            this.DeleteNeighborbutton.Text = "Cancel";
            this.DeleteNeighborbutton.UseVisualStyleBackColor = true;
            // 
            // RoomscomboBox
            // 
            this.RoomscomboBox.FormattingEnabled = true;
            this.RoomscomboBox.Location = new System.Drawing.Point(15, 64);
            this.RoomscomboBox.Name = "RoomscomboBox";
            this.RoomscomboBox.Size = new System.Drawing.Size(213, 21);
            this.RoomscomboBox.TabIndex = 6;
            // 
            // NeighborsForm
            // 
            this.AcceptButton = this.OKNeighborbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DeleteNeighborbutton;
            this.ClientSize = new System.Drawing.Size(240, 128);
            this.Controls.Add(this.RoomscomboBox);
            this.Controls.Add(this.DeleteNeighborbutton);
            this.Controls.Add(this.OKNeighborbutton);
            this.Controls.Add(this.NeighborRoomlabel);
            this.Controls.Add(this.DirectiontextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NeighborsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NeighborsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DirectiontextBox;
        private System.Windows.Forms.Label NeighborRoomlabel;
        private System.Windows.Forms.Button OKNeighborbutton;
        private System.Windows.Forms.Button DeleteNeighborbutton;
        private System.Windows.Forms.ComboBox RoomscomboBox;
    }
}