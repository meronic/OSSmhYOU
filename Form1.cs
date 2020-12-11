using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// 윈도우프로그래밍 기말고사 과제
// 컴퓨터소프트웨어공학과 20162908 유명현
// 첨부한 실행파일과 똑같이 만들기

namespace WindowsFinal_Project
{
    public partial class Form1 : Form
    {
        private int penSize = 3; // 선 굵기 변수
        private Color selectColor = Color.Blue; // 색상 변수

        private int choice = 4;

        private int[] shape = { 1, 2, 3, 4, 5, 6 }; // 모양 선택 배열 
        // 1.동그라미, 2.사각형, 3. 삼각형, 4.직선, 5.별1, 6. 별2

        public Form1()
        {
            InitializeComponent();
        }

        //////////////////// 도형버튼///////////////////////////////
        private void 동그라미ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = shape[0];
            Refresh(); // 새로고침
        }

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = shape[1];
            Refresh();
        }

        private void 삼각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = shape[2];
            Refresh();
        }

        private void 직선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = shape[3];
            Refresh();
        }

        private void 별1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = shape[4];
            Refresh();
        }

        private void 별2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = shape[5];
            Refresh();
        }
        // 종료버튼
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }






        ///////////////////////////// 색상 버튼////////////////////////////////
        private void 빨간색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectColor = Color.Red;
            Refresh();
        }

        private void 노란색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectColor = Color.Yellow;
            Refresh();
        }

        private void 초록색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectColor = Color.Green;
            Refresh();
        }

        private void 파란색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectColor = Color.Blue;
            Refresh();
        }


        ///////////////////////////////선 굵기 버튼 ///////////////////////////
        private void 굵게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penSize = 5;
            Refresh();
        }

        private void 중간ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penSize = 3;
            Refresh();
        }

        private void 얇게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penSize = 1;
            Refresh();
        }

        //////////////////////////// 그림그리기 함수 ///////////////////////////
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, (float)penSize);
            SolidBrush solidBrush = new SolidBrush(selectColor);
            
            // 도형 그리기
            switch (choice)
            {
                case 1: // 동그라미
                    e.Graphics.FillEllipse((Brush)solidBrush, 60, 60, 100, 100);
                    e.Graphics.DrawEllipse(pen, 60, 60, 100, 100);
                    break;

                case 2: // 사각형
                    e.Graphics.FillRectangle((Brush)solidBrush, 60, 60, 100, 100);
                    e.Graphics.DrawRectangle(pen, 60, 60, 100, 100);
                    break;

                case 3: // 삼각형
                    Point[] points1 = new Point[3];
                    points1[0] = new Point(this.ClientRectangle.Width / 2, 25);
                    points1[1] = new Point(0, this.ClientRectangle.Height);
                    Rectangle clientRectangle = this.ClientRectangle;

                    int width = clientRectangle.Width;
                    clientRectangle = this.ClientRectangle;
                    int height = clientRectangle.Height;
                    points1[2] = new Point(width, height);
                    e.Graphics.FillRectangle((Brush)new PathGradientBrush(points1)
                    {
                        CenterColor = this.selectColor
                    }, this.ClientRectangle);
                    break;

                case 4: // 직선
                    e.Graphics.DrawLine(pen, 50, 50, 200, 150);
                    break;

                case 5: // 별1
                    Point point1 = new Point(110, 60);
                    Point point2 = new Point(60, 147);
                    Point point3 = new Point(50, 90);
                    Point point4 = new Point(170, 90);
                    Point point5 = new Point(160, 147);
                    Point[] points2 = new Point[5]
                    {
                        point1,
                        point2,
                        point4,
                        point3,
                        point5
                    };
                    e.Graphics.FillPolygon((Brush)solidBrush, points2);
                    e.Graphics.DrawPolygon(pen, points2);
                    break;
                    
                case 6: // 별2
                    Point[] points3 = new Point[10]
                     {
                        new Point(110, 40),
                        new Point(125, 91),
                        new Point(180, 91),
                        new Point(135, 123),
                        new Point(152, 172),
                        new Point(110, 141),
                        new Point(66, 172),
                        new Point(82, 122),
                        new Point(40, 91),
                        new Point(95, 91)
                     };
                    e.Graphics.FillClosedCurve((Brush)solidBrush, points3);
                    e.Graphics.DrawClosedCurve(pen, points3);
                    break;
            }
        }

       
    }
}
