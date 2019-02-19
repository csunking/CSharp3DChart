namespace Scatter
{
    partial class ScatterPlot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ScatterPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ScatterPlot";
            this.Size = new System.Drawing.Size(200, 173);
            this.Load += new System.EventHandler(this.ScatterPlot_Load);
            this.SizeChanged += new System.EventHandler(this.ScatterPlot_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScatterPlot_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScatterPlot_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScatterPlot_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
