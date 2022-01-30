using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CounterThread
{
    public partial class Form1 : Form
    {
        public int m_width; //Width of the grid cell

        public int m_Height; // The height of the Cell

        public int m_NoOfRows; // The Number Of Rows

        public int m_NoOfCols; // The Number Of Columns

        public int m_XOffset; //Offset from which drawing start
        public int m_YOffset;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 80;
        public const int DEFAULT_NO_ROWS = 2;
        public const int DEFAULT_NO_COLS = 2;
        public const int DEFAULT_WIDTH = 30;
        public const int DEFAULT_HEIGHT = 30;

        public Form1()
        {
            Initialize();

            InitializeComponent();
            bThreadStatus = false;
        }
        private void OnPaint(object sender, EventArgs e)
        {
            DrawGrid(2,2);
        }
        public void Initialize()
        {
            //Put all the default values
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            m_XOffset = DEFAULT_X_OFFSET;
            m_YOffset = DEFAULT_Y_OFFSET;

        }

        private void DrawGrid(int r,int c)
        {
            Graphics boardLayout = this.CreateGraphics();
            Pen layoutPen = new Pen(Color.Red);
            layoutPen.Width = 5;

            //boardLayout.DrawLine(layoutPen, 0, 0, 100, 0);
            int X = DEFAULT_X_OFFSET;
            int Y = DEFAULT_Y_OFFSET;
            m_NoOfRows = r;
            m_NoOfCols = c;
            //Draw The rows
            for (int i = 0; i <= m_NoOfRows; i++)
            {
                boardLayout.DrawLine(layoutPen, X, Y, X + this.m_width * this.m_NoOfCols, Y);
                Y = Y + m_Height;
            }

            //Draw The Cols
            X = DEFAULT_X_OFFSET;
            Y = DEFAULT_Y_OFFSET;
            for (int j = 0; j <= m_NoOfCols; j++)
            {
                boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_Height * this.m_NoOfRows);
                X = X + this.m_width;
            } 
            

        }


        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread = new Thread(new ThreadStart(ThreadCounter));
            CounterThread.Start();//starts the thread
            bThreadStatus = true;

        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread.Suspend();//Pauses the thread
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread.Resume(); //Resumes the thread
        }

        public void ThreadCounter()
        {
            try
            {
                while (true)
                {
                    DrawGrid(2,2);
                    
                    Thread.Sleep(500);
                    DrawGrid(4,4);
                    Thread.Sleep(500);
                    DrawGrid(6, 6);
                
                    Thread.Sleep(500);
                    DrawGrid(8, 8);
                
                    Thread.Sleep(500);
                }

            }
            catch (Exception ex)
            {

            }

        }

        private void threadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CounterThread = new Thread(new ThreadStart(ThreadCounter));
            CounterThread.Start();//starts the thread
            bThreadStatus = true;
        }

        private void btnsuspnd_Click(object sender, EventArgs e)
        {
            CounterThread.Suspend();//Pauses the thread

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CounterThread.Resume(); //Resumes the thread

        }

        private void crostwo_Click(object sender, EventArgs e)
        {
            DrawGrid(2, 2);
            this.Refresh();


        }

        private void crs4_Click(object sender, EventArgs e)
        {
            DrawGrid(4, 4);
            this.Refresh();

        }
        
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void crssix_Click(object sender, EventArgs e)
        {
            DrawGrid(6, 6);
            this.Refresh();

        }

        private void crsxeight_Click(object sender, EventArgs e)
        {
            DrawGrid(8, 8);
            this.Refresh();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
