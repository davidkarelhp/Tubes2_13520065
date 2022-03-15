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
            FileSearch.DFS(graph, FileSearch.directory);
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
        }
    }
}