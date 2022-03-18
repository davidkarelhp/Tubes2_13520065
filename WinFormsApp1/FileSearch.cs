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

        public static void BFS(Microsoft.Msagl.Drawing.Graph graph, string curPath, bool allOccurence)
        {
            targetPathQueue.Clear();
            Queue<string> BFSQueue = new Queue<string>();
            Stack<string> BFSStack = new Stack<string>();
            LinkedList<string> BFSLL = new LinkedList<string>();
            Dictionary<string, bool> myMap = new Dictionary<string, bool>();
            Dictionary<string, string> previousPaths = new Dictionary<string, string>();

            BFSQueue.Enqueue(curPath);
            /*BFSLL.AddLast(curPath);*/

            /*            string prevPath = null;
            */
            previousPaths[curPath] = null;

            while (BFSQueue.Count != 0)
            {
                string tempPath = BFSQueue.Dequeue();
                string curTarget = tempPath + "\\" + target;


                string prevPath = previousPaths[tempPath];
                if (prevPath == null)
                {
                    graph.AddNode(tempPath);
                }
                else
                {
                    BFSStack.Push(tempPath);
                    BFSLL.AddLast(prevPath);
                    graph.AddEdge(prevPath, tempPath);
                    graph.FindNode(tempPath).LabelText = tempPath.Substring(prevPath.Length + 1);
                }

                string[] files = Directory.GetFiles(tempPath, "*");
                bool found = false;

                int n = tempPath.Length;
                foreach (string file in files)
                {

                    graph.AddEdge(tempPath, file);
                    graph.FindNode(file).LabelText = file.Substring(n + 1);
                    graph.FindNode(file).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Ellipse;
                    BFSStack.Push(file);
                    BFSLL.AddLast(tempPath);
                    previousPaths[file] = tempPath;

                    if (file == curTarget)
                    {
                        graph.FindNode(file).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        found = true;
                        targetPathQueue.Enqueue(tempPath);
                        myMap[file] = true;

                        if (!allOccurence)
                        {
                            break;
                        }
                    }
                    else
                    {
                        graph.FindNode(file).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }

                if (!allOccurence && found)
                {
                    break;
                }
                else
                {
                    string[] directories = Directory.GetDirectories(tempPath);
                    bool tempFound;

                    foreach (string directory in directories)
                    {
                        previousPaths[directory] = tempPath;
                        BFSQueue.Enqueue(directory);
                    }
                }
            }

            bool foundTarget = false;
            /*foreach (string path in BFSLL)
            {

                string tempPath = BFSStack.Pop();

                if (myMap.ContainsKey(tempPath))
                {
                    foundTarget = true;
                    myMap[path] = true;
                    graph.FindNode(path).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                }
                else
                {
                    if (graph.FindNode(path).Attr.Color != Microsoft.Msagl.Drawing.Color.Blue)
                        graph.FindNode(path).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
            }*/

            while (BFSStack.Count != 0)
            {

                string tempPath = BFSStack.Pop();
                string prevPath = previousPaths[tempPath];

                if (myMap.ContainsKey(tempPath))
                {
                    foundTarget = true;
                    myMap[prevPath] = true;
                    graph.FindNode(prevPath).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                }
                else
                {
                    if (graph.FindNode(prevPath).Attr.Color != Microsoft.Msagl.Drawing.Color.Blue)
                        graph.FindNode(prevPath).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
            }

            graph.FindNode(curPath).Attr.Color = foundTarget ? Microsoft.Msagl.Drawing.Color.Blue : Microsoft.Msagl.Drawing.Color.Red;
        }
    }
}
