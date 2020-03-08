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
        string mapFile,populationFile;
        public Frontend()
        {
            InitializeComponent();
        }

        private void Frontend_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string fp1 = @"J:\Jovan's Stuff\ITB\IF04\IF4-Tubes\Tubes2Stima-PlagueInc\test1.txt";
            string fp2 = @"J:\Jovan's Stuff\ITB\IF04\IF4-Tubes\Tubes2Stima-PlagueInc\test2.txt";
            Microsoft.Msagl.GraphViewerGdi.GViewer tampil = CalculateGraph.Calculate(fp1, fp2);
            tampil.Dock = System.Windows.Forms.DockStyle.Fill;
            picDisplayGraph.Dock = tampil.Dock;      

        }

    }
}
