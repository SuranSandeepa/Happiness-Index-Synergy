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
            string ans1 = "";
            if (rbQ1Excellent.Checked) ans1 = "Excellent";
            if (rbQ1Good.Checked) ans1 = "Good";
            if (rbQ1Neutral.Checked) ans1 = "Neutral";
            if (rbQ1Poor.Checked) ans1 = "Poor";
            if (rbQ1Disappointed.Checked) ans1 = "Disappointed";

            string ans2 = "";
            if (rbQ2Excellent.Checked) ans2 = "Excellent";
            if (rbQ2Good.Checked) ans2 = "Good";
            if (rbQ2Neutral.Checked) ans2 = "Neutral";
            if (rbQ2Poor.Checked) ans2 = "Poor";
            if (rbQ2Disappointed.Checked) ans2 = "Disappointed";

            string ans3 = "";
            if (rbQ3Excellent.Checked) ans3 = "Excellent";
            if (rbQ3Good.Checked) ans3 = "Good";
            if (rbQ3Neutral.Checked) ans3 = "Neutral";
            if (rbQ3Poor.Checked) ans3 = "Poor";
            if (rbQ3Disappointed.Checked) ans3 = "Disappointed";

            string ans4 = "";
            if (rbQ4Excellent.Checked) ans4 = "Excellent";
            if (rbQ4Good.Checked) ans4 = "Good";
            if (rbQ4Neutral.Checked) ans4 = "Neutral";
            if (rbQ4Poor.Checked) ans4 = "Poor";
            if (rbQ4Disappointed.Checked) ans4 = "Disappointed";

            string ans5 = "";
            if (rbQ5Excellent.Checked) ans5 = "Excellent";
            if (rbQ5Good.Checked) ans5 = "Good";
            if (rbQ5Neutral.Checked) ans5 = "Neutral";
            if (rbQ5Poor.Checked) ans5 = "Poor";
            if (rbQ5Disappointed.Checked) ans5 = "Disappointed";

            string ans6 = "";
            if (rbQ6Excellent.Checked) ans6 = "Excellent";
            if (rbQ6Good.Checked) ans6 = "Good";
            if (rbQ6Neutral.Checked) ans6 = "Neutral";
            if (rbQ6Poor.Checked) ans6 = "Poor";
            if (rbQ6Disappointed.Checked) ans6 = "Disappointed";

            string ans7 = "";
            if (rbQ7Excellent.Checked) ans7 = "Excellent";
            if (rbQ7Good.Checked) ans7 = "Good";
            if (rbQ7Neutral.Checked) ans7 = "Neutral";
            if (rbQ7Poor.Checked) ans7 = "Poor";
            if (rbQ7Disappointed.Checked) ans7 = "Disappointed";

            string ans8 = "";
            if (rbQ8Excellent.Checked) ans8 = "Excellent";
            if (rbQ8Good.Checked) ans8 = "Good";
            if (rbQ8Neutral.Checked) ans8 = "Neutral";
            if (rbQ8Poor.Checked) ans8 = "Poor";
            if (rbQ8Disappointed.Checked) ans8 = "Disappointed";

            string ans9 = "";
            if (rbQ9Excellent.Checked) ans9 = "Excellent";
            if (rbQ9Good.Checked) ans9 = "Good";
            if (rbQ9Neutral.Checked) ans9 = "Neutral";
            if (rbQ9Poor.Checked) ans9 = "Poor";
            if (rbQ9Disappointed.Checked) ans9 = "Disappointed";

            string ans10 = "";
            if (rbQ10Excellent.Checked) ans10 = "Excellent";
            if (rbQ10Good.Checked) ans10 = "Good";
            if (rbQ10Neutral.Checked) ans10 = "Neutral";
            if (rbQ10Poor.Checked) ans10 = "Poor";
            if (rbQ10Disappointed.Checked) ans10 = "Disappointed";

            string ans11 = "";
            if (rbQ11Excellent.Checked) ans11 = "Excellent";
            if (rbQ11Good.Checked) ans11 = "Good";
            if (rbQ11Neutral.Checked) ans11 = "Neutral";
            if (rbQ11Poor.Checked) ans11 = "Poor";
            if (rbQ11Disappointed.Checked) ans11 = "Disappointed";

            string ans12 = "";
            if (rbQ12Excellent.Checked) ans12 = "Excellent";
            if (rbQ12Good.Checked) ans12 = "Good";
            if (rbQ12Neutral.Checked) ans12 = "Neutral";
            if (rbQ12Poor.Checked) ans12 = "Poor";
            if (rbQ12Disappointed.Checked) ans12 = "Disappointed";

            string ans13 = "";
            if (rbQ13Excellent.Checked) ans13 = "Excellent";
            if (rbQ13Good.Checked) ans13 = "Good";
            if (rbQ13Neutral.Checked) ans13 = "Neutral";
            if (rbQ13Poor.Checked) ans13 = "Poor";
            if (rbQ13Disappointed.Checked) ans13 = "Disappointed";

            string ans14 = "";
            if (rbQ14Excellent.Checked) ans14 = "Excellent";
            if (rbQ14Good.Checked) ans14 = "Good";
            if (rbQ14Neutral.Checked) ans14 = "Neutral";
            if (rbQ14Poor.Checked) ans14 = "Poor";
            if (rbQ14Disappointed.Checked) ans14 = "Disappointed";

            string ans15 = "";
            if (rbQ15Excellent.Checked) ans15 = "Excellent";
            if (rbQ15Good.Checked) ans15 = "Good";
            if (rbQ15Neutral.Checked) ans15 = "Neutral";
            if (rbQ15Poor.Checked) ans15 = "Poor";
            if (rbQ15Disappointed.Checked) ans15 = "Disappointed";

            string ans16 = "";
            if (rbQ16Excellent.Checked) ans16 = "Excellent";
            if (rbQ16Good.Checked) ans16 = "Good";
            if (rbQ16Neutral.Checked) ans16 = "Neutral";
            if (rbQ16Poor.Checked) ans16 = "Poor";
            if (rbQ16Disappointed.Checked) ans16 = "Disappointed";

            string ans17 = "";
            if (rbQ17Excellent.Checked) ans17 = "Excellent";
            if (rbQ17Good.Checked) ans17 = "Good";
            if (rbQ17Neutral.Checked) ans17 = "Neutral";
            if (rbQ17Poor.Checked) ans17 = "Poor";
            if (rbQ17Disappointed.Checked) ans17 = "Disappointed";

            string ans18 = "";
            if (rbQ18Excellent.Checked) ans18 = "Excellent";
            if (rbQ18Good.Checked) ans18 = "Good";
            if (rbQ18Neutral.Checked) ans18 = "Neutral";
            if (rbQ18Poor.Checked) ans18 = "Poor";
            if (rbQ18Disappointed.Checked) ans18 = "Disappointed";

            string ans19 = "";
            if (rbQ19Excellent.Checked) ans19 = "Excellent";
            if (rbQ19Good.Checked) ans19 = "Good";
            if (rbQ19Neutral.Checked) ans19 = "Neutral";
            if (rbQ19Poor.Checked) ans19 = "Poor";
            if (rbQ19Disappointed.Checked) ans19 = "Disappointed";

            string ans20 = "";
            if (rbQ20Excellent.Checked) ans20 = "Excellent";
            if (rbQ20Good.Checked) ans20 = "Good";
            if (rbQ20Neutral.Checked) ans20 = "Neutral";
            if (rbQ20Poor.Checked) ans20 = "Poor";
            if (rbQ20Disappointed.Checked) ans20 = "Disappointed";

            string ans21 = "";
            if (rbQ21Excellent.Checked) ans21 = "Excellent";
            if (rbQ21Good.Checked) ans21 = "Good";
            if (rbQ21Neutral.Checked) ans21 = "Neutral";
            if (rbQ21Poor.Checked) ans21 = "Poor";
            if (rbQ21Disappointed.Checked) ans21 = "Disappointed";

            string ans22 = "";
            if (rbQ22Excellent.Checked) ans22 = "Excellent";
            if (rbQ22Good.Checked) ans22 = "Good";
            if (rbQ22Neutral.Checked) ans22 = "Neutral";
            if (rbQ22Poor.Checked) ans22 = "Poor";
            if (rbQ22Disappointed.Checked) ans22 = "Disappointed";

            string ans23 = "";
            if (rbQ23Excellent.Checked) ans23 = "Excellent";
            if (rbQ23Good.Checked) ans23 = "Good";
            if (rbQ23Neutral.Checked) ans23 = "Neutral";
            if (rbQ23Poor.Checked) ans23 = "Poor";
            if (rbQ23Disappointed.Checked) ans23 = "Disappointed";

            string ans24 = "";
            if (rbQ24Excellent.Checked) ans24 = "Excellent";
            if (rbQ24Good.Checked) ans24 = "Good";
            if (rbQ24Neutral.Checked) ans24 = "Neutral";
            if (rbQ24Poor.Checked) ans24 = "Poor";
            if (rbQ24Disappointed.Checked) ans24 = "Disappointed";

            string ans25 = "";
            if (rbQ25Excellent.Checked) ans25 = "Excellent";
            if (rbQ25Good.Checked) ans25 = "Good";
            if (rbQ25Neutral.Checked) ans25 = "Neutral";
            if (rbQ25Poor.Checked) ans25 = "Poor";
            if (rbQ25Disappointed.Checked) ans25 = "Disappointed";

            string ans26 = "";
            if (rbQ26Excellent.Checked) ans26 = "Excellent";
            if (rbQ26Good.Checked) ans26 = "Good";
            if (rbQ26Neutral.Checked) ans26 = "Neutral";
            if (rbQ26Poor.Checked) ans26 = "Poor";
            if (rbQ26Disappointed.Checked) ans26 = "Disappointed";

            string ans27 = "";
            if (rbQ27Excellent.Checked) ans27 = "Excellent";
            if (rbQ27Good.Checked) ans27 = "Good";
            if (rbQ27Neutral.Checked) ans27 = "Neutral";
            if (rbQ27Poor.Checked) ans27 = "Poor";
            if (rbQ27Disappointed.Checked) ans27 = "Disappointed";


            if (string.IsNullOrEmpty(qEPF.Value) || string.IsNullOrEmpty(qNAME.Value))
            {
                //Alert
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('සෑම අන්ශයක්ම පුරවන්න!!');", true);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO QuestionForm(qdate,qepf,qname,q1,q2,q3,q4,q5,q6,q7,q8,q9,q10,q11,q12,q13,q14,q15,q16,q17,q18,q19,q20,q21,q22,q23,q24,q25,q26,q27)VALUES('" + DateTime.Now + "','" + qEPF.Value + "','" + qNAME.Value + "','" + ans1 + "','" + ans2 + "','" + ans3 + "','" + ans4 + "','" + ans5 + "','" + ans6 + "','" + ans7 + "','" + ans8 + "','" + ans9 + "','" + ans10 + "','" + ans11 + "','" + ans12 + "','" + ans13 + "','" + ans14 + "','" + ans15 + "','" + ans16 + "','" + ans17 + "','" + ans18 + "','" + ans19 + "','" + ans20 + "','" + ans21 + "','" + ans22 + "','" + ans23 + "','" + ans24 + "','" + ans25 + "','" + ans26 + "','" + ans27 + "') ",connection);
                    cmd.ExecuteNonQuery();  
                    connection.Close();
                }
                //Alert
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('දත්ත ගබඩා විය,ස්තූතියි.');", true);

                qEPF.Value = string.Empty;
                qNAME.Value = string.Empty;

                //Quetion 01
                rbQ1Excellent.Checked = false;
                rbQ1Good.Checked = false;
                rbQ1Neutral.Checked = false;
                rbQ1Poor.Checked = false;
                rbQ1Disappointed.Checked = false;

                //Quetion 02
                rbQ2Excellent.Checked = false;
                rbQ2Good.Checked = false;
                rbQ2Neutral.Checked = false;
                rbQ2Poor.Checked = false;
                rbQ2Disappointed.Checked = false;

                //Quetion 03
                rbQ3Excellent.Checked = false;
                rbQ3Good.Checked = false;
                rbQ3Neutral.Checked = false;
                rbQ3Poor.Checked = false;
                rbQ3Disappointed.Checked = false;

                //Quetion 04
                rbQ4Excellent.Checked = false;
                rbQ4Good.Checked = false;
                rbQ4Neutral.Checked = false;
                rbQ4Poor.Checked = false;
                rbQ4Disappointed.Checked = false;

                //Quetion 05
                rbQ5Excellent.Checked = false;
                rbQ5Good.Checked = false;
                rbQ5Neutral.Checked = false;
                rbQ5Poor.Checked = false;
                rbQ5Disappointed.Checked = false;

                //Quetion 06
                rbQ6Excellent.Checked = false;
                rbQ6Good.Checked = false;
                rbQ6Neutral.Checked = false;
                rbQ6Poor.Checked = false;
                rbQ6Disappointed.Checked = false;

                //Quetion 07
                rbQ7Excellent.Checked = false;
                rbQ7Good.Checked = false;
                rbQ7Neutral.Checked = false;
                rbQ7Poor.Checked = false;
                rbQ7Disappointed.Checked = false;

                //Quetion 08
                rbQ8Excellent.Checked = false;
                rbQ8Good.Checked = false;
                rbQ8Neutral.Checked = false;
                rbQ8Poor.Checked = false;
                rbQ8Disappointed.Checked = false;

                //Quetion 09
                rbQ9Excellent.Checked = false;
                rbQ9Good.Checked = false;
                rbQ9Neutral.Checked = false;
                rbQ9Poor.Checked = false;
                rbQ9Disappointed.Checked = false;

                //Quetion 10
                rbQ10Excellent.Checked = false;
                rbQ10Good.Checked = false;
                rbQ10Neutral.Checked = false;
                rbQ10Poor.Checked = false;
                rbQ10Disappointed.Checked = false;

                //Quetion 11
                rbQ11Excellent.Checked = false;
                rbQ11Good.Checked = false;
                rbQ11Neutral.Checked = false;
                rbQ11Poor.Checked = false;
                rbQ11Disappointed.Checked = false;

                //Quetion 12
                rbQ12Excellent.Checked = false;
                rbQ12Good.Checked = false;
                rbQ12Neutral.Checked = false;
                rbQ12Poor.Checked = false;
                rbQ12Disappointed.Checked = false;

                //Quetion 13
                rbQ13Excellent.Checked = false;
                rbQ13Good.Checked = false;
                rbQ13Neutral.Checked = false;
                rbQ13Poor.Checked = false;
                rbQ13Disappointed.Checked = false;

                //Quetion 14
                rbQ14Excellent.Checked = false;
                rbQ14Good.Checked = false;
                rbQ14Neutral.Checked = false;
                rbQ14Poor.Checked = false;
                rbQ14Disappointed.Checked = false;

                //Quetion 15
                rbQ15Excellent.Checked = false;
                rbQ15Good.Checked = false;
                rbQ15Neutral.Checked = false;
                rbQ15Poor.Checked = false;
                rbQ15Disappointed.Checked = false;

                //Quetion 16
                rbQ16Excellent.Checked = false;
                rbQ16Good.Checked = false;
                rbQ16Neutral.Checked = false;
                rbQ16Poor.Checked = false;
                rbQ16Disappointed.Checked = false;

                //Quetion 17
                rbQ17Excellent.Checked = false;
                rbQ17Good.Checked = false;
                rbQ17Neutral.Checked = false;
                rbQ17Poor.Checked = false;
                rbQ17Disappointed.Checked = false;

                //Quetion 18
                rbQ18Excellent.Checked = false;
                rbQ18Good.Checked = false;
                rbQ18Neutral.Checked = false;
                rbQ18Poor.Checked = false;
                rbQ18Disappointed.Checked = false;

                //Quetion 19
                rbQ19Excellent.Checked = false;
                rbQ19Good.Checked = false;
                rbQ19Neutral.Checked = false;
                rbQ19Poor.Checked = false;
                rbQ19Disappointed.Checked = false;

                //Quetion 20
                rbQ20Excellent.Checked = false;
                rbQ20Good.Checked = false;
                rbQ20Neutral.Checked = false;
                rbQ20Poor.Checked = false;
                rbQ20Disappointed.Checked = false;

                //Quetion 21
                rbQ21Excellent.Checked = false;
                rbQ21Good.Checked = false;
                rbQ21Neutral.Checked = false;
                rbQ21Poor.Checked = false;
                rbQ21Disappointed.Checked = false;

                //Quetion 22
                rbQ22Excellent.Checked = false;
                rbQ22Good.Checked = false;
                rbQ22Neutral.Checked = false;
                rbQ22Poor.Checked = false;
                rbQ22Disappointed.Checked = false;

                //Quetion 23
                rbQ23Excellent.Checked = false;
                rbQ23Good.Checked = false;
                rbQ23Neutral.Checked = false;
                rbQ23Poor.Checked = false;
                rbQ23Disappointed.Checked = false;

                //Quetion 24
                rbQ24Excellent.Checked = false;
                rbQ24Good.Checked = false;
                rbQ24Neutral.Checked = false;
                rbQ24Poor.Checked = false;
                rbQ24Disappointed.Checked = false;

                //Quetion 25
                rbQ25Excellent.Checked = false;
                rbQ25Good.Checked = false;
                rbQ25Neutral.Checked = false;
                rbQ25Poor.Checked = false;
                rbQ25Disappointed.Checked = false;

                //Quetion 26
                rbQ26Excellent.Checked = false;
                rbQ26Good.Checked = false;
                rbQ26Neutral.Checked = false;
                rbQ26Poor.Checked = false;
                rbQ26Disappointed.Checked = false;

                //Quetion 27
                rbQ27Excellent.Checked = false;
                rbQ27Good.Checked = false;
                rbQ27Neutral.Checked = false;
                rbQ27Poor.Checked = false;
                rbQ27Disappointed.Checked = false;
            }
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            {
                qEPF.Value = "";
                qNAME.Value = "";

                //Quetion 01
                rbQ1Excellent.Checked = false;
                rbQ1Good.Checked = false;
                rbQ1Neutral.Checked = false;
                rbQ1Poor.Checked = false;
                rbQ1Disappointed.Checked = false;

                //Quetion 02
                rbQ2Excellent.Checked = false;
                rbQ2Good.Checked = false;
                rbQ2Neutral.Checked = false;
                rbQ2Poor.Checked = false;
                rbQ2Disappointed.Checked = false;

                //Quetion 03
                rbQ3Excellent.Checked = false;
                rbQ3Good.Checked = false;
                rbQ3Neutral.Checked = false;
                rbQ3Poor.Checked = false;
                rbQ3Disappointed.Checked = false;

                //Quetion 04
                rbQ4Excellent.Checked = false;
                rbQ4Good.Checked = false;
                rbQ4Neutral.Checked = false;
                rbQ4Poor.Checked = false;
                rbQ4Disappointed.Checked = false;

                //Quetion 05
                rbQ5Excellent.Checked = false;
                rbQ5Good.Checked = false;
                rbQ5Neutral.Checked = false;
                rbQ5Poor.Checked = false;
                rbQ5Disappointed.Checked = false;

                //Quetion 06
                rbQ6Excellent.Checked = false;
                rbQ6Good.Checked = false;
                rbQ6Neutral.Checked = false;
                rbQ6Poor.Checked = false;
                rbQ6Disappointed.Checked = false;

                //Quetion 07
                rbQ7Excellent.Checked = false;
                rbQ7Good.Checked = false;
                rbQ7Neutral.Checked = false;
                rbQ7Poor.Checked = false;
                rbQ7Disappointed.Checked = false;

                //Quetion 08
                rbQ8Excellent.Checked = false;
                rbQ8Good.Checked = false;
                rbQ8Neutral.Checked = false;
                rbQ8Poor.Checked = false;
                rbQ8Disappointed.Checked = false;

                //Quetion 09
                rbQ9Excellent.Checked = false;
                rbQ9Good.Checked = false;
                rbQ9Neutral.Checked = false;
                rbQ9Poor.Checked = false;
                rbQ9Disappointed.Checked = false;

                //Quetion 10
                rbQ10Excellent.Checked = false;
                rbQ10Good.Checked = false;
                rbQ10Neutral.Checked = false;
                rbQ10Poor.Checked = false;
                rbQ10Disappointed.Checked = false;

                //Quetion 11
                rbQ11Excellent.Checked = false;
                rbQ11Good.Checked = false;
                rbQ11Neutral.Checked = false;
                rbQ11Poor.Checked = false;
                rbQ11Disappointed.Checked = false;

                //Quetion 12
                rbQ12Excellent.Checked = false;
                rbQ12Good.Checked = false;
                rbQ12Neutral.Checked = false;
                rbQ12Poor.Checked = false;
                rbQ12Disappointed.Checked = false;

                //Quetion 13
                rbQ13Excellent.Checked = false;
                rbQ13Good.Checked = false;
                rbQ13Neutral.Checked = false;
                rbQ13Poor.Checked = false;
                rbQ13Disappointed.Checked = false;

                //Quetion 14
                rbQ14Excellent.Checked = false;
                rbQ14Good.Checked = false;
                rbQ14Neutral.Checked = false;
                rbQ14Poor.Checked = false;
                rbQ14Disappointed.Checked = false;

                //Quetion 15
                rbQ15Excellent.Checked = false;
                rbQ15Good.Checked = false;
                rbQ15Neutral.Checked = false;
                rbQ15Poor.Checked = false;
                rbQ15Disappointed.Checked = false;

                //Quetion 16
                rbQ16Excellent.Checked = false;
                rbQ16Good.Checked = false;
                rbQ16Neutral.Checked = false;
                rbQ16Poor.Checked = false;
                rbQ16Disappointed.Checked = false;

                //Quetion 17
                rbQ17Excellent.Checked = false;
                rbQ17Good.Checked = false;
                rbQ17Neutral.Checked = false;
                rbQ17Poor.Checked = false;
                rbQ17Disappointed.Checked = false;

                //Quetion 18
                rbQ18Excellent.Checked = false;
                rbQ18Good.Checked = false;
                rbQ18Neutral.Checked = false;
                rbQ18Poor.Checked = false;
                rbQ18Disappointed.Checked = false;

                //Quetion 19
                rbQ19Excellent.Checked = false;
                rbQ19Good.Checked = false;
                rbQ19Neutral.Checked = false;
                rbQ19Poor.Checked = false;
                rbQ19Disappointed.Checked = false;

                //Quetion 20
                rbQ20Excellent.Checked = false;
                rbQ20Good.Checked = false;
                rbQ20Neutral.Checked = false;
                rbQ20Poor.Checked = false;
                rbQ20Disappointed.Checked = false;

                //Quetion 21
                rbQ21Excellent.Checked = false;
                rbQ21Good.Checked = false;
                rbQ21Neutral.Checked = false;
                rbQ21Poor.Checked = false;
                rbQ21Disappointed.Checked = false;

                //Quetion 22
                rbQ22Excellent.Checked = false;
                rbQ22Good.Checked = false;
                rbQ22Neutral.Checked = false;
                rbQ22Poor.Checked = false;
                rbQ22Disappointed.Checked = false;

                //Quetion 23
                rbQ23Excellent.Checked = false;
                rbQ23Good.Checked = false;
                rbQ23Neutral.Checked = false;
                rbQ23Poor.Checked = false;
                rbQ23Disappointed.Checked = false;

                //Quetion 24
                rbQ24Excellent.Checked = false;
                rbQ24Good.Checked = false;
                rbQ24Neutral.Checked = false;
                rbQ24Poor.Checked = false;
                rbQ24Disappointed.Checked = false;

                //Quetion 25
                rbQ25Excellent.Checked = false;
                rbQ25Good.Checked = false;
                rbQ25Neutral.Checked = false;
                rbQ25Poor.Checked = false;
                rbQ25Disappointed.Checked = false;

                //Quetion 26
                rbQ26Excellent.Checked = false;
                rbQ26Good.Checked = false;
                rbQ26Neutral.Checked = false;
                rbQ26Poor.Checked = false;
                rbQ26Disappointed.Checked = false;

                //Quetion 27
                rbQ27Excellent.Checked = false;
                rbQ27Good.Checked = false;
                rbQ27Neutral.Checked = false;
                rbQ27Poor.Checked = false;
                rbQ27Disappointed.Checked = false;
            }
        }
    }
}



//using (SqlCommand cmd = new SqlCommand("INSERT INTO QuestionForm(qdate,qepf,qname,q1,q2,q3,q4,q5,q6,q7,q8,q9,q10,q11,q12,q13,q14,q15,q16,q17,q18,q19,q20,21,q22,q23,q24,q25,q26,q27) VALUES(@qdate, @qepf, @qname, @q1, @q2,@q3,@q4,@q5,@q6,@q7,@q8,@q9,@q10,@q11,@q12,@q13,@q14,@q15,@q16,@q17,@q18,@q19,@q20,@q21,@q22,@q23,@q24,@q25,@q26,@q27)", connection))
//{
//    cmd.Parameters.AddWithValue("@qdate", DateTime.Now);
//    cmd.Parameters.AddWithValue("@qepf", qEPF.Value);
//    cmd.Parameters.AddWithValue("@qname", qNAME.Value);
//    cmd.Parameters.AddWithValue("@q1", ans1);
//    cmd.Parameters.AddWithValue("@q2", ans2);
//    cmd.Parameters.AddWithValue("@q3", ans3);
//    cmd.Parameters.AddWithValue("@q4", ans4);
//    cmd.Parameters.AddWithValue("@q5", ans5);
//    cmd.Parameters.AddWithValue("@q6", ans6);
//    cmd.Parameters.AddWithValue("@q7", ans7);
//    cmd.Parameters.AddWithValue("@q8", ans8);
//    cmd.Parameters.AddWithValue("@q9", ans9);
//    cmd.Parameters.AddWithValue("@q10", ans10);
//    cmd.Parameters.AddWithValue("@q11", ans11);
//    cmd.Parameters.AddWithValue("@q12", ans12);
//    cmd.Parameters.AddWithValue("@q13", ans13);
//    cmd.Parameters.AddWithValue("@q14", ans14);
//    cmd.Parameters.AddWithValue("@q15", ans15);
//    cmd.Parameters.AddWithValue("@q16", ans16);
//    cmd.Parameters.AddWithValue("@q17", ans17);
//    cmd.Parameters.AddWithValue("@q18", ans18);
//    cmd.Parameters.AddWithValue("@q19", ans19);
//    cmd.Parameters.AddWithValue("@q20", ans20);
//    cmd.Parameters.AddWithValue("@q21", ans21);
//    cmd.Parameters.AddWithValue("@q22", ans22);
//    cmd.Parameters.AddWithValue("@q23", ans23);
//    cmd.Parameters.AddWithValue("@q24", ans24);
//    cmd.Parameters.AddWithValue("@q25", ans25);
//    cmd.Parameters.AddWithValue("@q26", ans26);
//    cmd.Parameters.AddWithValue("@q27", ans27);
//    cmd.ExecuteNonQuery();
//}
//connection.Close();