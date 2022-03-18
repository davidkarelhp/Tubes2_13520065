using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class FileTraversal
    {
        private static void colorPathRed(Microsoft.Msagl.Drawing.Node node)
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
        private static void colorPathBlue(Microsoft.Msagl.Drawing.Node node)
        {
            node.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;

            foreach (Microsoft.Msagl.Drawing.Edge edge in node.InEdges)
            {
                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                colorPathBlue(edge.SourceNode);
            }
        }
        public static void TraverseTreeBFS(Microsoft.Msagl.Drawing.Graph graph, Queue<string> targetPathQueue, string root, string target, bool allOccurence)
        {
            Queue<Microsoft.Msagl.Drawing.Node> dirs = new Queue<Microsoft.Msagl.Drawing.Node>();

            Microsoft.Msagl.Drawing.Node rootNode = new Microsoft.Msagl.Drawing.Node(root);
            graph.AddNode(rootNode);
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

                    if (fileNode.LabelText == target)
                    {
                        colorPathBlue(fileNode);
                        targetPathQueue.Enqueue(file);

                        if (!allOccurence)
                        {
                            dirs.Clear();
                        }
                    }
                    else
                    {
                        colorPathRed(fileNode);
                    }
                }

                string[] subDirs = Directory.GetDirectories(curDir);

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
                }
            }
        }
        public static void TraverseTreeDFS(Microsoft.Msagl.Drawing.Graph graph, Queue<string> targetPathQueue, string root, string target, bool allOccurence)
        {
            Stack<Microsoft.Msagl.Drawing.Node> dirs = new Stack<Microsoft.Msagl.Drawing.Node>();

            Microsoft.Msagl.Drawing.Node rootNode = new Microsoft.Msagl.Drawing.Node(root);
            graph.AddNode(rootNode);
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

                    if (fileNode.LabelText == target)
                    {
                        colorPathBlue(fileNode);
                        targetPathQueue.Enqueue(file);

                        if (!allOccurence)
                        {
                            dirs.Clear();
                        }
                    }
                    else
                    {
                        colorPathRed(fileNode);
                    }
                }

                string[] subDirs = Directory.GetDirectories(curDir);

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
                }
            }
        }
    }
}
