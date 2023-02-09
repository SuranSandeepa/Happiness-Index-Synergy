<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="DashboardPage.aspx.cs" Inherits="Happiness_Index.DashboardPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Body.css" rel="stylesheet" />
    <style>
        @media only screen and (max-width: 767px) {
            .col-sm {
                width: 100% !important;
            }
        }

        .cardView {
            background-color: #f5f5f5;
            box-shadow: 1px 1px 1px #888;
        }

            .cardView:hover {
                background-color: skyblue;
                color: white;
                box-shadow: 3px 3px 3px #888;
                transition-duration: all 0.2s;
            }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <body style="margin-top: 80px;">

        <div class="container p-2">


            <p class="fw-semibold">1.ඔබට ලැබෙන වැටුප ඔබට ජිවත් වීම සදහා ප්‍රමාණවත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 1</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q1e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 1</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q1g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 1</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q1n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 1</div>
                        <div class="card-body">Poor &#128543;</div>
                        <div class="card-footer">
                            <asp:Label ID="l1q1p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 1</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q1d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">2.පසුගිය මස අතිකාල දීමනාව පිළිබද ඔබ තෘප්තිමත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 2</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q2e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 2</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q2g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 2</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q2n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 2</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q2p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 2</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q2d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">3.පසුගිය මස නිෂ්පාදන දිරිදීමනාව ලෙස ඔබට ලැබුණු මුදල් ප්‍රමාණය පිළිබද ඔබ තෘප්තිමත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 3</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q3e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 3</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q3g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 3</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q3n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 3</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q3p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 3</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q3d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">4.ආයතනයෙන් ලබා දෙන ආහාර වල රස සහ ගුණත්වය කෙබදුද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 4</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q4e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 4</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q4g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 4</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q4n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 4</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q4p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 4</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q4d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>


            <hr />

            <p class="fw-semibold">5.ආයතනයෙන් ලබා දෙන ආහාර ප්‍රමාණය ඔබට ප්‍රමාණවත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 5</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q5e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 5</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q5g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 5</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q5n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 5</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q5p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 5</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q5d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">6.බස් රථ ප්‍රවාහන පහසුකම් සහ එහි ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 6</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q6e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 6</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q6g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 6</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q6n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 6</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q6p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 6</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q6d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">7.වෑන් රථ ප්‍රවාහන පහසුකම් සහ එහි ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 7</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q7e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 7</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q7g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 7</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q7n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 7</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q7p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 7</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q7d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">8.ඔබගේ මානසික සෞඛ්‍ය මට්ටම කෙබදුද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 8</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q8e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 8</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q8g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 8</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q8n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 8</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q8p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 8</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q8d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">9.වෛද්‍ය මද්‍යස්ථාන මගින් ඔබට ලැබෙන සේවය පිළිබද ඔබ තෘප්තිමත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 9</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q9e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 9</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q9g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 9</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q9n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 9</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q9p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 9</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q9d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">10.ආයතනයේ වැඩ පරිසරයේ ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 10</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q10e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 10</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q10g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 10</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q10n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 10</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q10p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 10</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q10d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">11.ඔබට හොද නින්දක් ලැබෙනවාද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 11</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q11e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 11</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q11g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 11</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q11n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 11</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q11p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 11</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q11d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">12.ඔබට ඔබගේ පවුල සමග ගත කිරීමට ලැබෙන වේලාව කෙබදුද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 12</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q12e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 12</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q12g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 12</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q12n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 12</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q12p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 12</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q12d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">13.ආයතනය තුල ඔබට යහළුවන් සිටිනවාද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 13</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q13e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 13</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q13g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 13</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q13n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 13</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q13p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 13</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q13d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">14.වැඩ කරන පැය ගණන පිළිබද ඔබගේ අදහස කෙබදුද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 14</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q14e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 14</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q14g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 14</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q14n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 14</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q14p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 14</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q14d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">15.මනෝ විද්‍යා උපදේශකතුමියගේ සේවය පිළිබද ඔබගේ අදහස කුමක්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 15</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q15e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 15</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q15g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 15</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q15n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 15</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q15p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 15</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q15d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">16.ඔබගේ රැකියාව සම්බන්දව ඔබට ලැබෙන පුහුණුවීම් ප්‍රමාණවත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 16</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q16e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 16</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q16g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 16</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q16n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 16</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q16p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 16</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q16d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">17.ඔබගේ රැකියාවට අමතරව ඔබගේ හැකියාවන් වර්ධනයට ලැබෙන පුහුණුවීම් ප්‍රමාණවත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 17</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q17e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 17</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q17g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 17</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q17n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 17</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q17p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 17</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q17d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">18.පුහුණු උපදේශිකාවන් පිළිබද ඔබගේ අදහස ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 18</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q18e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 18</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q18g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 18</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q18n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 18</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q18p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 18</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q18d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">19.කලමනාකරිත්වය තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 19</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q19e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 19</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q19g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 19</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q19n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 19</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q19p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 19</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q19d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">20.සමූහ කණ්ඩායම් නායකයින් තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 20</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q20e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 20</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q20g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 20</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q20n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 20</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q20p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 20</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q20d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">21.කණ්ඩායම් නායකයින් තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 21</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q21e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 21</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q21g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 21</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q21n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 21</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q21p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 21</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q21d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">22.සමානාත්මතාව සහ ගෞරවය රැකෙන පරිදි ඔබගේ උසස් නිලධාරීන් කටයුතු කරනවාද ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 22</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q22e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 22</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q22g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 22</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q22n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 22</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q22p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 22</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q22d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">23.සේවා උසස් වීම් සම්බන්දව ඔබගේ අදහස ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 23</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q23e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 23</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q23g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 23</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q23n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 23</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q23p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 23</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q23d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">24.ඔබ ලබා දෙන සේවය පිළිබද  ඇගයීම සම්බන්ද ඔබගේ අදහස ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 24</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q24e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 24</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q24g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 24</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q24n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 24</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q24p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 24</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q24d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">25.ආයතනය සමග තව ඉදිරියට රැදී සිටීමට බලාපොරොත්තු වන කාලය ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 25</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q25e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 25</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q25g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 25</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q25n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 25</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q25p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 25</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q25d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">26.ඔබට  නව යෝජනාවක් හෝ නව අදහසක් ඉදිරිපත් කිරීමට ඇති හැකියාව ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 26</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q26e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 26</div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q26g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 26</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q26n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 26</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q26p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 26</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q26d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <p class="fw-semibold">27.ඔබගේ නව අදහස් හා යෝජනා සම්බන්ද වන ඇගයීම සම්බන්ද ඔබේ අදහස ?</p>
            <div class="row p-2 text-center">
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 27</div>
                        <div class="card-body">Excellent &#128512; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q27e" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">
                            Question 27
                        </div>
                        <div class="card-body">Good &#128578; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q27g" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 27</div>
                        <div class="card-body">Neutral &#128528; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q27n" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 27</div>
                        <div class="card-body">Poor &#128543; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q27p" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
                <div class="col-sm">
                    <div class="card cardView">
                        <div class="card-header">Question 27</div>
                        <div class="card-body">Disappointed &#128549; </div>
                        <div class="card-footer">
                            <asp:Label ID="l1q27d" runat="server" Text="0" />
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </body>
</asp:Content>
