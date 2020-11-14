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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RoomlistBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.NeighborsgroupBox = new System.Windows.Forms.GroupBox();
            this.Westlabel = new System.Windows.Forms.Label();
            this.Southlabel = new System.Windows.Forms.Label();
            this.Northlabel = new System.Windows.Forms.Label();
            this.neighborButtons3 = new Zork.Builder.NeighborButtons();
            this.neighborButtons2 = new Zork.Builder.NeighborButtons();
            this.neighborElabel = new System.Windows.Forms.Label();
            this.neighborButtons1 = new Zork.Builder.NeighborButtons();
            this.NeighborNButtons = new Zork.Builder.NeighborButtons();
            this.NameRoomtextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Roomslabel = new System.Windows.Forms.Label();
            this.StartingLocationcomboBox = new System.Windows.Forms.ComboBox();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StartingLocationlabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.WelcometextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.WelcomeMessagelabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.NeighborsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.AccessibleDescription = "";
            this.Tab.AccessibleName = "";
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Location = new System.Drawing.Point(0, 27);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(574, 461);
            this.Tab.TabIndex = 7;
            this.Tab.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.RoomlistBox);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.DescriptiontextBox);
            this.tabPage1.Controls.Add(this.Descriptionlabel);
            this.tabPage1.Controls.Add(this.NeighborsgroupBox);
            this.tabPage1.Controls.Add(this.NameRoomtextBox);
            this.tabPage1.Controls.Add(this.Namelabel);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.Roomslabel);
            this.tabPage1.Controls.Add(this.StartingLocationcomboBox);
            this.tabPage1.Controls.Add(this.StartingLocationlabel);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "World";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RoomlistBox
            // 
            this.RoomlistBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomlistBox.DataSource = this.roomsBindingSource;
            this.RoomlistBox.DisplayMember = "Name";
            this.RoomlistBox.FormattingEnabled = true;
            this.RoomlistBox.Location = new System.Drawing.Point(11, 70);
            this.RoomlistBox.Name = "RoomlistBox";
            this.RoomlistBox.Size = new System.Drawing.Size(153, 303);
            this.RoomlistBox.TabIndex = 18;
            this.RoomlistBox.ValueMember = "Description";
            this.RoomlistBox.SelectedIndexChanged += new System.EventHandler(this.RoomlistBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Design.ViewModel.GameViewModel);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DescriptiontextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.NeighborsgroupBox.Controls.Add(this.Westlabel);
            this.NeighborsgroupBox.Controls.Add(this.Southlabel);
            this.NeighborsgroupBox.Controls.Add(this.Northlabel);
            this.NeighborsgroupBox.Controls.Add(this.neighborButtons3);
            this.NeighborsgroupBox.Controls.Add(this.neighborButtons2);
            this.NeighborsgroupBox.Controls.Add(this.neighborElabel);
            this.NeighborsgroupBox.Controls.Add(this.neighborButtons1);
            this.NeighborsgroupBox.Controls.Add(this.NeighborNButtons);
            this.NeighborsgroupBox.Location = new System.Drawing.Point(185, 209);
            this.NeighborsgroupBox.Name = "NeighborsgroupBox";
            this.NeighborsgroupBox.Size = new System.Drawing.Size(368, 196);
            this.NeighborsgroupBox.TabIndex = 14;
            this.NeighborsgroupBox.TabStop = false;
            this.NeighborsgroupBox.Text = "Neighbors";
            // 
            // Westlabel
            // 
            this.Westlabel.AutoSize = true;
            this.Westlabel.BackColor = System.Drawing.Color.Gainsboro;
            this.Westlabel.Location = new System.Drawing.Point(55, 97);
            this.Westlabel.Name = "Westlabel";
            this.Westlabel.Size = new System.Drawing.Size(32, 13);
            this.Westlabel.TabIndex = 28;
            this.Westlabel.Text = "West";
            // 
            // Southlabel
            // 
            this.Southlabel.AutoSize = true;
            this.Southlabel.BackColor = System.Drawing.Color.Gainsboro;
            this.Southlabel.Location = new System.Drawing.Point(165, 153);
            this.Southlabel.Name = "Southlabel";
            this.Southlabel.Size = new System.Drawing.Size(35, 13);
            this.Southlabel.TabIndex = 27;
            this.Southlabel.Text = "South";
            // 
            // Northlabel
            // 
            this.Northlabel.AutoSize = true;
            this.Northlabel.BackColor = System.Drawing.Color.Gainsboro;
            this.Northlabel.Location = new System.Drawing.Point(165, 26);
            this.Northlabel.Name = "Northlabel";
            this.Northlabel.Size = new System.Drawing.Size(33, 13);
            this.Northlabel.TabIndex = 26;
            this.Northlabel.Text = "North";
            // 
            // neighborButtons3
            // 
            this.neighborButtons3.AccessibleName = "East";
            this.neighborButtons3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.roomsBindingSource, "Neighbors", true));
            this.neighborButtons3.Location = new System.Drawing.Point(23, 81);
            this.neighborButtons3.Name = "neighborButtons3";
            this.neighborButtons3.Size = new System.Drawing.Size(102, 61);
            this.neighborButtons3.TabIndex = 25;
            // 
            // neighborButtons2
            // 
            this.neighborButtons2.AccessibleName = "East";
            this.neighborButtons2.Location = new System.Drawing.Point(131, 137);
            this.neighborButtons2.Name = "neighborButtons2";
            this.neighborButtons2.Size = new System.Drawing.Size(102, 61);
            this.neighborButtons2.TabIndex = 24;
            // 
            // neighborElabel
            // 
            this.neighborElabel.AutoSize = true;
            this.neighborElabel.BackColor = System.Drawing.Color.Gainsboro;
            this.neighborElabel.Location = new System.Drawing.Point(274, 97);
            this.neighborElabel.Name = "neighborElabel";
            this.neighborElabel.Size = new System.Drawing.Size(28, 13);
            this.neighborElabel.TabIndex = 21;
            this.neighborElabel.Text = "East";
            // 
            // neighborButtons1
            // 
            this.neighborButtons1.AccessibleName = "East";
            this.neighborButtons1.Location = new System.Drawing.Point(239, 81);
            this.neighborButtons1.Name = "neighborButtons1";
            this.neighborButtons1.Size = new System.Drawing.Size(102, 61);
            this.neighborButtons1.TabIndex = 23;
            // 
            // NeighborNButtons
            // 
            this.NeighborNButtons.Location = new System.Drawing.Point(131, 10);
            this.NeighborNButtons.Name = "NeighborNButtons";
            this.NeighborNButtons.Size = new System.Drawing.Size(102, 61);
            this.NeighborNButtons.TabIndex = 22;
            // 
            // NameRoomtextBox
            // 
            this.NameRoomtextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.NameRoomtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameRoomtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.roomsBindingSource, "Name", true));
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
            this.StartingLocationcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "StartingLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StartingLocationcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gameBindingSource, "StartingLocation", true));
            this.StartingLocationcomboBox.DataSource = this.gameBindingSource;
            this.StartingLocationcomboBox.DisplayMember = "StartingLocation";
            this.StartingLocationcomboBox.FormattingEnabled = true;
            this.StartingLocationcomboBox.Location = new System.Drawing.Point(11, 30);
            this.StartingLocationcomboBox.Name = "StartingLocationcomboBox";
            this.StartingLocationcomboBox.Size = new System.Drawing.Size(153, 21);
            this.StartingLocationcomboBox.TabIndex = 9;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataSource = typeof(Zork.Game);
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
            this.tabPage2.Controls.Add(this.textBox2);
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
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.gameBindingSource, "WelcomeMessage", true));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "ExitMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(6, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(522, 20);
            this.textBox2.TabIndex = 7;
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
            this.WelcometextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.gameBindingSource, "WelcomeMessage", true));
            this.WelcometextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "WelcomeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            this.FileNameLabel.Size = new System.Drawing.Size(38, 13);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "Name:";
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
            this.closeToolStripMenuItem,
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
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.closeToolStripMenuItem.Text = "Close";
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
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.NeighborsgroupBox.ResumeLayout(false);
            this.NeighborsgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.GroupBox NeighborsgroupBox;
        private System.Windows.Forms.Label neighborElabel;
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
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox RoomlistBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private NeighborButtons NeighborNButtons;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private NeighborButtons neighborButtons1;
        private NeighborButtons neighborButtons3;
        private NeighborButtons neighborButtons2;
        private System.Windows.Forms.Label Westlabel;
        private System.Windows.Forms.Label Southlabel;
        private System.Windows.Forms.Label Northlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Exitlabel;
    }
}