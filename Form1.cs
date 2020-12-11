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

        public Form1()
        {
            InitializeComponent();
        }


        // 종료버튼
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
