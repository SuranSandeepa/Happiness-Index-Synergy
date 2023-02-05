<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="QuestionsPage.aspx.cs" Inherits="Happiness_Index.Employees.QuestionsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <div class="container" runat="server">

        <div class="row g-2">
            <div class="col-md">
                <div class="form-floating">
                    <input type="email" class="form-control border-info" id="qEPF" placeholder="eg:12345" runat="server" />
                    <label for="qEPF">EPF අංකය</label>
                </div>
            </div>
            <div class="col-md">
                <div class="form-floating">
                    <input type="text" class="form-control border-info" id="qNAME" placeholder="Suran" runat="server" />
                    <label for="qNAME">ඔබගේ නම</label>
                </div>
            </div>
        </div>

        <br />

        <div runat="server">

            <div class="form-row">
                <p class="fw-semibold">1.ඔබට ලැබෙන වැටුප ඔබට ජිවත් වීම සදහා ප්‍රමාණවත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ1Excellent" GroupName="q1" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ1Good" GroupName="q1" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ1Neutral" GroupName="q1" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ1Poor" GroupName="q1" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ1Disappointed" GroupName="q1" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">2.පසුගිය මස අතිකාල දීමනාව පිළිබද ඔබ තෘප්තිමත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ2Excellent" GroupName="q2" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ2Good" GroupName="q2" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ2Neutral" GroupName="q2" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ2Poor" GroupName="q2" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ2Disappointed" GroupName="q2" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">3.පසුගිය මස නිෂ්පාදන දිරිදීමනාව ලෙස ඔබට ලැබුණු මුදල් ප්‍රමාණය පිළිබද ඔබ තෘප්තිමත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ3Excellent" GroupName="q3" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ3Good" GroupName="q3" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ3Neutral" GroupName="q3" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ3Poor" GroupName="q3" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ3Disappointed" GroupName="q3" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">4.ආයතනයෙන් ලබා දෙන ආහාර වල රස සහ ගුණත්වය කෙබදුද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ4Excellent" GroupName="q4" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ4Good" GroupName="q4" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ4Neutral" GroupName="q4" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ4Poor" GroupName="q4" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ4Disappointed" GroupName="q4" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">5.ආයතනයෙන් ලබා දෙන ආහාර ප්‍රමාණය ඔබට ප්‍රමාණවත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ5Excellent" GroupName="q5" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ5Good" GroupName="q5" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ5Neutral" GroupName="q5" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ5Poor" GroupName="q5" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ5Disappointed" GroupName="q5" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">6.බස් රථ ප්‍රවාහන පහසුකම් සහ එහි ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ6Excellent" GroupName="q6" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ6Good" GroupName="q6" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ6Neutral" GroupName="q6" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ6Poor" GroupName="q6" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ6Disappointed" GroupName="q6" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">7.වෑන් රථ ප්‍රවාහන පහසුකම් සහ එහි ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ7Excellent" GroupName="q7" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ7Good" GroupName="q7" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ7Normal" GroupName="q7" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ7Neutral" GroupName="q7" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ7Poor" GroupName="q7" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">8.ඔබගේ මානසික සෞඛ්‍ය මට්ටම කෙබදුද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ8Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ8Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ8Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ8Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ8Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">9.වෛද්‍ය මද්‍යස්ථාන මගින් ඔබට ලැබෙන සේවය පිළිබද ඔබ තෘප්තිමත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ9Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ9Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ9Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ9Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ9Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">10.ආයතනයේ වැඩ පරිසරයේ ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ10Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ10Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ10Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ10Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ10Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">11.ඔබට හොද නින්දක් ලැබෙනවාද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ11Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ11Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ11Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ11Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ11Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">12.ඔබට ඔබගේ පවුල සමග ගත කිරීමට ලැබෙන වේලාව කෙබදුද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ12Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ12Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ12Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ12Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ12Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">13.ආයතනය තුල ඔබට යහළුවන් සිටිනවාද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ13Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ13Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ13Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ13Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ13Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">14.වැඩ කරන පැය ගණන පිළිබද ඔබගේ අදහස කෙබදුද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ14Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ14Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ14Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ14Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ14Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">15.මනෝ විද්‍යා උපදේශකතුමියගේ සේවය පිළිබද ඔබගේ අදහස කුමක්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ15Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ15Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ15Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ15Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ15Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">16.ඔබගේ රැකියාව සම්බන්දව ඔබට ලැබෙන පුහුණුවීම් ප්‍රමාණවත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ16Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ16Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ16Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ16Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ16Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">17.ඔබගේ රැකියාවට අමතරව ඔබගේ හැකියාවන් වර්ධනයට ලැබෙන පුහුණුවීම් ප්‍රමාණවත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ17Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ17Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ17Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ17Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ17Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">18.පුහුණු උපදේශිකාවන් පිළිබද ඔබගේ අදහස ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ18Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ18Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ18Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ18Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ18Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">19.කලමනාකරිත්වය තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ19Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ19Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ19Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ19Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ19Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">20.සමූහ කණ්ඩායම් නායකයින් තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ20Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ20Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ20Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ20Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ20Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">21.කණ්ඩායම් නායකයින් තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ21Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ21Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ21Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ21Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ21Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">22.සමානාත්මතාව සහ ගෞරවය රැකෙන පරිදි ඔබගේ උසස් නිලධාරීන් කටයුතු කරනවාද ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ22Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ22Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ22Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ22Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ22Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">23.සේවා උසස් වීම් සම්බන්දව ඔබගේ අදහස ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ23Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ23Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ23Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ23Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ23Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">24.ඔබ ලබා දෙන සේවය පිළිබද  ඇගයීම සම්බන්ද ඔබගේ අදහස ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ24Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ24Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ24Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ24Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ24Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">25.ආයතනය සමග තව ඉදිරියට රැදී සිටීමට බලාපොරොත්තු වන කාලය ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ25Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ25Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ25Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ25Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ25Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">26.ඔබට  නව යෝජනාවක් හෝ නව අදහසක් ඉදිරිපත් කිරීමට ඇති හැකියාව ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ26Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ26Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ26Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ26Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ26Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

            <div class="form-row">
                <p class="fw-semibold">27.ඔබගේ නව අදහස් හා යෝජනා සම්බන්ද වන ඇගයීම සම්බන්ද ඔබේ අදහස ?</p>
                <div class="mx-auto col-lg-8">
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ27Excellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ27Good" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ27Normal" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ27Neutral" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    &nbsp;&nbsp;<asp:RadioButton ID="rbQ27Poor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                </div>
            </div>

            <hr />

        </div>

        <div class="d-grid gap-2 d-md-flex justify-content-md-end">
            <asp:Button ID="save" class="btn btn-primary" runat="server" Text="Save" OnClick="save_Click" />
            <asp:Button ID="cancel" class="btn btn-warning" runat="server" Text="Cancel" OnClick="cancel_Click" />
        </div>
        <br />
        
    </div>

</asp:Content>
