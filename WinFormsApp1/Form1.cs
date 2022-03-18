using Microsoft.Msagl.GraphViewerGdi;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FileSearch.directory = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GViewer viewer = new GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            FileSearch.target = textBoxFileName.Text;

            /*FileSearch.DFS(graph, FileSearch.directory, checkBoxFindAllOccurence.Checked);*/

            FileSearch.BFS(graph, FileSearch.directory, checkBoxFindAllOccurence.Checked);

            viewer.Graph = graph;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
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
            newPanel.RowCount = FileSearch.targetPathQueue.Count;
            newPanel.ColumnCount = 1;
            newPanel.AutoScroll = true;

            int rowCount = 0;
            while (FileSearch.targetPathQueue.Count != 0)
            {
                string path = FileSearch.targetPathQueue.Dequeue();
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
            System.Diagnostics.Process.Start("explorer.exe", e.Link.LinkData as string);
        }

        private void panelTree_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}