namespace Zork.Builder
{
    partial class AddRoom
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
            this.RoomNametextBox = new System.Windows.Forms.TextBox();
            this.NewRoomNamelabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomNametextBox
            // 
            this.RoomNametextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.RoomNametextBox.Location = new System.Drawing.Point(12, 24);
            this.RoomNametextBox.Name = "RoomNametextBox";
            this.RoomNametextBox.Size = new System.Drawing.Size(307, 20);
            this.RoomNametextBox.TabIndex = 1;
            this.RoomNametextBox.TextChanged += new System.EventHandler(this.RoomNametextBox_TextChanged);
            // 
            // NewRoomNamelabel
            // 
            this.NewRoomNamelabel.AutoSize = true;
            this.NewRoomNamelabel.Location = new System.Drawing.Point(9, 8);
            this.NewRoomNamelabel.Name = "NewRoomNamelabel";
            this.NewRoomNamelabel.Size = new System.Drawing.Size(63, 13);
            this.NewRoomNamelabel.TabIndex = 0;
            this.NewRoomNamelabel.Text = "New Room:";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(165, 50);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Enabled = false;
            this.Cancelbutton.Location = new System.Drawing.Point(246, 49);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // AddRoom
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 84);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RoomNametextBox);
            this.Controls.Add(this.NewRoomNamelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoomNametextBox;
        private System.Windows.Forms.Label NewRoomNamelabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button Cancelbutton;
    }
}