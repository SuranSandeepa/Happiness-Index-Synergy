using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Happiness_Index.Employees
{
    public partial class QuestionsPage : System.Web.UI.Page
    {
        string q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23,
            q24, q25, q26, q27 = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            //question 01
            if (rbQ1Excellent.Checked)
            {
                q1 = "Excellent";
            }
            else if (rbQ1Good.Checked)
            {
                q1 = "Good";
            }
            else if (rbQ1Normal.Checked)
            {
                q1 = "Neutral";
            }
            else if (rbQ1Neutral.Checked)
            {
                q1 = "Poor";
            }
            else
            {
                q1 = "Disappointed";
            }

            //question 02
            if (rbQ2Excellent.Checked)
            {
                q2 = "Excellent";
            }
            else if (rbQ2Good.Checked)
            {
                q2 = "Good";
            }
            else if (rbQ2Normal.Checked)
            {
                q2 = "Neutral";
            }
            else if (rbQ2Neutral.Checked)
            {
                q2 = "Poor";
            }
            else
            {
                q2 = "Disappointed";
            }

            //question 03
            if (rbQ3Excellent.Checked)
            {
                q3 = "Excellent";
            }
            else if (rbQ3Good.Checked)
            {
                q3 = "Good";
            }
            else if (rbQ3Normal.Checked)
            {
                q3 = "Neutral";
            }
            else if (rbQ3Neutral.Checked)
            {
                q3 = "Poor";
            }
            else
            {
                q3 = "Disappointed";
            }

            //question 04
            if (rbQ4Excellent.Checked)
            {
                q4 = "Excellent";
            }
            else if (rbQ4Good.Checked)
            {
                q4 = "Good";
            }
            else if (rbQ4Normal.Checked)
            {
                q4 = "Neutral";
            }
            else if (rbQ4Neutral.Checked)
            {
                q4 = "Poor";
            }
            else
            {
                q4 = "Disappointed";
            }

            //question 05
            if (rbQ5Excellent.Checked)
            {
                q5 = "Excellent";
            }
            else if (rbQ5Good.Checked)
            {
                q5 = "Good";
            }
            else if (rbQ5Normal.Checked)
            {
                q5 = "Neutral";
            }
            else if (rbQ5Neutral.Checked)
            {
                q5 = "Poor";
            }
            else
            {
                q5 = "Disappointed";
            }

            //question 06
            if (rbQ6Excellent.Checked)
            {
                q6 = "Excellent";
            }
            else if (rbQ6Good.Checked)
            {
                q6 = "Good";
            }
            else if (rbQ6Normal.Checked)
            {
                q6 = "Neutral";
            }
            else if (rbQ6Neutral.Checked)
            {
                q6 = "Poor";
            }
            else
            {
                q6 = "Disappointed";
            }

            //question 07
            if (rbQ7Excellent.Checked)
            {
                q7 = "Excellent";
            }
            else if (rbQ7Good.Checked)
            {
                q7 = "Good";
            }
            else if (rbQ7Normal.Checked)
            {
                q7 = "Neutral";
            }
            else if (rbQ7Neutral.Checked)
            {
                q7 = "Poor";
            }
            else
            {
                q7 = "Disappointed";
            }

            //question 08
            if (rbQ8Excellent.Checked)
            {
                q8 = "Excellent";
            }
            else if (rbQ8Good.Checked)
            {
                q8 = "Good";
            }
            else if (rbQ8Normal.Checked)
            {
                q8 = "Neutral";
            }
            else if (rbQ8Neutral.Checked)
            {
                q8 = "Poor";
            }
            else
            {
                q8 = "Disappointed";
            }

            //question 09
            if (rbQ9Excellent.Checked)
            {
                q9 = "Excellent";
            }
            else if (rbQ9Good.Checked)
            {
                q9 = "Good";
            }
            else if (rbQ9Normal.Checked)
            {
                q9 = "Neutral";
            }
            else if (rbQ9Neutral.Checked)
            {
                q9 = "Poor";
            }
            else
            {
                q9 = "Disappointed";
            }

            //question 10
            if (rbQ10Excellent.Checked)
            {
                q10 = "Excellent";
            }
            else if (rbQ10Good.Checked)
            {
                q10 = "Good";
            }
            else if (rbQ10Normal.Checked)
            {
                q10 = "Neutral";
            }
            else if (rbQ10Neutral.Checked)
            {
                q10 = "Poor";
            }
            else
            {
                q10 = "Disappointed";
            }

            //question 11
            if (rbQ11Excellent.Checked)
            {
                q11 = "Excellent";
            }
            else if (rbQ11Good.Checked)
            {
                q11 = "Good";
            }
            else if (rbQ11Normal.Checked)
            {
                q11 = "Neutral";
            }
            else if (rbQ11Neutral.Checked)
            {
                q11 = "Poor";
            }
            else
            {
                q11 = "Disappointed";
            }

            //question 12
            if (rbQ12Excellent.Checked)
            {
                q12 = "Excellent";
            }
            else if (rbQ12Good.Checked)
            {
                q12 = "Good";
            }
            else if (rbQ12Normal.Checked)
            {
                q12 = "Neutral";
            }
            else if (rbQ12Neutral.Checked)
            {
                q12 = "Poor";
            }
            else
            {
                q12 = "Disappointed";
            }

            //question 13
            if (rbQ13Excellent.Checked)
            {
                q13 = "Excellent";
            }
            else if (rbQ13Good.Checked)
            {
                q13 = "Good";
            }
            else if (rbQ13Normal.Checked)
            {
                q13 = "Neutral";
            }
            else if (rbQ13Neutral.Checked)
            {
                q13 = "Poor";
            }
            else
            {
                q13 = "Disappointed";
            }

            //question 14
            if (rbQ14Excellent.Checked)
            {
                q14 = "Excellent";
            }
            else if (rbQ14Good.Checked)
            {
                q14 = "Good";
            }
            else if (rbQ14Normal.Checked)
            {
                q14 = "Neutral";
            }
            else if (rbQ14Neutral.Checked)
            {
                q14 = "Poor";
            }
            else
            {
                q14 = "Disappointed";
            }

            //question 15
            if (rbQ15Excellent.Checked)
            {
                q15 = "Excellent";
            }
            else if (rbQ15Good.Checked)
            {
                q15 = "Good";
            }
            else if (rbQ15Normal.Checked)
            {
                q15 = "Neutral";
            }
            else if (rbQ15Neutral.Checked)
            {
                q3 = "Poor";
            }
            else
            {
                q3 = "Disappointed";
            }
        }

    }
}