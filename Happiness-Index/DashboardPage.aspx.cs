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

namespace Happiness_Index
{
    public partial class DashboardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal q1Excellent, q1Good, q1Neutral, q1Poor, q1Disappointed,
                    q2Excellent, q2Good, q2Neutral, q2Poor, q2Disappointed,
                    q3Excellent, q3Good, q3Neutral, q3Poor, q3Disappointed,
                    q4Excellent, q4Good, q4Neutral, q4Poor, q4Disappointed,
                    q5Excellent, q5Good, q5Neutral, q5Poor, q5Disappointed,
                    q6Excellent, q6Good, q6Neutral, q6Poor, q6Disappointed,
                    q7Excellent, q7Good, q7Neutral, q7Poor, q7Disappointed,
                    q8Excellent, q8Good, q8Neutral, q8Poor, q8Disappointed,
                    q9Excellent, q9Good, q9Neutral, q9Poor, q9Disappointed,
                    q10Excellent, q10Good, q10Neutral, q10Poor, q10Disappointed,
                    q11Excellent, q11Good, q11Neutral, q11Poor, q11Disappointed,
                    q12Excellent, q12Good, q12Neutral, q12Poor, q12Disappointed,
                    q13Excellent, q13Good, q13Neutral, q13Poor, q13Disappointed,
                    q14Excellent, q14Good, q14Neutral, q14Poor, q14Disappointed,
                    q15Excellent, q15Good, q15Neutral, q15Poor, q15Disappointed,
                    q16Excellent, q16Good, q16Neutral, q16Poor, q16Disappointed,
                    q17Excellent, q17Good, q17Neutral, q17Poor, q17Disappointed,
                    q18Excellent, q18Good, q18Neutral, q18Poor, q18Disappointed,
                    q19Excellent, q19Good, q19Neutral, q19Poor, q19Disappointed,
                    q20Excellent, q20Good, q20Neutral, q20Poor, q20Disappointed,
                    q21Excellent, q21Good, q21Neutral, q21Poor, q21Disappointed,
                    q22Excellent, q22Good, q22Neutral, q22Poor, q22Disappointed,
                    q23Excellent, q23Good, q23Neutral, q23Poor, q23Disappointed,
                    q24Excellent, q24Good, q24Neutral, q24Poor, q24Disappointed,
                    q25Excellent, q25Good, q25Neutral, q25Poor, q25Disappointed,
                    q26Excellent, q26Good, q26Neutral, q26Poor, q26Disappointed,
                    q27Excellent, q27Good, q27Neutral, q27Poor, q27Disappointed;

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                //Question 1

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Excellents FROM QuestionForm WHERE q1 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label1.Text = "Question 1 Excellent &#128515; : " + q1Excellent;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Goods FROM QuestionForm WHERE q1 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label2.Text = "Question 1 Good &#128515; : " + q1Good;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Neutrals FROM QuestionForm WHERE q1 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label3.Text = "Question 1 Neutral &#128515; : " + q1Neutral;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Poors FROM QuestionForm WHERE q1 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label4.Text = "Question 1 Poor &#128515; : " + q1Poor;
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Disappointeds FROM QuestionForm WHERE q1 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label5.Text = "Question 1 Disappointed &#128515; : " + q1Disappointed;
                }


                //Question 2

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Excellents FROM QuestionForm WHERE q2 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label6.Text = "Question 2 Excellent &#128515; : " + q2Excellent;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Goods FROM QuestionForm WHERE q2 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label7.Text = "Question 2 Good &#128515; : " + q2Good;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Neutrals FROM QuestionForm WHERE q2 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label8.Text = "Question 2 Neutral &#128515; : " + q2Neutral;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Poors FROM QuestionForm WHERE q2 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label9.Text = "Question 2 Poor &#128515; : " + q2Poor;
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Disappointeds FROM QuestionForm WHERE q2 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label10.Text = "Question 2 Disappointed &#128515; : " + q2Disappointed;
                }


                //Question 3

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Excellents FROM QuestionForm WHERE q3 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label11.Text = "Question 3 Excellent &#128515; : " + q3Excellent;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Goods FROM QuestionForm WHERE q3 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label12.Text = "Question 3 Good &#128515; : " + q3Good;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Neutrals FROM QuestionForm WHERE q3 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label13.Text = "Question 3 Neutral &#128515; : " + q3Neutral;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Poors FROM QuestionForm WHERE q3 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label14.Text = "Question 3 Poor &#128515; : " + q3Poor;
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Disappointeds FROM QuestionForm WHERE q3 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label15.Text = "Question 3 Disappointed &#128515; : " + q3Disappointed;
                }


                //Question 4

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Excellents FROM QuestionForm WHERE q4 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label16.Text = "Question 4 Excellent &#128515; : " + q4Excellent;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Goods FROM QuestionForm WHERE q4 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label17.Text = "Question 4 Good &#128515; : " + q4Good;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Neutrals FROM QuestionForm WHERE q4 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label18.Text = "Question 4 Neutral &#128515; : " + q4Neutral;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Poors FROM QuestionForm WHERE q4 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label19.Text = "Question 4 Poor &#128515; : " + q4Poor;
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Disappointeds FROM QuestionForm WHERE q4 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label20.Text = "Question 4 Disappointed &#128515; : " + q4Disappointed;
                }

                //Question 5

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Excellents FROM QuestionForm WHERE q5 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label21.Text = "Question 5 Excellent &#128515; : " + q5Excellent;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Goods FROM QuestionForm WHERE q5 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label22.Text = "Question 5 Good &#128515; : " + q5Good;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Neutrals FROM QuestionForm WHERE q5 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label23.Text = "Question 5 Neutral &#128515; : " + q5Neutral;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Poors FROM QuestionForm WHERE q5 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label24.Text = "Question 5 Poor &#128515; : " + q5Poor;
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Disappointeds FROM QuestionForm WHERE q5 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    Label25.Text = "Question 5 Disappointed &#128515; : " + q5Disappointed;
                }
            }
        }
    }
}