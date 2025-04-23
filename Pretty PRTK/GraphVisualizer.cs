using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace Pretty_PRTK
{
    public class GraphVisualizer
    {
        public void ShowGraph(Dictionary<string, List<string>> nodeEdges)
        {
            Form graphForm = new Form();
            GViewer viewer = new GViewer();
            Graph graph = new Graph("Generated Password Graph");

            foreach (var node in nodeEdges)
            {
                foreach (var connected in node.Value)
                {
                    graph.AddEdge(node.Key, connected);
                }

                if (node.Value.Count == 0)
                {
                    graph.AddNode(node.Key);
                }
            }

            viewer.Graph = graph;
            viewer.Dock = DockStyle.Fill;
            graphForm.Text = "Password Relationship Graph";
            graphForm.Width = 800;
            graphForm.Height = 600;
            graphForm.Controls.Add(viewer);
            graphForm.ShowDialog();
        }
    }
}
