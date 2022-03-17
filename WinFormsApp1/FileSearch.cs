using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class FileSearch
    {
        public static string directory = "";
        public static string target = "";
        public static Queue<string> targetPathQueue = new Queue<string>();
        private static Boolean DFS(Microsoft.Msagl.Drawing.Graph graph, string prevPath, string curPath, bool allOccurence)
        {
            Boolean found = false;
            string curTarget = curPath + "\\" + target;
            graph.AddEdge(prevPath, curPath);
            graph.FindNode(curPath).LabelText = curPath.Substring(prevPath.Length + 1);

            string[] files = Directory.GetFiles(curPath, "*");
            int n = curPath.Length;
            

            foreach (string file in files)
            {
                graph.AddEdge(curPath, file);
                graph.FindNode(file).LabelText = file.Substring(n + 1);
                graph.FindNode(file).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;

                if (file == curTarget)
                {
                    graph.FindNode(file).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    found = true;
                    targetPathQueue.Enqueue(curPath);
                    if (!allOccurence)
                    {
                        return found;
                    }
                }
                else
                {
                    graph.FindNode(file).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
            }
            string[] directories = Directory.GetDirectories(curPath);
            bool tempFound;

            foreach (string directory in directories)
            {
                tempFound = DFS(graph, curPath, directory, allOccurence);

                if (!tempFound)
                {
                    graph.FindNode(directory).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                else if (tempFound)
                {
                    graph.FindNode(directory).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                }
                found = tempFound || found;

                if (!allOccurence && found)
                {
                    break;
                }
            }
            return found;
        }

        public static void DFS(Microsoft.Msagl.Drawing.Graph graph, string curPath, bool allOccurence)
        {
             targetPathQueue.Clear();
             Boolean found = false;
             string curTarget = curPath + "\\" + target;
             graph.AddNode(curPath);

             string[] files = Directory.GetFiles(curPath, "*");

             int n = curPath.Length;
             foreach (string file in files)
             {
                graph.AddEdge(curPath, file);
                 graph.FindNode(file).LabelText = file.Substring(n + 1);
                 graph.FindNode(file).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;

                 if (file == curTarget)
                 {
                     graph.FindNode(file).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                     found = true;
                     targetPathQueue.Enqueue(curPath);
                     if (!allOccurence)
                     {
                        return;
                     }
                 } else
                 {
                     graph.FindNode(file).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                 }
             }

             string[] directories = Directory.GetDirectories(curPath);
             bool tempFound;
             foreach (string directory in directories)
             {
                 tempFound = DFS(graph, curPath, directory, allOccurence);
                 if (!tempFound)
                 {
                     graph.FindNode(directory).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                 }
                 else if (tempFound)
                 {
                     graph.FindNode(directory).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                 }
                 found = tempFound || found;
                 if (!allOccurence && found)
                 {
                     break;
                 }
             }
             graph.FindNode(curPath).Attr.Color = found ? Microsoft.Msagl.Drawing.Color.Blue : Microsoft.Msagl.Drawing.Color.Red;
         }
    }
}
