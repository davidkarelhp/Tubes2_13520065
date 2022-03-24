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
            this.labelOptions = new System.Windows.Forms.Label();
            this.labelInputFileName = new System.Windows.Forms.Label();
            this.radioButtonBFS = new System.Windows.Forms.RadioButton();
            this.radioButtonDFS = new System.Windows.Forms.RadioButton();
            this.checkBoxFindAllOccurence = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            this.panelHyperlink = new System.Windows.Forms.Panel();
            this.panelHeaderOutput = new System.Windows.Forms.Panel();
            this.labelOutput = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeaderOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.labelOptions);
            this.panelMenu.Controls.Add(this.labelInputFileName);
            this.panelMenu.Controls.Add(this.radioButtonBFS);
            this.panelMenu.Controls.Add(this.radioButtonDFS);
            this.panelMenu.Controls.Add(this.checkBoxFindAllOccurence);
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.textBoxFileName);
            this.panelMenu.Controls.Add(this.btnPickFolder);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(377, 523);
            this.panelMenu.TabIndex = 0;
            // 
            // labelOptions
            // 
            this.labelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOptions.Location = new System.Drawing.Point(62, 247);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(79, 25);
            this.labelOptions.TabIndex = 7;
            this.labelOptions.Text = "Options";
            this.labelOptions.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelInputFileName
            // 
            this.labelInputFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInputFileName.AutoSize = true;
            this.labelInputFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInputFileName.Location = new System.Drawing.Point(62, 164);
            this.labelInputFileName.Name = "labelInputFileName";
            this.labelInputFileName.Size = new System.Drawing.Size(147, 25);
            this.labelInputFileName.TabIndex = 6;
            this.labelInputFileName.Text = "Input File Name";
            this.labelInputFileName.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonBFS
            // 
            this.radioButtonBFS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBFS.AutoSize = true;
            this.radioButtonBFS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonBFS.ForeColor = System.Drawing.Color.Black;
            this.radioButtonBFS.Location = new System.Drawing.Point(67, 310);
            this.radioButtonBFS.Name = "radioButtonBFS";
            this.radioButtonBFS.Size = new System.Drawing.Size(68, 29);
            this.radioButtonBFS.TabIndex = 5;
            this.radioButtonBFS.TabStop = true;
            this.radioButtonBFS.Text = "BFS";
            this.radioButtonBFS.UseVisualStyleBackColor = true;
            // 
            // radioButtonDFS
            // 
            this.radioButtonDFS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDFS.AutoSize = true;
            this.radioButtonDFS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDFS.ForeColor = System.Drawing.Color.Black;
            this.radioButtonDFS.Location = new System.Drawing.Point(66, 275);
            this.radioButtonDFS.Name = "radioButtonDFS";
            this.radioButtonDFS.Size = new System.Drawing.Size(69, 29);
            this.radioButtonDFS.TabIndex = 4;
            this.radioButtonDFS.TabStop = true;
            this.radioButtonDFS.Text = "DFS";
            this.radioButtonDFS.UseVisualStyleBackColor = true;
            // 
            // checkBoxFindAllOccurence
            // 
            this.checkBoxFindAllOccurence.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxFindAllOccurence.AutoSize = true;
            this.checkBoxFindAllOccurence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFindAllOccurence.ForeColor = System.Drawing.Color.Black;
            this.checkBoxFindAllOccurence.Location = new System.Drawing.Point(67, 408);
            this.checkBoxFindAllOccurence.Name = "checkBoxFindAllOccurence";
            this.checkBoxFindAllOccurence.Size = new System.Drawing.Size(197, 29);
            this.checkBoxFindAllOccurence.TabIndex = 3;
            this.checkBoxFindAllOccurence.Text = "Find All Occurence";
            this.checkBoxFindAllOccurence.UseVisualStyleBackColor = true;
            this.checkBoxFindAllOccurence.CheckedChanged += new System.EventHandler(this.checkBoxFindAllOccurence_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(66, 438);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10);
            this.btnSearch.Size = new System.Drawing.Size(240, 60);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(66, 192);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.PlaceholderText = "Type here...";
            this.textBoxFileName.Size = new System.Drawing.Size(200, 31);
            this.textBoxFileName.TabIndex = 0;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickFolder.BackColor = System.Drawing.Color.White;
            this.btnPickFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPickFolder.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPickFolder.FlatAppearance.BorderSize = 2;
            this.btnPickFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPickFolder.ForeColor = System.Drawing.Color.Black;
            this.btnPickFolder.Image = global::WinFormsApp1.Properties.Resources.icons8_search_folder_40;
            this.btnPickFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPickFolder.Location = new System.Drawing.Point(66, 86);
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPickFolder.Size = new System.Drawing.Size(238, 60);
            this.btnPickFolder.TabIndex = 1;
            this.btnPickFolder.Text = "   Pick Folder";
            this.btnPickFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPickFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPickFolder.UseVisualStyleBackColor = false;
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(375, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(377, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 0);
            this.panel1.TabIndex = 1;
            // 
            // panelTree
            // 
            this.panelTree.AutoScroll = true;
            this.panelTree.BackColor = System.Drawing.Color.White;
            this.panelTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTree.Location = new System.Drawing.Point(377, 80);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(794, 343);
            this.panelTree.TabIndex = 3;
            // 
            // panelHyperlink
            // 
            this.panelHyperlink.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHyperlink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHyperlink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHyperlink.Location = new System.Drawing.Point(377, 423);
            this.panelHyperlink.Name = "panelHyperlink";
            this.panelHyperlink.Size = new System.Drawing.Size(794, 100);
            this.panelHyperlink.TabIndex = 4;
            // 
            // panelHeaderOutput
            // 
            this.panelHeaderOutput.BackColor = System.Drawing.Color.White;
            this.panelHeaderOutput.Controls.Add(this.labelOutput);
            this.panelHeaderOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderOutput.Location = new System.Drawing.Point(377, 0);
            this.panelHeaderOutput.Name = "panelHeaderOutput";
            this.panelHeaderOutput.Size = new System.Drawing.Size(794, 80);
            this.panelHeaderOutput.TabIndex = 5;
            this.panelHeaderOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeaderOutput_Paint);
            // 
            // labelOutput
            // 
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOutput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOutput.Location = new System.Drawing.Point(0, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(794, 80);
            this.labelOutput.TabIndex = 0;
            this.labelOutput.Text = "OUTPUT";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 523);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.panelHeaderOutput);
            this.Controls.Add(this.panelHyperlink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Folder Crawling";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelHeaderOutput.ResumeLayout(false);
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
        private RadioButton radioButtonBFS;
        private RadioButton radioButtonDFS;
        private Label labelInputFileName;
        private Label labelOptions;
        private Panel panelHeaderOutput;
        private Label labelOutput;
        private Label label1;
    }
}