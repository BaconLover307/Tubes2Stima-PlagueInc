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
            this.btnCalc = new System.Windows.Forms.Button();
            this.numericTimeSet = new System.Windows.Forms.NumericUpDown();
            this.picDisplayGraph = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(443, 636);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(99, 36);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Kalkulasi";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // numericTimeSet
            // 
            this.numericTimeSet.Location = new System.Drawing.Point(817, 652);
            this.numericTimeSet.Name = "numericTimeSet";
            this.numericTimeSet.Size = new System.Drawing.Size(97, 20);
            this.numericTimeSet.TabIndex = 2;
            // 
            // picDisplayGraph
            // 
            this.picDisplayGraph.Location = new System.Drawing.Point(90, 12);
            this.picDisplayGraph.Name = "picDisplayGraph";
            this.picDisplayGraph.Size = new System.Drawing.Size(800, 600);
            this.picDisplayGraph.TabIndex = 3;
            this.picDisplayGraph.TabStop = false;
            // 
            // Frontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.picDisplayGraph);
            this.Controls.Add(this.numericTimeSet);
            this.Controls.Add(this.btnCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frontend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.T. Wabah";
            this.Load += new System.EventHandler(this.Frontend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.NumericUpDown numericTimeSet;
        private System.Windows.Forms.PictureBox picDisplayGraph;
    }
}

