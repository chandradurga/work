using System.Threading;

namespace CounterThread
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCounter = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnsuspnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.crostwo = new System.Windows.Forms.ToolStripMenuItem();
            this.crs4 = new System.Windows.Forms.ToolStripMenuItem();
            this.crssix = new System.Windows.Forms.ToolStripMenuItem();
            this.crsxeight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCounter
            // 
            this.labelCounter.Location = new System.Drawing.Point(309, 62);
            this.labelCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(30, 35);
            this.labelCounter.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnsuspnd,
            this.toolStripButton3,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1304, 56);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 53);
            this.toolStripButton1.Text = "Start";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnsuspnd
            // 
            this.btnsuspnd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnsuspnd.Image = ((System.Drawing.Image)(resources.GetObject("btnsuspnd.Image")));
            this.btnsuspnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsuspnd.Name = "btnsuspnd";
            this.btnsuspnd.Size = new System.Drawing.Size(61, 53);
            this.btnsuspnd.Text = "Pause";
            this.btnsuspnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsuspnd.Click += new System.EventHandler(this.btnsuspnd_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(78, 53);
            this.toolStripButton3.Text = "Resume";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crostwo,
            this.crs4,
            this.crssix,
            this.crsxeight});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 53);
            this.toolStripDropDownButton1.Text = "Grid";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // crostwo
            // 
            this.crostwo.Name = "crostwo";
            this.crostwo.Size = new System.Drawing.Size(252, 30);
            this.crostwo.Text = "2x2";
            this.crostwo.Click += new System.EventHandler(this.crostwo_Click);
            // 
            // crs4
            // 
            this.crs4.Name = "crs4";
            this.crs4.Size = new System.Drawing.Size(252, 30);
            this.crs4.Text = "4X4";
            this.crs4.Click += new System.EventHandler(this.crs4_Click);
            // 
            // crssix
            // 
            this.crssix.Name = "crssix";
            this.crssix.Size = new System.Drawing.Size(252, 30);
            this.crssix.Text = "6X6";
            this.crssix.Click += new System.EventHandler(this.crssix_Click);
            // 
            // crsxeight
            // 
            this.crsxeight.Name = "crsxeight";
            this.crsxeight.Size = new System.Drawing.Size(252, 30);
            this.crsxeight.Text = "8X8";
            this.crsxeight.Click += new System.EventHandler(this.crsxeight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1304, 1050);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelCounter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatrixGridGeneration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnPaint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCounter;
        public Thread CounterThread;
        public bool bThreadStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnsuspnd;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem crostwo;
        private System.Windows.Forms.ToolStripMenuItem crs4;
        private System.Windows.Forms.ToolStripMenuItem crssix;
        private System.Windows.Forms.ToolStripMenuItem crsxeight;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    }
}

