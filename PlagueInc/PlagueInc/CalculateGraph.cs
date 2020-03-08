namespace PlagueInc
{
    class CalculateGraph
     // Caculates and returns graph ready to display
    {
        public static Microsoft.Msagl.GraphViewerGdi.GViewer Calculate(string file1, string file2)
        {
            Graph g = FileReader.readGraphFromFile(file1, file2);
            System.Console.WriteLine(g); // console out

            // Convert graph
            Microsoft.Msagl.Drawing.Graph gDraw = GraphConverter.graphConverter(g);

            // Draw graph
            // Create viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            // Bind graph and viewer
            viewer.Graph = gDraw;
            // Add dockstyle
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;

            return viewer;
        }
    }
}