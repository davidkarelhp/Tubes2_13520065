namespace WinFormsApp1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.checkBoxFindAllOccurence = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            this.panelHyperlink = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.checkBoxFindAllOccurence);
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.textBoxFileName);
            this.panelMenu.Controls.Add(this.btnPickFolder);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // checkBoxFindAllOccurence
            // 
            this.checkBoxFindAllOccurence.AutoSize = true;
            this.checkBoxFindAllOccurence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFindAllOccurence.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxFindAllOccurence.Location = new System.Drawing.Point(13, 151);
            this.checkBoxFindAllOccurence.Name = "checkBoxFindAllOccurence";
            this.checkBoxFindAllOccurence.Size = new System.Drawing.Size(197, 29);
            this.checkBoxFindAllOccurence.TabIndex = 3;
            this.checkBoxFindAllOccurence.Text = "Find All Occurence";
            this.checkBoxFindAllOccurence.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Location = new System.Drawing.Point(0, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 60);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(10, 188);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.PlaceholderText = "Insert file name here";
            this.textBoxFileName.Size = new System.Drawing.Size(202, 31);
            this.textBoxFileName.TabIndex = 0;
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPickFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPickFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPickFolder.Image = global::WinFormsApp1.Properties.Resources.icons8_search_folder_40;
            this.btnPickFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPickFolder.Location = new System.Drawing.Point(0, 80);
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPickFolder.Size = new System.Drawing.Size(220, 60);
            this.btnPickFolder.TabIndex = 1;
            this.btnPickFolder.Text = "   Pick Folder";
            this.btnPickFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPickFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPickFolder.UseVisualStyleBackColor = true;
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 0);
            this.panel1.TabIndex = 1;
            // 
            // panelTree
            // 
            this.panelTree.AutoScroll = true;
            this.panelTree.BackColor = System.Drawing.SystemColors.Control;
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTree.Location = new System.Drawing.Point(220, 0);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(580, 350);
            this.panelTree.TabIndex = 3;
            this.panelTree.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTree_Paint);
            // 
            // panelHyperlink
            // 
            this.panelHyperlink.BackColor = System.Drawing.Color.Gold;
            this.panelHyperlink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHyperlink.Location = new System.Drawing.Point(220, 350);
            this.panelHyperlink.Name = "panelHyperlink";
            this.panelHyperlink.Size = new System.Drawing.Size(580, 100);
            this.panelHyperlink.TabIndex = 4;
            this.panelHyperlink.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.panelHyperlink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panelMenu;
        private Button btnPickFolder;
        private Panel panelLogo;
        private Panel panel1;
        private Panel panelTree;
        private TextBox textBoxFileName;
        private Button btnSearch;
        private CheckBox checkBoxFindAllOccurence;
        private Panel panelHyperlink;
    }
}