namespace Calculator_Project
{
    partial class GraphForm
    {
        private System.ComponentModel.IContainer components = null;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Button btnPlot;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();

           
            this.txtExpression.Location = new System.Drawing.Point(12, 12);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(600, 23);
            this.txtExpression.TabIndex = 0;

          
            this.btnPlot.Location = new System.Drawing.Point(620, 10);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 27);
            this.btnPlot.TabIndex = 1;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.BtnPlot_Click);

            
            this.plotView.Location = new System.Drawing.Point(12, 50);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView.Size = new System.Drawing.Size(760, 500);
            this.plotView.TabIndex = 2;
            this.plotView.Text = "plotView1";  
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;

           
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.txtExpression);
            this.Name = "GraphForm";
            this.Text = "Graph Plotter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

