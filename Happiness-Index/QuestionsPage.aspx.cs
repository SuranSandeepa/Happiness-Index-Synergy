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
                q15 = "Poor";
            }
            else
            {
                q15 = "Disappointed";
            }


            //question 16
            if (rbQ16Excellent.Checked)
            {
                q16 = "Excellent";
            }
            else if (rbQ16Good.Checked)
            {
                q16 = "Good";
            }
            else if (rbQ16Normal.Checked)
            {
                q16 = "Neutral";
            }
            else if (rbQ16Neutral.Checked)
            {
                q16 = "Poor";
            }
            else
            {
                q16 = "Disappointed";
            }

            //question 17
            if (rbQ17Excellent.Checked)
            {
                q17 = "Excellent";
            }
            else if (rbQ17Good.Checked)
            {
                q17 = "Good";
            }
            else if (rbQ17Normal.Checked)
            {
                q17 = "Neutral";
            }
            else if (rbQ17Neutral.Checked)
            {
                q17 = "Poor";
            }
            else
            {
                q17 = "Disappointed";
            }

            //question 18
            if (rbQ18Excellent.Checked)
            {
                q18 = "Excellent";
            }
            else if (rbQ18Good.Checked)
            {
                q18 = "Good";
            }
            else if (rbQ18Normal.Checked)
            {
                q18 = "Neutral";
            }
            else if (rbQ18Neutral.Checked)
            {
                q18 = "Poor";
            }
            else
            {
                q18 = "Disappointed";
            }


            //question 19
            if (rbQ19Excellent.Checked)
            {
                q19 = "Excellent";
            }
            else if (rbQ19Good.Checked)
            {
                q19 = "Good";
            }
            else if (rbQ19Normal.Checked)
            {
                q19 = "Neutral";
            }
            else if (rbQ19Neutral.Checked)
            {
                q19 = "Poor";
            }
            else
            {
                q19 = "Disappointed";
            }

            //question 20
            if (rbQ20Excellent.Checked)
            {
                q20 = "Excellent";
            }
            else if (rbQ20Good.Checked)
            {
                q20 = "Good";
            }
            else if (rbQ20Normal.Checked)
            {
                q20 = "Neutral";
            }
            else if (rbQ20Neutral.Checked)
            {
                q20 = "Poor";
            }
            else
            {
                q20 = "Disappointed";
            }

            //question 21
            if (rbQ21Excellent.Checked)
            {
                q21 = "Excellent";
            }
            else if (rbQ21Good.Checked)
            {
                q21 = "Good";
            }
            else if (rbQ21Normal.Checked)
            {
                q21 = "Neutral";
            }
            else if (rbQ21Neutral.Checked)
            {
                q21 = "Poor";
            }
            else
            {
                q21 = "Disappointed";
            }

            //question 22
            if (rbQ22Excellent.Checked)
            {
                q22 = "Excellent";
            }
            else if (rbQ22Good.Checked)
            {
                q22 = "Good";
            }
            else if (rbQ22Normal.Checked)
            {
                q22 = "Neutral";
            }
            else if (rbQ22Neutral.Checked)
            {
                q22 = "Poor";
            }
            else
            {
                q22 = "Disappointed";
            }


            //question 23
            if (rbQ23Excellent.Checked)
            {
                q23 = "Excellent";
            }
            else if (rbQ23Good.Checked)
            {
                q23 = "Good";
            }
            else if (rbQ23Normal.Checked)
            {
                q23 = "Neutral";
            }
            else if (rbQ23Neutral.Checked)
            {
                q23 = "Poor";
            }
            else
            {
                q23 = "Disappointed";
            }


            //question 24
            if (rbQ24Excellent.Checked)
            {
                q24 = "Excellent";
            }
            else if (rbQ24Good.Checked)
            {
                q24 = "Good";
            }
            else if (rbQ24Normal.Checked)
            {
                q24 = "Neutral";
            }
            else if (rbQ24Neutral.Checked)
            {
                q24 = "Poor";
            }
            else
            {
                q24 = "Disappointed";
            }


            //question 25
            if (rbQ25Excellent.Checked)
            {
                q25 = "Excellent";
            }
            else if (rbQ25Good.Checked)
            {
                q25 = "Good";
            }
            else if (rbQ25Normal.Checked)
            {
                q25 = "Neutral";
            }
            else if (rbQ25Neutral.Checked)
            {
                q25 = "Poor";
            }
            else
            {
                q25 = "Disappointed";
            }


            //question 26
            if (rbQ26Excellent.Checked)
            {
                q26 = "Excellent";
            }
            else if (rbQ26Good.Checked)
            {
                q26 = "Good";
            }
            else if (rbQ26Normal.Checked)
            {
                q26 = "Neutral";
            }
            else if (rbQ26Neutral.Checked)
            {
                q26 = "Poor";
            }
            else
            {
                q26 = "Disappointed";
            }

            //question 27
            if (rbQ27Excellent.Checked)
            {
                q27 = "Excellent";
            }
            else if (rbQ27Good.Checked)
            {
                q27 = "Good";
            }
            else if (rbQ27Normal.Checked)
            {
                q27 = "Neutral";
            }
            else if (rbQ27Neutral.Checked)
            {
                q27 = "Poor";
            }
            else
            {
                q27 = "Disappointed";
            }
        }

    }
}