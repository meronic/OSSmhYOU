using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFinal_Project
{
    public partial class Form1 : Form
    {
        private int penSize = 3; // 선 굵기 변수
        private Color selectColor = Color.Blue; // 색상 변수

        private int choice = 1;

        private int[] shape = { 1, 2, 3, 4, 5, 6 }; // 모양 선택 배열 
        // 1.동그라미, 2.사각형, 3. 삼각형, 4.직선, 5.별1, 6. 별2

        public Form1()
        {
            InitializeComponent();
        }


        // 종료버튼
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void 동그라미ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // 그림그리기
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, (float)penSize);
            SolidBrush solidBrush = new SolidBrush(selectColor);
            // 1. 동그라미
            switch (choice)
            {
                case 1:
                    e.Graphics.FillEllipse((Brush)solidBrush, 60, 60, 100, 100);
                    e.Graphics.DrawEllipse(pen, 60, 60, 100, 100);
                    break;
            }
        }
    }
}
