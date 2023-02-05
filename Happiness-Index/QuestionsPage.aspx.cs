using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Happiness_Index.Employees
{
    public partial class QuestionsPage : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23,
                   q24, q25, q26, q27 = "";

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

            if(qEPF.Value == string.Empty ||qNAME.Value == string.Empty)
            {
                //Alert
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('සෑම අන්ශයක්ම පුරවන්න!!');", true);
            }
            else
            {
                using(SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO QuestionForm(qdate,qepf,qname,q1,q2,q3,q4,q5,q6,q7,q8,q9,q10,q11,q12,q13,q14,q15,q16,q17,q18,q19,q20,21,q22,q23,q24,q25,q26,q27) VALUES(@qdate, @qepf, @qname, @q1, @q2,@q3,@q4,@q5,@q6,@q7,@q8,@q9,@q10,@q11,@q12,@q13,@q14,@q15,@q16,@q17,@q18,@q19,@q20,@q21,@q22,@q23,@q24,@q25,@q26,@q27)", connection))
                    {
                        cmd.Parameters.AddWithValue("@qdate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@qepf", qEPF.Value);
                        cmd.Parameters.AddWithValue("@qname", qNAME.Value);
                        cmd.Parameters.AddWithValue("@q1", q1);
                        cmd.Parameters.AddWithValue("@q2", q1);
                        cmd.Parameters.AddWithValue("@q3", q1);
                        cmd.Parameters.AddWithValue("@q4", q1);
                        cmd.Parameters.AddWithValue("@q5", q1);
                        cmd.Parameters.AddWithValue("@q6", q1);
                        cmd.Parameters.AddWithValue("@q7", q1);
                        cmd.Parameters.AddWithValue("@q8", q1);
                        cmd.Parameters.AddWithValue("@q9", q1);
                        cmd.Parameters.AddWithValue("@q10", q1);
                        cmd.Parameters.AddWithValue("@q11", q1);
                        cmd.Parameters.AddWithValue("@q12", q1);
                        cmd.Parameters.AddWithValue("@q13", q1);
                        cmd.Parameters.AddWithValue("@q14", q1);
                        cmd.Parameters.AddWithValue("@q15", q1);
                        cmd.Parameters.AddWithValue("@q16", q1);
                        cmd.Parameters.AddWithValue("@q17", q1);
                        cmd.Parameters.AddWithValue("@q18", q1);
                        cmd.Parameters.AddWithValue("@q19", q1);
                        cmd.Parameters.AddWithValue("@q20", q1);
                        cmd.Parameters.AddWithValue("@q21", q1);
                        cmd.Parameters.AddWithValue("@q22", q1);
                        cmd.Parameters.AddWithValue("@q23", q1);
                        cmd.Parameters.AddWithValue("@q24", q1);
                        cmd.Parameters.AddWithValue("@q25", q1);
                        cmd.Parameters.AddWithValue("@q26", q1);
                        cmd.Parameters.AddWithValue("@q27", q1);
                    }
                    connection.Close();
                }
                //Alert
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('දත්ත ගබඩා විය,ස්තූතියි.');", true);

                //Question 01
                rbQ1Excellent.Checked = false;
                rbQ1Good.Checked = false;
                rbQ1Neutral.Checked = false;
                rbQ1Normal.Checked = false;
                rbQ1Poor.Checked = false;

                //Question 02
                rbQ2Excellent.Checked = false;
                rbQ2Good.Checked = false;
                rbQ2Neutral.Checked = false;
                rbQ2Normal.Checked = false;
                rbQ2Poor.Checked = false;

                //Question 03
                rbQ3Excellent.Checked = false;
                rbQ3Good.Checked = false;
                rbQ3Neutral.Checked = false;
                rbQ3Normal.Checked = false;
                rbQ3Poor.Checked = false;

                //Question 04
                rbQ4Excellent.Checked = false;
                rbQ4Good.Checked = false;
                rbQ4Neutral.Checked = false;
                rbQ4Normal.Checked = false;
                rbQ4Poor.Checked = false;

                //Question 05
                rbQ5Excellent.Checked = false;
                rbQ5Good.Checked = false;
                rbQ5Neutral.Checked = false;
                rbQ5Normal.Checked = false;
                rbQ5Poor.Checked = false;

                //Question 06
                rbQ6Excellent.Checked = false;
                rbQ6Good.Checked = false;
                rbQ6Neutral.Checked = false;
                rbQ6Normal.Checked = false;
                rbQ6Poor.Checked = false;

                //Question 07
                rbQ7Excellent.Checked = false;
                rbQ7Good.Checked = false;
                rbQ7Neutral.Checked = false;
                rbQ7Normal.Checked = false;
                rbQ7Poor.Checked = false;

                //Question 08
                rbQ8Excellent.Checked = false;
                rbQ8Good.Checked = false;
                rbQ8Neutral.Checked = false;
                rbQ8Normal.Checked = false;
                rbQ8Poor.Checked = false;

                //Question 09
                rbQ9Excellent.Checked = false;
                rbQ9Good.Checked = false;
                rbQ9Neutral.Checked = false;
                rbQ9Normal.Checked = false;
                rbQ9Poor.Checked = false;

                //Question 10
                rbQ10Excellent.Checked = false;
                rbQ10Good.Checked = false;
                rbQ10Neutral.Checked = false;
                rbQ10Normal.Checked = false;
                rbQ10Poor.Checked = false;

                //Question 11
                rbQ11Excellent.Checked = false;
                rbQ11Good.Checked = false;
                rbQ11Neutral.Checked = false;
                rbQ11Normal.Checked = false;
                rbQ11Poor.Checked = false;

                //Question 12
                rbQ12Excellent.Checked = false;
                rbQ12Good.Checked = false;
                rbQ12Neutral.Checked = false;
                rbQ12Normal.Checked = false;
                rbQ12Poor.Checked = false;

                //Question 13
                rbQ13Excellent.Checked = false;
                rbQ13Good.Checked = false;
                rbQ13Neutral.Checked = false;
                rbQ13Normal.Checked = false;
                rbQ13Poor.Checked = false;

                //Question 14
                rbQ14Excellent.Checked = false;
                rbQ14Good.Checked = false;
                rbQ14Neutral.Checked = false;
                rbQ14Normal.Checked = false;
                rbQ14Poor.Checked = false;

                //Question 15
                rbQ15Excellent.Checked = false;
                rbQ15Good.Checked = false;
                rbQ15Neutral.Checked = false;
                rbQ15Normal.Checked = false;
                rbQ15Poor.Checked = false;

                //Question 16
                rbQ16Excellent.Checked = false;
                rbQ16Good.Checked = false;
                rbQ16Neutral.Checked = false;
                rbQ16Normal.Checked = false;
                rbQ16Poor.Checked = false;

                //Question 17
                rbQ17Excellent.Checked = false;
                rbQ17Good.Checked = false;
                rbQ17Neutral.Checked = false;
                rbQ17Normal.Checked = false;
                rbQ17Poor.Checked = false;

                //Question 18
                rbQ18Excellent.Checked = false;
                rbQ18Good.Checked = false;
                rbQ18Neutral.Checked = false;
                rbQ18Normal.Checked = false;
                rbQ18Poor.Checked = false;

                //Question 19
                rbQ19Excellent.Checked = false;
                rbQ19Good.Checked = false;
                rbQ19Neutral.Checked = false;
                rbQ19Normal.Checked = false;
                rbQ19Poor.Checked = false;

                //Question 20
                rbQ20Excellent.Checked = false;
                rbQ20Good.Checked = false;
                rbQ20Neutral.Checked = false;
                rbQ20Normal.Checked = false;
                rbQ20Poor.Checked = false;

                //Question 21
                rbQ21Excellent.Checked = false;
                rbQ21Good.Checked = false;
                rbQ21Neutral.Checked = false;
                rbQ21Normal.Checked = false;
                rbQ21Poor.Checked = false;

                //Question 22
                rbQ22Excellent.Checked = false;
                rbQ22Good.Checked = false;
                rbQ22Neutral.Checked = false;
                rbQ22Normal.Checked = false;
                rbQ22Poor.Checked = false;

                //Question 23
                rbQ23Excellent.Checked = false;
                rbQ23Good.Checked = false;
                rbQ23Neutral.Checked = false;
                rbQ23Normal.Checked = false;
                rbQ23Poor.Checked = false;

                //Question 24
                rbQ24Excellent.Checked = false;
                rbQ24Good.Checked = false;
                rbQ24Neutral.Checked = false;
                rbQ24Normal.Checked = false;
                rbQ24Poor.Checked = false;

                //Question 25
                rbQ25Excellent.Checked = false;
                rbQ25Good.Checked = false;
                rbQ25Neutral.Checked = false;
                rbQ25Normal.Checked = false;
                rbQ25Poor.Checked = false;

                //Question 26
                rbQ26Excellent.Checked = false;
                rbQ26Good.Checked = false;
                rbQ26Neutral.Checked = false;
                rbQ26Normal.Checked = false;
                rbQ26Poor.Checked = false;

                //Question 27
                rbQ27Excellent.Checked = false;
                rbQ27Good.Checked = false;
                rbQ27Neutral.Checked = false;
                rbQ27Normal.Checked = false;
                rbQ27Poor.Checked = false;
            }
        }

    }
}