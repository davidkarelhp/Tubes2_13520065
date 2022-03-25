using Microsoft.Msagl.GraphViewerGdi;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        private string directory, target;
        private int rowCount;
        private void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        private void colorPathRed(Microsoft.Msagl.Drawing.Node node)
        {
            if (node.Attr.Color != Microsoft.Msagl.Drawing.Color.Blue)
            {
                node.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

                foreach (Microsoft.Msagl.Drawing.Edge edge in node.InEdges)
                {
                    edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    colorPathRed(edge.SourceNode);
                }
            }
        }
        private void colorPathBlue(Microsoft.Msagl.Drawing.Node node)
        {
            node.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;

            foreach (Microsoft.Msagl.Drawing.Edge edge in node.InEdges)
            {
                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                colorPathBlue(edge.SourceNode);
            }
        }
        private void TraverseTreeBFS(Microsoft.Msagl.Drawing.Graph graph, GViewer viewer, TableLayoutPanel newPanel, string root, string target, bool allOccurence)
        {
            Queue<Microsoft.Msagl.Drawing.Node> dirs = new Queue<Microsoft.Msagl.Drawing.Node>();
            bool isStop = false;

            Microsoft.Msagl.Drawing.Node rootNode = new Microsoft.Msagl.Drawing.Node(root);
            graph.AddNode(rootNode);

            viewer.Graph = graph;
            panelTree.SuspendLayout();
            panelTree.Controls.Clear();
            panelTree.Controls.Add(viewer);
            panelTree.ResumeLayout();

            dirs.Enqueue(rootNode);

            while (dirs.Count > 0)
            {
                Microsoft.Msagl.Drawing.Node curNode = dirs.Dequeue();
                string curDir = curNode.Id;
                string[] files = Directory.GetFiles(curDir);

                foreach (string file in files)
                {
                    Microsoft.Msagl.Drawing.Node fileNode = new Microsoft.Msagl.Drawing.Node(file);
                    fileNode.LabelText = Path.GetFileName(file);
                    fileNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;
                    fileNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                    graph.AddNode(fileNode);

                    Microsoft.Msagl.Drawing.Edge fileEdge = new Microsoft.Msagl.Drawing.Edge(curNode, fileNode, Microsoft.Msagl.Drawing.ConnectionToGraph.Connected);
                    fileEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                    graph.AddPrecalculatedEdge(fileEdge);

                    wait(500);
                    viewer.Graph = graph;
                    panelTree.SuspendLayout();
                    panelTree.Controls.Clear();
                    panelTree.Controls.Add(viewer);
                    panelTree.ResumeLayout();

                    wait(500);

                    if (fileNode.LabelText == target)
                    {
                        colorPathBlue(fileNode);

                        panelHyperlink.SuspendLayout();
                        panelHyperlink.Controls.Clear();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Dock = DockStyle.Fill;
                        linkLabel.Text = file;
                        linkLabel.LinkColor = Color.Black;
                        linkLabel.Links.Add(0, file.Length, Path.GetDirectoryName(file));
                        linkLabel.LinkClicked += OnLinkClicked;
                        newPanel.Controls.Add(linkLabel, 0, this.rowCount);
                        this.rowCount++;

                        panelHyperlink.Controls.Add(newPanel);
                        panelHyperlink.ResumeLayout();

                        if (!allOccurence)
                        {
                            dirs.Clear();
                            isStop = true;
                        }
                    }
                    else
                    {
                        colorPathRed(fileNode);
                    }

                    viewer.Graph = graph;
                    panelTree.SuspendLayout();
                    panelTree.Controls.Clear();
                    panelTree.Controls.Add(viewer);
                    panelTree.ResumeLayout();

                    if (isStop)
                    {
                        break;
                    }

                }

                if (!isStop)
                {
                    string[] subDirs = Directory.GetDirectories(curDir);

                    if (subDirs.Length > 0)
                    {
                        foreach (string subDir in subDirs)
                        {
                            Microsoft.Msagl.Drawing.Node subDirNode = new Microsoft.Msagl.Drawing.Node(subDir);
                            subDirNode.LabelText = Path.GetFileName(subDir);
                            subDirNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
                            subDirNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                            graph.AddNode(subDirNode);

                            Microsoft.Msagl.Drawing.Edge subDirEdge = new Microsoft.Msagl.Drawing.Edge(curNode, subDirNode, Microsoft.Msagl.Drawing.ConnectionToGraph.Connected);
                            subDirEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                            graph.AddPrecalculatedEdge(subDirEdge);

                            dirs.Enqueue(subDirNode);

                            wait(500);

                            viewer.Graph = graph;
                            panelTree.SuspendLayout();
                            panelTree.Controls.Clear();
                            panelTree.Controls.Add(viewer);
                            panelTree.ResumeLayout();
                        }
                    } 
                    else
                    {
                        wait(500);

                        colorPathRed(curNode);

                        viewer.Graph = graph;
                        panelTree.SuspendLayout();
                        panelTree.Controls.Clear();
                        panelTree.Controls.Add(viewer);
                        panelTree.ResumeLayout();
                    }
                }
            }
        }
        private void TraverseTreeDFS(Microsoft.Msagl.Drawing.Graph graph, GViewer viewer, TableLayoutPanel newPanel, string root, string target, bool allOccurence)
        {
            Stack<Microsoft.Msagl.Drawing.Node> dirs = new Stack<Microsoft.Msagl.Drawing.Node>();
            bool isStop = false;

            Microsoft.Msagl.Drawing.Node rootNode = new Microsoft.Msagl.Drawing.Node(root);
            graph.AddNode(rootNode);

            viewer.Graph = graph;
            panelTree.SuspendLayout();
            panelTree.Controls.Clear();
            panelTree.Controls.Add(viewer);
            panelTree.ResumeLayout();

            dirs.Push(rootNode);

            while (dirs.Count > 0)
            {
                Microsoft.Msagl.Drawing.Node curNode = dirs.Pop();
                string curDir = curNode.Id;
                string[] files = Directory.GetFiles(curDir);

                foreach (string file in files)
                {
                    Microsoft.Msagl.Drawing.Node fileNode = new Microsoft.Msagl.Drawing.Node(file);
                    fileNode.LabelText = Path.GetFileName(file);
                    fileNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;
                    fileNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                    graph.AddNode(fileNode);

                    Microsoft.Msagl.Drawing.Edge fileEdge = new Microsoft.Msagl.Drawing.Edge(curNode, fileNode, Microsoft.Msagl.Drawing.ConnectionToGraph.Connected);
                    fileEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                    graph.AddPrecalculatedEdge(fileEdge);

                    wait(500);
                    viewer.Graph = graph;
                    panelTree.SuspendLayout();
                    panelTree.Controls.Clear();
                    panelTree.Controls.Add(viewer);
                    panelTree.ResumeLayout();

                    wait(500);

                    if (fileNode.LabelText == target)
                    {
                        colorPathBlue(fileNode);

                        panelHyperlink.SuspendLayout();
                        panelHyperlink.Controls.Clear();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Dock = DockStyle.Fill;
                        linkLabel.Text = file;
                        linkLabel.LinkColor = Color.Black;
                        linkLabel.Links.Add(0, file.Length, Path.GetDirectoryName(file));
                        linkLabel.LinkClicked += OnLinkClicked;
                        newPanel.Controls.Add(linkLabel, 0, this.rowCount);
                        this.rowCount++;

                        panelHyperlink.Controls.Add(newPanel);
                        panelHyperlink.ResumeLayout();

                        if (!allOccurence)
                        {
                            dirs.Clear();
                            isStop = true;
                        }
                    }
                    else
                    {
                        colorPathRed(fileNode);
                    }

                    viewer.Graph = graph;
                    panelTree.SuspendLayout();
                    panelTree.Controls.Clear();
                    panelTree.Controls.Add(viewer);
                    panelTree.ResumeLayout();

                    if (isStop)
                    {
                        break;
                    }
                }

                if (!isStop)
                {
                    string[] subDirs = Directory.GetDirectories(curDir);

                    if (subDirs.Length > 0)
                    {
                        foreach (string subDir in subDirs)
                        {
                            Microsoft.Msagl.Drawing.Node subDirNode = new Microsoft.Msagl.Drawing.Node(subDir);
                            subDirNode.LabelText = Path.GetFileName(subDir);
                            subDirNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
                            subDirNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                            graph.AddNode(subDirNode);

                            Microsoft.Msagl.Drawing.Edge subDirEdge = new Microsoft.Msagl.Drawing.Edge(curNode, subDirNode, Microsoft.Msagl.Drawing.ConnectionToGraph.Connected);
                            subDirEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                            graph.AddPrecalculatedEdge(subDirEdge);

                            dirs.Push(subDirNode);

                            wait(500);

                            viewer.Graph = graph;
                            panelTree.SuspendLayout();
                            panelTree.Controls.Clear();
                            panelTree.Controls.Add(viewer);
                            panelTree.ResumeLayout();
                        }
                    }
                    else
                    {
                        wait(500);

                        colorPathRed(curNode);

                        viewer.Graph = graph;
                        panelTree.SuspendLayout();
                        panelTree.Controls.Clear();
                        panelTree.Controls.Add(viewer);
                        panelTree.ResumeLayout();
                    }
                    
                }
            }
        }
        private void displayTime(System.Diagnostics.Stopwatch stopwatch)
        {
            double seconds = (double)stopwatch.ElapsedMilliseconds / 1000;
            labelTimeElapsed.Text = String.Format("Time elapsed: {0} s", seconds);
        }
        public Form1()
        {
            InitializeComponent();
            this.directory = "";
            this.target = "";
            radioButtonDFS.Checked = true;
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.directory = folderBrowserDialog1.SelectedPath;
                if (this.directory.Length > 20)
                {
                    labelFolderName.Text = this.directory.Substring(0, 20) + "...";
                }
                else
                {
                    labelFolderName.Text = this.directory;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            labelTimeElapsed.Text = "Time elapsed: -";
            if (this.directory == "")
            {
                MessageBox.Show("Folder root belum dipilih!", "Warning!");
            } else if (textBoxFileName.Text == "")
            {
                MessageBox.Show("Nama file belum dimasukan!", "Warning!");
            }
              else
            {
                this.target = textBoxFileName.Text;

                Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                GViewer viewer = new GViewer();
                TableLayoutPanel newPanel = new TableLayoutPanel();
                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

                viewer.Dock = DockStyle.Fill;
                viewer.AutoScroll = true;
                viewer.OutsideAreaBrush = Brushes.White;
                viewer.ToolBarIsVisible = false;

                viewer.Graph = graph;
                panelTree.SuspendLayout();
                panelTree.Controls.Clear();
                panelTree.Controls.Add(viewer);
                panelTree.ResumeLayout();

                newPanel.Dock = DockStyle.Fill;
                newPanel.BackColor = Color.White;
                newPanel.ColumnCount = 1;
                newPanel.AutoScroll = true;

                panelHyperlink.SuspendLayout();
                panelHyperlink.Controls.Clear();
                panelHyperlink.Controls.Add(newPanel);
                panelHyperlink.ResumeLayout();

                this.rowCount = 0;

                stopwatch.Start();
                if (radioButtonBFS.Checked)
                {
                    TraverseTreeBFS(graph, viewer, newPanel, this.directory, this.target, checkBoxFindAllOccurence.Checked);
                } else
                {
                    TraverseTreeDFS(graph, viewer, newPanel, this.directory, this.target, checkBoxFindAllOccurence.Checked);
                }
                stopwatch.Stop();

                displayTime(stopwatch);

                panelTree.Show();

                panelHyperlink.Show();

            }
        }

        void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.Link.LinkData.ToString());
        }
    }
}