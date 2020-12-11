using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


// 윈도우프로그래밍 기말고사 과제
// 컴퓨터소프트웨어공학과 20162908 유명현
// 첨부한 실행파일과 똑같이 만들기

namespace WindowsFinal_Project
{
    public partial class Form1 : Form
    {
        private int penSize = 3; // 선 굵기 변수, 프로그램 시작 시 기본 값 3
        private Color selectColor = Color.Blue; // 색상 변수, 프로그램 시작 시 기본 값 파란색

        private int choice = 3; // 모양 선택 변수, 프로그램 시작 시 기본 값 삼각형

        private int[] shape = { 1, 2, 3, 4, 5, 6 }; // 모양 선택 배열 
        // 1.동그라미, 2.사각형, 3. 삼각형, 4.직선, 5.별1, 6. 별2

         private void banLine_tri()
        {
            // 삼각형에 도형이 체크 되어 있다면 선 굵기 사용 불가
            굵게ToolStripMenuItem.Enabled = false;
            중간ToolStripMenuItem.Enabled = false;
            얇게ToolStripMenuItem.Enabled = false;
        }

        private void releaseLine()
        {
            // 삼각형이 아니라면 사용 불가 해제
            굵게ToolStripMenuItem.Enabled = true;
            중간ToolStripMenuItem.Enabled = true;
            얇게ToolStripMenuItem.Enabled = true;
        }

        private void banColor()
        {
            // 직선에 도형이 체크 되어 있으면 색상 사용 불가
            빨간색ToolStripMenuItem.Enabled = false;
            노란색ToolStripMenuItem.Enabled = false;
            초록색ToolStripMenuItem.Enabled = false;
            파란색ToolStripMenuItem.Enabled = false;
        }

        private void releaseColor()
        {
            // 직선이 아니라면 색상 사용 불가 해제
            빨간색ToolStripMenuItem.Enabled = true;
            노란색ToolStripMenuItem.Enabled = true;
            초록색ToolStripMenuItem.Enabled = true;
            파란색ToolStripMenuItem.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();

            // 첨부한 실행파일의 초기 상태
            삼각형ToolStripMenuItem.Checked = true;
            파란색ToolStripMenuItem.Checked = true;
            중간ToolStripMenuItem.Checked = true;
            banLine_tri(); // 삼각형 선택시 굵기 사용 불가

            Refresh(); // 새로고침
        }

        //////////////////// 도형버튼///////////////////////////////
        private void 동그라미ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 동그라미 버튼만 클릭 된 상태
            동그라미ToolStripMenuItem.Checked = true;

            // 나머지 해제
            사각형ToolStripMenuItem.Checked = false;
            삼각형ToolStripMenuItem.Checked = false;
            직선ToolStripMenuItem.Checked = false;
            별1ToolStripMenuItem.Checked = false;
            별2ToolStripMenuItem.Checked = false;

            releaseLine(); // 선 굵기 사용가능
            releaseColor(); // 색상 사용가능
            choice = shape[0];
            Refresh(); // 새로고침
        }

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 사각형 버튼만 클릭 된 상태
            사각형ToolStripMenuItem.Checked = true;

            // 나머지 해제
            동그라미ToolStripMenuItem.Checked = false;
            삼각형ToolStripMenuItem.Checked = false;
            직선ToolStripMenuItem.Checked = false;
            별1ToolStripMenuItem.Checked = false;
            별2ToolStripMenuItem.Checked = false;

            releaseLine();
            releaseColor();
            choice = shape[1];
            Refresh();
        }

        private void 삼각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // 삼각형 버튼만 클릭 된 상태
            삼각형ToolStripMenuItem.Checked = true;

            // 나머지 해제
            사각형ToolStripMenuItem.Checked = false;
            동그라미ToolStripMenuItem.Checked = false;
            직선ToolStripMenuItem.Checked = false;
            별1ToolStripMenuItem.Checked = false;
            별2ToolStripMenuItem.Checked = false;

            // 삼각형에 도형이 체크 되어 있다면 선 굵기 사용 불가
            banLine_tri();
            releaseColor();
            choice = shape[2];
            Refresh();
        }

        private void 직선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 직선 버튼만 클릭 된 상태
            직선ToolStripMenuItem.Checked = true;

            // 나머지 해제
            사각형ToolStripMenuItem.Checked = false;
            삼각형ToolStripMenuItem.Checked = false;
            동그라미ToolStripMenuItem.Checked = false;
            별1ToolStripMenuItem.Checked = false;
            별2ToolStripMenuItem.Checked = false;

            // 직선은 색상 사용 불가
            banColor();
            releaseLine();
            choice = shape[3];
            Refresh();
        }

        private void 별1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 별1 버튼만 클릭 된 상태
            별1ToolStripMenuItem.Checked = true;

            // 나머지 해제
            사각형ToolStripMenuItem.Checked = false;
            삼각형ToolStripMenuItem.Checked = false;
            직선ToolStripMenuItem.Checked = false;
            동그라미ToolStripMenuItem.Checked = false;
            별2ToolStripMenuItem.Checked = false;

            releaseLine();
            releaseColor();
            choice = shape[4];
            Refresh();
        }

        private void 별2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 별2 버튼만 클릭 된 상태
            별2ToolStripMenuItem.Checked = true;

            // 나머지 해제
            사각형ToolStripMenuItem.Checked = false;
            삼각형ToolStripMenuItem.Checked = false;
            직선ToolStripMenuItem.Checked = false;
            별1ToolStripMenuItem.Checked = false;
            동그라미ToolStripMenuItem.Checked = false;

            releaseLine();
            releaseColor();
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
            // 빨간색 버튼만 클릭 된 상태
            빨간색ToolStripMenuItem.Checked = true;

            // 나머지 해제
            노란색ToolStripMenuItem.Checked = false;
            초록색ToolStripMenuItem.Checked = false;
            파란색ToolStripMenuItem.Checked = false;

            selectColor = Color.Red;
            Refresh();
        }

        private void 노란색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 노란색 버튼만 클릭 된 상태
            노란색ToolStripMenuItem.Checked = true;

            // 나머지 해제
            빨간색ToolStripMenuItem.Checked = false;
            초록색ToolStripMenuItem.Checked = false;
            파란색ToolStripMenuItem.Checked = false;

            selectColor = Color.Yellow;
            Refresh();
        }

        private void 초록색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 초록색 버튼만 클릭 된 상태
            초록색ToolStripMenuItem.Checked = true;

            // 나머지 해제
            노란색ToolStripMenuItem.Checked = false;
            빨간색ToolStripMenuItem.Checked = false;
            파란색ToolStripMenuItem.Checked = false;

            selectColor = Color.Green;
            Refresh();
        }

        private void 파란색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 파란색 버튼만 클릭 된 상태
            파란색ToolStripMenuItem.Checked = true;

            // 나머지 해제
            노란색ToolStripMenuItem.Checked = false;
            초록색ToolStripMenuItem.Checked = false;
            빨간색ToolStripMenuItem.Checked = false;

            selectColor = Color.Blue;
            Refresh();
        }


        ///////////////////////////////선 굵기 버튼 ///////////////////////////
     

        private void 굵게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 굵게 버튼만 클릭 된 상태
            굵게ToolStripMenuItem.Checked = true;

            // 나머지 해제
            중간ToolStripMenuItem.Checked = false;
            얇게ToolStripMenuItem.Checked = false;

            penSize = 5;
            Refresh();
        }

        private void 중간ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 중간 버튼만 클릭 된 상태
            중간ToolStripMenuItem.Checked = true;

            // 나머지 해제
            굵게ToolStripMenuItem.Checked = false;
            얇게ToolStripMenuItem.Checked = false;

            penSize = 3;
            Refresh();
        }

        private void 얇게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 얇게 버튼만 클릭 된 상태
            얇게ToolStripMenuItem.Checked = true;

            // 나머지 해제
            중간ToolStripMenuItem.Checked = false;
            굵게ToolStripMenuItem.Checked = false;

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
                    points1[0] = new Point(ClientRectangle.Width / 2, 25);
                    points1[1] = new Point(0,ClientRectangle.Height);
                    Rectangle clientRectangle = ClientRectangle;

                    int tWidth = clientRectangle.Width; // 넓이
                    int tHeight = clientRectangle.Height; // 높이

                    points1[2] = new Point(tWidth, tHeight);
                    e.Graphics.FillRectangle((Brush)new PathGradientBrush(points1)
                    {
                        CenterColor = selectColor
                    }, ClientRectangle);
                    break;

                case 4: // 직선
                    e.Graphics.DrawLine(pen, 50, 70, 210, 160);
                    break;

                case 5: // 별1

                    Point[] pointList = new Point[5]
                    {
                        new Point(115,60), // 맨 위 꼭지점 첫번째

                        new Point(65,165), // 왼쪽 아래 두번째

                        new Point(175,95), // 오른쪽 위 세번째

                        new Point(55,95), // 왼쪽 위 네번째

                        new Point(165,165), // 오른쪽 아래 다섯번째
                    };
                    e.Graphics.FillPolygon((Brush)solidBrush, pointList);
                    e.Graphics.DrawPolygon(pen, pointList);
                    break;
                    
                case 6: // 별2
                    Point[] pointsList2 = new Point[10]
                     {
                        new Point(115, 45), // 맨 위 가운데

                        new Point(130, 90), // 위 오른쪽 오목
                        new Point(185, 92), // 위 오른쪽 볼록

                        new Point(145, 130), // 아래 오른쪽 오목
                        new Point(157, 180), // 아래 오른쪽 볼록

                        new Point(115, 150), // 아래 가운데

                        new Point(70, 180), // 아래 왼쪽 볼록
                        new Point(87, 130), // 아래 왼쪽 오목

                        new Point(45, 92), // 위 왼쪽 볼록
                        new Point(100, 90) // 위 왼쪽 오목
                     };
                    e.Graphics.FillClosedCurve((Brush)solidBrush, pointsList2);
                    e.Graphics.DrawClosedCurve(pen, pointsList2);
                    break;
            }
        }

     
    }
}
