namespace PlagueInc
{
    partial class Frontend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation1 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
            this.numericTimeSet = new System.Windows.Forms.NumericUpDown();
            this.mapFileBtn = new System.Windows.Forms.Button();
            this.fileInput = new System.Windows.Forms.GroupBox();
            this.popFilePathInp = new System.Windows.Forms.TextBox();
            this.mapFilePathInp = new System.Windows.Forms.TextBox();
            this.popFileBtn = new System.Windows.Forms.Button();
            this.popFileLbl = new System.Windows.Forms.Label();
            this.mapFileLbl = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.graphOutput = new System.Windows.Forms.GroupBox();
            this.gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.inputTime = new System.Windows.Forms.GroupBox();
            this.autoCalcCheck = new System.Windows.Forms.CheckBox();
            this.autoCalcLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.calculateBFS = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeSet)).BeginInit();
            this.fileInput.SuspendLayout();
            this.graphOutput.SuspendLayout();
            this.inputTime.SuspendLayout();
            this.calculateBFS.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericTimeSet
            // 
            this.numericTimeSet.Location = new System.Drawing.Point(60, 25);
            this.numericTimeSet.Name = "numericTimeSet";
            this.numericTimeSet.Size = new System.Drawing.Size(90, 20);
            this.numericTimeSet.TabIndex = 2;
            this.numericTimeSet.ValueChanged += new System.EventHandler(this.numericTimeSet_ValueChanged);
            // 
            // mapFileBtn
            // 
            this.mapFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapFileBtn.Location = new System.Drawing.Point(518, 24);
            this.mapFileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapFileBtn.Name = "mapFileBtn";
            this.mapFileBtn.Size = new System.Drawing.Size(22, 19);
            this.mapFileBtn.TabIndex = 4;
            this.mapFileBtn.Text = "...";
            this.mapFileBtn.UseVisualStyleBackColor = true;
            this.mapFileBtn.Click += new System.EventHandler(this.mapFileBtn_Click);
            // 
            // fileInput
            // 
            this.fileInput.Controls.Add(this.popFilePathInp);
            this.fileInput.Controls.Add(this.mapFilePathInp);
            this.fileInput.Controls.Add(this.popFileBtn);
            this.fileInput.Controls.Add(this.popFileLbl);
            this.fileInput.Controls.Add(this.mapFileLbl);
            this.fileInput.Controls.Add(this.mapFileBtn);
            this.fileInput.Location = new System.Drawing.Point(23, 559);
            this.fileInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileInput.Name = "fileInput";
            this.fileInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileInput.Size = new System.Drawing.Size(545, 90);
            this.fileInput.TabIndex = 6;
            this.fileInput.TabStop = false;
            this.fileInput.Text = "File Input";
            // 
            // popFilePathInp
            // 
            this.popFilePathInp.Location = new System.Drawing.Point(96, 58);
            this.popFilePathInp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.popFilePathInp.Name = "popFilePathInp";
            this.popFilePathInp.Size = new System.Drawing.Size(418, 20);
            this.popFilePathInp.TabIndex = 11;
            this.popFilePathInp.TextChanged += new System.EventHandler(this.popFilePathInp_TextChanged);
            // 
            // mapFilePathInp
            // 
            this.mapFilePathInp.Location = new System.Drawing.Point(96, 24);
            this.mapFilePathInp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapFilePathInp.Name = "mapFilePathInp";
            this.mapFilePathInp.Size = new System.Drawing.Size(418, 20);
            this.mapFilePathInp.TabIndex = 10;
            this.mapFilePathInp.TextChanged += new System.EventHandler(this.mapFilePathInp_TextChanged);
            // 
            // popFileBtn
            // 
            this.popFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popFileBtn.Location = new System.Drawing.Point(518, 58);
            this.popFileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.popFileBtn.Name = "popFileBtn";
            this.popFileBtn.Size = new System.Drawing.Size(22, 19);
            this.popFileBtn.TabIndex = 9;
            this.popFileBtn.Text = "...";
            this.popFileBtn.UseVisualStyleBackColor = true;
            this.popFileBtn.Click += new System.EventHandler(this.popFileBtn_Click);
            // 
            // popFileLbl
            // 
            this.popFileLbl.AutoSize = true;
            this.popFileLbl.Location = new System.Drawing.Point(14, 61);
            this.popFileLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popFileLbl.Name = "popFileLbl";
            this.popFileLbl.Size = new System.Drawing.Size(76, 13);
            this.popFileLbl.TabIndex = 6;
            this.popFileLbl.Text = "Population File";
            // 
            // mapFileLbl
            // 
            this.mapFileLbl.AutoSize = true;
            this.mapFileLbl.Location = new System.Drawing.Point(14, 27);
            this.mapFileLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mapFileLbl.Name = "mapFileLbl";
            this.mapFileLbl.Size = new System.Drawing.Size(47, 13);
            this.mapFileLbl.TabIndex = 5;
            this.mapFileLbl.Text = "Map File";
            this.mapFileLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // graphOutput
            // 
            this.graphOutput.Controls.Add(this.gViewer);
            this.graphOutput.Location = new System.Drawing.Point(23, 20);
            this.graphOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graphOutput.Name = "graphOutput";
            this.graphOutput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graphOutput.Size = new System.Drawing.Size(800, 523);
            this.graphOutput.TabIndex = 7;
            this.graphOutput.TabStop = false;
            this.graphOutput.Text = "Graph Output";
            // 
            // gViewer
            // 
            this.gViewer.ArrowheadLength = 10D;
            this.gViewer.AsyncLayout = false;
            this.gViewer.AutoScroll = true;
            this.gViewer.BackwardEnabled = false;
            this.gViewer.BuildHitTree = true;
            this.gViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer.EdgeInsertButtonVisible = true;
            this.gViewer.FileName = "";
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = true;
            this.gViewer.Location = new System.Drawing.Point(16, 27);
            this.gViewer.LooseOffsetForRouting = 0.25D;
            this.gViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gViewer.MouseHitDistance = 0.05D;
            this.gViewer.Name = "gViewer";
            this.gViewer.NavigationVisible = true;
            this.gViewer.NeedToCalculateLayout = true;
            this.gViewer.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer.PaddingForEdgeRouting = 8D;
            this.gViewer.PanButtonPressed = false;
            this.gViewer.SaveAsImageEnabled = true;
            this.gViewer.SaveAsMsaglEnabled = true;
            this.gViewer.SaveButtonVisible = true;
            this.gViewer.SaveGraphButtonVisible = true;
            this.gViewer.SaveInVectorFormatEnabled = true;
            this.gViewer.Size = new System.Drawing.Size(766, 474);
            this.gViewer.TabIndex = 0;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = true;
            this.gViewer.Transform = planeTransformation1;
            this.gViewer.UndoRedoButtonsVisible = true;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // inputTime
            // 
            this.inputTime.Controls.Add(this.autoCalcCheck);
            this.inputTime.Controls.Add(this.autoCalcLbl);
            this.inputTime.Controls.Add(this.timeLbl);
            this.inputTime.Controls.Add(this.numericTimeSet);
            this.inputTime.Location = new System.Drawing.Point(573, 559);
            this.inputTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTime.Name = "inputTime";
            this.inputTime.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTime.Size = new System.Drawing.Size(155, 90);
            this.inputTime.TabIndex = 8;
            this.inputTime.TabStop = false;
            this.inputTime.Text = "Input Time";
            // 
            // autoCalcCheck
            // 
            this.autoCalcCheck.AutoSize = true;
            this.autoCalcCheck.Location = new System.Drawing.Point(60, 60);
            this.autoCalcCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.autoCalcCheck.Name = "autoCalcCheck";
            this.autoCalcCheck.Size = new System.Drawing.Size(15, 14);
            this.autoCalcCheck.TabIndex = 14;
            this.autoCalcCheck.UseVisualStyleBackColor = true;
            // 
            // autoCalcLbl
            // 
            this.autoCalcLbl.AutoSize = true;
            this.autoCalcLbl.Location = new System.Drawing.Point(4, 61);
            this.autoCalcLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autoCalcLbl.Name = "autoCalcLbl";
            this.autoCalcLbl.Size = new System.Drawing.Size(53, 13);
            this.autoCalcLbl.TabIndex = 13;
            this.autoCalcLbl.Text = "Auto Calc";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(4, 27);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(30, 13);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "Time";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(5, 24);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(80, 52);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Kalkulasi";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // calculateBFS
            // 
            this.calculateBFS.Controls.Add(this.btnCalc);
            this.calculateBFS.Location = new System.Drawing.Point(733, 559);
            this.calculateBFS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateBFS.Name = "calculateBFS";
            this.calculateBFS.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateBFS.Size = new System.Drawing.Size(91, 90);
            this.calculateBFS.TabIndex = 13;
            this.calculateBFS.TabStop = false;
            this.calculateBFS.Text = "Calculate BFS";
            // 
            // Frontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 602);
            this.Controls.Add(this.calculateBFS);
            this.Controls.Add(this.inputTime);
            this.Controls.Add(this.graphOutput);
            this.Controls.Add(this.fileInput);
            this.Name = "Frontend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.T. Wabah";
            this.Load += new System.EventHandler(this.Frontend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeSet)).EndInit();
            this.fileInput.ResumeLayout(false);
            this.fileInput.PerformLayout();
            this.graphOutput.ResumeLayout(false);
            this.inputTime.ResumeLayout(false);
            this.inputTime.PerformLayout();
            this.calculateBFS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericTimeSet;
        private System.Windows.Forms.Button mapFileBtn;
        private System.Windows.Forms.GroupBox fileInput;
        private System.Windows.Forms.Label mapFileLbl;
        private System.Windows.Forms.Label popFileLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button popFileBtn;
        private System.Windows.Forms.TextBox popFilePathInp;
        private System.Windows.Forms.TextBox mapFilePathInp;
        private System.Windows.Forms.GroupBox graphOutput;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
        private System.Windows.Forms.GroupBox inputTime;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox calculateBFS;
        private System.Windows.Forms.Label autoCalcLbl;
        private System.Windows.Forms.CheckBox autoCalcCheck;
    }
}

