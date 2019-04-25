using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkSheetFrom_Sec_M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double myMath, eng, myUrdu, sci, comp, busi, myTech, myPhy, total, myAverage;
        private void totalBtn_Click(object sender, EventArgs e)
        {
            myMath = Convert.ToDouble(math.Text);
            eng = Convert.ToDouble(English.Text);
            myUrdu = Convert.ToDouble(urdu.Text);
            sci = Convert.ToDouble(Scie.Text);
            comp = Convert.ToDouble(computer.Text);
            busi = Convert.ToDouble(business.Text);
            myTech = Convert.ToDouble(tech.Text);
            myPhy = Convert.ToDouble(phy.Text);
            total = myMath + eng + myUrdu + sci + comp + busi + myTech + myPhy;
            TOM.Text = Convert.ToString(total);
        }
        private void averBtn_Click(object sender, EventArgs e)
        {
            myAverage = total / 8;
            average.Text = Convert.ToString(myAverage);
        }

        private void gradeBtn_Click(object sender, EventArgs e)
        {
            if (myAverage >= 95)
            {
                grade.Text = "A+";
            }
            else if (myAverage >= 90)
            {
                grade.Text = "A";
            }
            else if (myAverage >= 80)
            {
                grade.Text = "B";
            }
            else if (myAverage >= 70)
            {
                grade.Text = "C";
            }
            else if (myAverage >= 60)
            {
                grade.Text = "D";
            }
            else
            {
                grade.Text = "Fail";
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            FatherName.Text = "";
            email.Text = "";
            age.Text = "";
            CurrEdu.Text = "";
            math.Text = "";
            English.Text = "";
            urdu.Text = "";
            Scie.Text = "";
            computer.Text = "";
            business.Text = "";
            tech.Text = "";
            phy.Text = "";
            average.Text = "";
            grade.Text = "";
            TOM.Text = "";

        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
