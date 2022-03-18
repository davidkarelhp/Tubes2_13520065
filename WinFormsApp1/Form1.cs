using Microsoft.Msagl.GraphViewerGdi;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        private string directory, target;
        public Form1()
        {
            InitializeComponent();
            this.directory = "";
            this.target = "";
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.directory = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.target = textBoxFileName.Text;

            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            Queue<string> targetPathQueue = new Queue<string>();

            if (radioButtonBFS.Checked)
            {
                FileTraversal.TraverseTreeBFS(graph, targetPathQueue, this.directory, this.target, checkBoxFindAllOccurence.Checked);
            } else
            {
                FileTraversal.TraverseTreeDFS(graph, targetPathQueue, this.directory, this.target, checkBoxFindAllOccurence.Checked);
            }

            GViewer viewer = new GViewer();
            viewer.Graph = graph;
            viewer.Dock = DockStyle.Fill;
            viewer.AutoScroll = true;
            viewer.OutsideAreaBrush = Brushes.White;
            viewer.ToolBarIsVisible = false;

            panelTree.SuspendLayout();
            panelTree.Controls.Clear();
            panelTree.Controls.Add(viewer);
            panelTree.ResumeLayout();
            panelTree.Show();

            panelHyperlink.SuspendLayout();
            panelHyperlink.Controls.Clear();

            TableLayoutPanel newPanel = new TableLayoutPanel();
            newPanel.Dock = DockStyle.Fill;
            newPanel.BackColor = Color.Gold;
            newPanel.RowCount = targetPathQueue.Count;
            newPanel.ColumnCount = 1;
            newPanel.AutoScroll = true;

            int rowCount = 0;
            while (targetPathQueue.Count != 0)
            {
                string path = targetPathQueue.Dequeue();
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Dock = DockStyle.Fill;
                linkLabel.Text = path;
                linkLabel.Links.Add(0, path.Length, path);
                linkLabel.LinkClicked += OnLinkClicked;
                newPanel.Controls.Add(linkLabel, 0, rowCount);
                rowCount++;
            }

            panelHyperlink.Controls.Add(newPanel);
            panelHyperlink.ResumeLayout();
            panelHyperlink.Show();
        }

        void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.Link.LinkData.ToString());
        }
    }
}