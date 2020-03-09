using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueInc
{
    public partial class Frontend : Form
    {
        string mapFilePath, popFilePath;
        public Frontend()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Frontend_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mapFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mapFilePath = mapFilePathInp.Text = openFileDialog.FileName;
                }
            }
        }

        private void popFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    popFilePath = popFilePathInp.Text = openFileDialog.FileName;
                }
            }
        }

        private void mapFilePathInp_TextChanged(object sender, EventArgs e)
        {
            mapFilePath = mapFilePathInp.Text;
        }

        private void popFilePathInp_TextChanged(object sender, EventArgs e)
        {
            popFilePath = popFilePathInp.Text;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(mapFilePath) || string.IsNullOrEmpty(popFilePath))
                    throw new System.InvalidOperationException("Map and population path can't be empty.");
                Graph g = FileReader.readGraphFromFile(mapFilePath, popFilePath);
                Microsoft.Msagl.Drawing.Graph gDraw = GraphConverter.graphConverter(g);
                gViewer.Graph = gDraw;
            }
            catch (System.InvalidOperationException err)
            {
                MessageBox.Show(err.Message, "File input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception _)
            {
                MessageBox.Show("There is error in graph calculation", "Graph calculation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
