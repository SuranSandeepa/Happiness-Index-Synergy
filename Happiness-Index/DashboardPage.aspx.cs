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
                    l1q1e.Text = q1Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Goods FROM QuestionForm WHERE q1 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q1g.Text = q1Good.ToString("0.0") + "%"; ;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Neutrals FROM QuestionForm WHERE q1 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q1n.Text = q1Neutral.ToString("0.0") + "%"; ;
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Poors FROM QuestionForm WHERE q1 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q1p.Text = q1Poor.ToString("0.0") + "%"; ;
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q1) AS Disappointeds FROM QuestionForm WHERE q1 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q1Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q1d.Text = q1Disappointed.ToString("0.0") + "%";
                }


                //Question 2

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Excellents FROM QuestionForm WHERE q2 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q2e.Text = q2Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Goods FROM QuestionForm WHERE q2 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q2g.Text = q2Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Neutrals FROM QuestionForm WHERE q2 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q2n.Text = q2Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Poors FROM QuestionForm WHERE q2 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q2p.Text = q2Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q2) AS Disappointeds FROM QuestionForm WHERE q2 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q2Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q2d.Text = q2Disappointed.ToString("0.0") + "%";
                }


                //Question 3

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Excellents FROM QuestionForm WHERE q3 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q3e.Text = q3Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Goods FROM QuestionForm WHERE q3 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q3g.Text = q3Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Neutrals FROM QuestionForm WHERE q3 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q3n.Text = q3Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Poors FROM QuestionForm WHERE q3 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q3p.Text = q3Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q3) AS Disappointeds FROM QuestionForm WHERE q3 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q3Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q3d.Text = q3Disappointed.ToString("0.0") + "%";
                }


                //Question 4

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Excellents FROM QuestionForm WHERE q4 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q4e.Text = q4Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Goods FROM QuestionForm WHERE q4 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q4g.Text = q4Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Neutrals FROM QuestionForm WHERE q4 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q4n.Text = q4Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Poors FROM QuestionForm WHERE q4 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q4p.Text = q4Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q4) AS Disappointeds FROM QuestionForm WHERE q4 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q4Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q4d.Text = q4Disappointed.ToString("0.0") + "%";
                }

                //Question 5

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Excellents FROM QuestionForm WHERE q5 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q5e.Text = q5Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Goods FROM QuestionForm WHERE q5 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q5g.Text = q5Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Neutrals FROM QuestionForm WHERE q5 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q5n.Text = q5Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Poors FROM QuestionForm WHERE q5 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q5p.Text = q5Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q5) AS Disappointeds FROM QuestionForm WHERE q5 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q5Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q5d.Text = q5Disappointed.ToString("0.0") + "%";
                }


                //Question 6

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q6) AS Excellents FROM QuestionForm WHERE q6 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q6Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q6e.Text = q6Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q6) AS Goods FROM QuestionForm WHERE q6 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q6Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q6g.Text = q6Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q6) AS Neutrals FROM QuestionForm WHERE q6 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q6Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q6n.Text = q6Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q6) AS Poors FROM QuestionForm WHERE q6 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q6Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q6p.Text = q6Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q6) AS Disappointeds FROM QuestionForm WHERE q6 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q6Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q6d.Text = q6Disappointed.ToString("0.0") + "%";
                }

                //Question 7

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q7) AS Excellents FROM QuestionForm WHERE q7 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q7Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q7e.Text = q7Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q7) AS Goods FROM QuestionForm WHERE q7 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q7Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q7g.Text = q7Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q7) AS Neutrals FROM QuestionForm WHERE q7 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q7Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q7n.Text = q7Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q7) AS Poors FROM QuestionForm WHERE q7 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q7Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q7p.Text = q7Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q7) AS Disappointeds FROM QuestionForm WHERE q7 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q7Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q7d.Text = q7Disappointed.ToString("0.0") + "%";
                }

                //Question 8

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q8) AS Excellents FROM QuestionForm WHERE q8 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q8Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q8e.Text = q8Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q8) AS Goods FROM QuestionForm WHERE q8 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q8Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q8g.Text = q8Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q8) AS Neutrals FROM QuestionForm WHERE q8 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q8Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q8n.Text = q8Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q8) AS Poors FROM QuestionForm WHERE q8 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q8Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q8p.Text = q8Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q8) AS Disappointeds FROM QuestionForm WHERE q8 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q8Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q8d.Text = q8Disappointed.ToString("0.0") + "%";
                }

                //Question 9

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q9) AS Excellents FROM QuestionForm WHERE q9 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q9Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q9e.Text = q9Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q9) AS Goods FROM QuestionForm WHERE q9 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q9Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q9g.Text = q9Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q9) AS Neutrals FROM QuestionForm WHERE q9 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q9Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q9n.Text = q9Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q9) AS Poors FROM QuestionForm WHERE q9 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q9Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q9p.Text = q9Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q9) AS Disappointeds FROM QuestionForm WHERE q9 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q9Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q9d.Text = q9Disappointed.ToString("0.0") + "%";
                }


                //Question 10

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q10) AS Excellents FROM QuestionForm WHERE q10 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q10Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q10e.Text = q10Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q10) AS Goods FROM QuestionForm WHERE q10 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q10Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q10g.Text = q10Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q10) AS Neutrals FROM QuestionForm WHERE q10 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q10Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q10n.Text = q10Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q10) AS Poors FROM QuestionForm WHERE q10 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q10Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q10p.Text = q10Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q10) AS Disappointeds FROM QuestionForm WHERE q10 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q10Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q10d.Text = q10Disappointed.ToString("0.0") + "%";
                }


                //Question 11

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q11) AS Excellents FROM QuestionForm WHERE q11 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q11Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q11e.Text = q11Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q11) AS Goods FROM QuestionForm WHERE q11 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q11Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q11g.Text = q11Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q11) AS Neutrals FROM QuestionForm WHERE q11 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q11Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q11n.Text = q11Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q11) AS Poors FROM QuestionForm WHERE q11 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q11Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q11p.Text = q11Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q11) AS Disappointeds FROM QuestionForm WHERE q11 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q11Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q11d.Text = q11Disappointed.ToString("0.0") + "%";
                }

                //Question 12

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q12) AS Excellents FROM QuestionForm WHERE q12 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q12Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q12e.Text = q12Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q12) AS Goods FROM QuestionForm WHERE q12 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q12Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q12g.Text = q12Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q12) AS Neutrals FROM QuestionForm WHERE q12 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q12Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q12n.Text = q12Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q12) AS Poors FROM QuestionForm WHERE q12 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q12Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q12p.Text = q12Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q12) AS Disappointeds FROM QuestionForm WHERE q12 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q12Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q12d.Text = q12Disappointed.ToString("0.0") + "%";
                }


                //Question 13

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q13) AS Excellents FROM QuestionForm WHERE q13 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q13Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q13e.Text = q13Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q13) AS Goods FROM QuestionForm WHERE q13 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q13Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q13g.Text = q13Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q13) AS Neutrals FROM QuestionForm WHERE q13 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q13Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q13n.Text = q13Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q13) AS Poors FROM QuestionForm WHERE q13 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q13Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q13p.Text = q13Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q13) AS Disappointeds FROM QuestionForm WHERE q13 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q13Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q13d.Text = q13Disappointed.ToString("0.0") + "%";
                }


                //Question 14

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q14) AS Excellents FROM QuestionForm WHERE q14 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q14Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q14e.Text = q14Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q14) AS Goods FROM QuestionForm WHERE q14 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q14Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q14g.Text = q14Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q14) AS Neutrals FROM QuestionForm WHERE q14 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q14Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q14n.Text = q14Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q14) AS Poors FROM QuestionForm WHERE q14 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q14Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q14p.Text = q14Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q14) AS Disappointeds FROM QuestionForm WHERE q14 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q14Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q14d.Text = q14Disappointed.ToString("0.0") + "%";
                }


                //Question 15

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q15) AS Excellents FROM QuestionForm WHERE q15 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q15Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q15e.Text = q15Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q15) AS Goods FROM QuestionForm WHERE q15 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q15Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q15g.Text = q15Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q15) AS Neutrals FROM QuestionForm WHERE q15 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q15Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q15n.Text = q15Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q15) AS Poors FROM QuestionForm WHERE q15 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q15Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q15p.Text = q15Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q15) AS Disappointeds FROM QuestionForm WHERE q15 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q15Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q15d.Text = q15Disappointed.ToString("0.0") + "%";
                }


                //Question 16

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q16) AS Excellents FROM QuestionForm WHERE q16 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q16Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q16e.Text = q16Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q16) AS Goods FROM QuestionForm WHERE q16 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q16Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q16g.Text = q16Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q16) AS Neutrals FROM QuestionForm WHERE q16 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q16Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q16n.Text = q16Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q16) AS Poors FROM QuestionForm WHERE q16 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q16Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q16p.Text = q16Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q16) AS Disappointeds FROM QuestionForm WHERE q16 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q16Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q16d.Text = q16Disappointed.ToString("0.0") + "%";
                }


                //Question 17

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q17) AS Excellents FROM QuestionForm WHERE q17 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q17Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q17e.Text = q17Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q17) AS Goods FROM QuestionForm WHERE q17 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q17Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q17g.Text = q17Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q17) AS Neutrals FROM QuestionForm WHERE q17 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q17Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q17n.Text = q17Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q17) AS Poors FROM QuestionForm WHERE q17 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q17Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q17p.Text = q17Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q17) AS Disappointeds FROM QuestionForm WHERE q17 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q17Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q17d.Text = q17Disappointed.ToString("0.0") + "%";
                }


                //Question 18

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q18) AS Excellents FROM QuestionForm WHERE q18 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q18Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q18e.Text = q18Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q18) AS Goods FROM QuestionForm WHERE q18 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q18Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q18g.Text = q18Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q18) AS Neutrals FROM QuestionForm WHERE q18 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q18Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q18n.Text = q18Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q18) AS Poors FROM QuestionForm WHERE q18 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q18Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q18p.Text = q18Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q18) AS Disappointeds FROM QuestionForm WHERE q18 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q18Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q18d.Text = q18Disappointed.ToString("0.0") + "%";
                }


                //Question 19

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q19) AS Excellents FROM QuestionForm WHERE q19 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q19Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q19e.Text = q19Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q19) AS Goods FROM QuestionForm WHERE q19 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q19Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q19g.Text = q19Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q19) AS Neutrals FROM QuestionForm WHERE q19 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q19Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q19n.Text = q19Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q19) AS Poors FROM QuestionForm WHERE q19 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q19Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q19p.Text = q19Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q19) AS Disappointeds FROM QuestionForm WHERE q19 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q19Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q19d.Text = q19Disappointed.ToString("0.0") + "%";
                }


                //Question 20

                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q20) AS Excellents FROM QuestionForm WHERE q20 = 'Excellent'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Excellents * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q20Excellent = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q20e.Text = q20Excellent.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q20) AS Goods FROM QuestionForm WHERE q20 = 'Good'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Goods * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q20Good = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q20g.Text = q20Good.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q20) AS Neutrals FROM QuestionForm WHERE q20 = 'Neutral'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Neutrals * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q20Neutral = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q20n.Text = q20Neutral.ToString("0.0") + "%";
                }
                // Execute the SQL query
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q20) AS Poors FROM QuestionForm WHERE q20 = 'Poor'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Poors * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q20Poor = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q20p.Text = q20Poor.ToString("0.0") + "%";
                }
                using (SqlCommand command = new SqlCommand("WITH cte AS (SELECT COUNT(q20) AS Disappointeds FROM QuestionForm WHERE q20 = 'Disappointed'),total AS(SELECT COUNT(*)AS TotalCount FROM QuestionForm) SELECT Disappointeds * 100.0 / TotalCount AS PercentageGoods FROM cte,total", connection))
                {
                    q20Disappointed = (decimal)command.ExecuteScalar();

                    // Output the result
                    l1q20d.Text = q20Disappointed.ToString("0.0") + "%";
                }
            }
        }
    }
}