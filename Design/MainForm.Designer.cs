namespace Zork.Builder.Forms
{
    partial class MainForm
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.RoomlistBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.NeighborsgroupBox = new System.Windows.Forms.GroupBox();
            this.directionsNeighborE = new Zork.Builder.DirectionsNeighbor();
            this.directionsNeighborW = new Zork.Builder.DirectionsNeighbor();
            this.directionsNeighbors = new Zork.Builder.DirectionsNeighbor();
            this.directionsNeighborN = new Zork.Builder.DirectionsNeighbor();
            this.NameRoomtextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Roomslabel = new System.Windows.Forms.Label();
            this.StartingLocationcomboBox = new System.Windows.Forms.ComboBox();
            this.StartingLocationlabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExittextBox = new System.Windows.Forms.TextBox();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.WelcometextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.WelcomeMessagelabel = new System.Windows.Forms.Label();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Tab.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.NeighborsgroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.AccessibleDescription = "";
            this.Tab.AccessibleName = "";
            this.Tab.Controls.Add(this.tabPage);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Location = new System.Drawing.Point(0, 27);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(574, 461);
            this.Tab.TabIndex = 7;
            this.Tab.Tag = "";
            // 
            // tabPage
            // 
            this.tabPage.AutoScroll = true;
            this.tabPage.Controls.Add(this.RoomlistBox);
            this.tabPage.Controls.Add(this.DescriptiontextBox);
            this.tabPage.Controls.Add(this.Descriptionlabel);
            this.tabPage.Controls.Add(this.NeighborsgroupBox);
            this.tabPage.Controls.Add(this.NameRoomtextBox);
            this.tabPage.Controls.Add(this.Namelabel);
            this.tabPage.Controls.Add(this.textBox1);
            this.tabPage.Controls.Add(this.Roomslabel);
            this.tabPage.Controls.Add(this.StartingLocationcomboBox);
            this.tabPage.Controls.Add(this.StartingLocationlabel);
            this.tabPage.Controls.Add(this.DeleteButton);
            this.tabPage.Controls.Add(this.AddButton);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(566, 435);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "World";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // RoomlistBox
            // 
            this.RoomlistBox.DataSource = this.roomsBindingSource1;
            this.RoomlistBox.DisplayMember = "Name";
            this.RoomlistBox.FormattingEnabled = true;
            this.RoomlistBox.Location = new System.Drawing.Point(11, 70);
            this.RoomlistBox.Name = "RoomlistBox";
            this.RoomlistBox.Size = new System.Drawing.Size(153, 303);
            this.RoomlistBox.TabIndex = 18;
            this.RoomlistBox.ValueMember = "Description";
            this.RoomlistBox.SelectedIndexChanged += new System.EventHandler(this.RoomlistBox_SelectedIndexChanged);
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Design.ViewModel.GameViewModel);
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DescriptiontextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptiontextBox.Location = new System.Drawing.Point(199, 139);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(339, 64);
            this.DescriptiontextBox.TabIndex = 16;
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Location = new System.Drawing.Point(196, 123);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descriptionlabel.TabIndex = 15;
            this.Descriptionlabel.Text = "Description:";
            // 
            // NeighborsgroupBox
            // 
            this.NeighborsgroupBox.Controls.Add(this.directionsNeighborE);
            this.NeighborsgroupBox.Controls.Add(this.directionsNeighborW);
            this.NeighborsgroupBox.Controls.Add(this.directionsNeighbors);
            this.NeighborsgroupBox.Controls.Add(this.directionsNeighborN);
            this.NeighborsgroupBox.Location = new System.Drawing.Point(185, 209);
            this.NeighborsgroupBox.Name = "NeighborsgroupBox";
            this.NeighborsgroupBox.Size = new System.Drawing.Size(368, 196);
            this.NeighborsgroupBox.TabIndex = 14;
            this.NeighborsgroupBox.TabStop = false;
            this.NeighborsgroupBox.Text = "Neighbors";
            // 
            // directionsNeighborE
            // 
            this.directionsNeighborE.Direction = Zork.Directions.EAST;
            this.directionsNeighborE.Location = new System.Drawing.Point(239, 73);
            this.directionsNeighborE.Name = "directionsNeighborE";
            this.directionsNeighborE.Size = new System.Drawing.Size(123, 28);
            this.directionsNeighborE.TabIndex = 11;
            this.directionsNeighborE.ViewModel = null;
            // 
            // directionsNeighborW
            // 
            this.directionsNeighborW.Direction = Zork.Directions.WEST;
            this.directionsNeighborW.Location = new System.Drawing.Point(6, 73);
            this.directionsNeighborW.Name = "directionsNeighborW";
            this.directionsNeighborW.Size = new System.Drawing.Size(123, 28);
            this.directionsNeighborW.TabIndex = 10;
            this.directionsNeighborW.ViewModel = null;
            // 
            // directionsNeighbors
            // 
            this.directionsNeighbors.Direction = Zork.Directions.SOUTH;
            this.directionsNeighbors.Location = new System.Drawing.Point(122, 139);
            this.directionsNeighbors.Name = "directionsNeighbors";
            this.directionsNeighbors.Size = new System.Drawing.Size(123, 28);
            this.directionsNeighbors.TabIndex = 9;
            this.directionsNeighbors.ViewModel = null;
            // 
            // directionsNeighborN
            // 
            this.directionsNeighborN.Direction = Zork.Directions.NORTH;
            this.directionsNeighborN.Location = new System.Drawing.Point(122, 15);
            this.directionsNeighborN.Name = "directionsNeighborN";
            this.directionsNeighborN.Size = new System.Drawing.Size(123, 28);
            this.directionsNeighborN.TabIndex = 8;
            this.directionsNeighborN.ViewModel = null;
            // 
            // NameRoomtextBox
            // 
            this.NameRoomtextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.NameRoomtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameRoomtextBox.Location = new System.Drawing.Point(199, 100);
            this.NameRoomtextBox.Name = "NameRoomtextBox";
            this.NameRoomtextBox.Size = new System.Drawing.Size(307, 20);
            this.NameRoomtextBox.TabIndex = 13;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(196, 84);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(38, 13);
            this.Namelabel.TabIndex = 12;
            this.Namelabel.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.textBox1.Location = new System.Drawing.Point(185, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 335);
            this.textBox1.TabIndex = 11;
            // 
            // Roomslabel
            // 
            this.Roomslabel.AutoSize = true;
            this.Roomslabel.Location = new System.Drawing.Point(8, 54);
            this.Roomslabel.Name = "Roomslabel";
            this.Roomslabel.Size = new System.Drawing.Size(43, 13);
            this.Roomslabel.TabIndex = 10;
            this.Roomslabel.Text = "Rooms:";
            // 
            // StartingLocationcomboBox
            // 
            this.StartingLocationcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gameViewModelBindingSource, "StartingLocation", true));
            this.StartingLocationcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource1, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StartingLocationcomboBox.DataSource = this.roomsBindingSource1;
            this.StartingLocationcomboBox.DisplayMember = "Name";
            this.StartingLocationcomboBox.FormattingEnabled = true;
            this.StartingLocationcomboBox.Location = new System.Drawing.Point(11, 30);
            this.StartingLocationcomboBox.Name = "StartingLocationcomboBox";
            this.StartingLocationcomboBox.Size = new System.Drawing.Size(153, 21);
            this.StartingLocationcomboBox.TabIndex = 9;
            this.StartingLocationcomboBox.ValueMember = "Description";
            // 
            // StartingLocationlabel
            // 
            this.StartingLocationlabel.AutoSize = true;
            this.StartingLocationlabel.Location = new System.Drawing.Point(8, 14);
            this.StartingLocationlabel.Name = "StartingLocationlabel";
            this.StartingLocationlabel.Size = new System.Drawing.Size(93, 13);
            this.StartingLocationlabel.TabIndex = 8;
            this.StartingLocationlabel.Text = "Starting Location: ";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(92, 382);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(11, 382);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ExittextBox);
            this.tabPage2.Controls.Add(this.Exitlabel);
            this.tabPage2.Controls.Add(this.NametextBox);
            this.tabPage2.Controls.Add(this.WelcometextBox);
            this.tabPage2.Controls.Add(this.FileNameLabel);
            this.tabPage2.Controls.Add(this.WelcomeMessagelabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExittextBox
            // 
            this.ExittextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "ExitMessage", true));
            this.ExittextBox.Location = new System.Drawing.Point(6, 102);
            this.ExittextBox.Name = "ExittextBox";
            this.ExittextBox.Size = new System.Drawing.Size(522, 20);
            this.ExittextBox.TabIndex = 7;
            // 
            // Exitlabel
            // 
            this.Exitlabel.AutoSize = true;
            this.Exitlabel.Location = new System.Drawing.Point(3, 86);
            this.Exitlabel.Name = "Exitlabel";
            this.Exitlabel.Size = new System.Drawing.Size(73, 13);
            this.Exitlabel.TabIndex = 6;
            this.Exitlabel.Text = "Exit Message:";
            // 
            // NametextBox
            // 
            this.NametextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FullPath", true));
            this.NametextBox.Location = new System.Drawing.Point(6, 24);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.ReadOnly = true;
            this.NametextBox.Size = new System.Drawing.Size(522, 20);
            this.NametextBox.TabIndex = 5;
            // 
            // WelcometextBox
            // 
            this.WelcometextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "WelcomeMessage", true));
            this.WelcometextBox.Location = new System.Drawing.Point(6, 63);
            this.WelcometextBox.Name = "WelcometextBox";
            this.WelcometextBox.Size = new System.Drawing.Size(522, 20);
            this.WelcometextBox.TabIndex = 4;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(3, 8);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(52, 13);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "Filename:";
            // 
            // WelcomeMessagelabel
            // 
            this.WelcomeMessagelabel.AutoSize = true;
            this.WelcomeMessagelabel.Location = new System.Drawing.Point(3, 47);
            this.WelcomeMessagelabel.Name = "WelcomeMessagelabel";
            this.WelcomeMessagelabel.Size = new System.Drawing.Size(101, 13);
            this.WelcomeMessagelabel.TabIndex = 2;
            this.WelcomeMessagelabel.Text = "Welcome Message:";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(Zork.Room);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Zork";
            this.openFileDialog.Filter = "JSON Files (*.json)|*.json";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(579, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.SaveAsItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // SaveAsItem
            // 
            this.SaveAsItem.Name = "SaveAsItem";
            this.SaveAsItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsItem.Size = new System.Drawing.Size(184, 22);
            this.SaveAsItem.Text = "Save as";
            this.SaveAsItem.Click += new System.EventHandler(this.SaveAsItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Save As";
            this.saveFileDialog.Filter = "JSON Files (*.json)|*.json";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 495);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main_Form";
            this.Tab.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.NeighborsgroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.GroupBox NeighborsgroupBox;
        private System.Windows.Forms.TextBox NameRoomtextBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Roomslabel;
        private System.Windows.Forms.ComboBox StartingLocationcomboBox;
        private System.Windows.Forms.Label StartingLocationlabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox WelcometextBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label WelcomeMessagelabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox RoomlistBox;
        private System.Windows.Forms.TextBox ExittextBox;
        private System.Windows.Forms.Label Exitlabel;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private NeighborControl neighborControl2;
        private DirectionsNeighbor directionsNeighborE;
        private DirectionsNeighbor directionsNeighborW;
        private DirectionsNeighbor directionsNeighbors;
        private DirectionsNeighbor directionsNeighborN;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private System.Windows.Forms.BindingSource roomBindingSource;
    }
}