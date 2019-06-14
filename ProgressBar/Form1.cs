using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {

        int Num = 0; //진행 숫자
        string OrgStr = ""; //상태 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = lblStatus.Text;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Num++;
            if(this.Num > 100) //진행 숫자가 100이 넘으면
            {
                this.Timer.Enabled = false; //타이머 종료
                return;
            }
            this.pbStatus.Value = this.Num;
            this.lblStatus.Text = this.OrgStr + this.Num + "%";
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = false; //타이머 종료
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.Num = 0;
            this.pbStatus.Value = this.Num;
            this.lblStatus.Text = this.OrgStr + this.Num + "%";
        }
    }
}
