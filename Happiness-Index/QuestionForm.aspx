<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionForm.aspx.cs" Inherits="Happiness_Index.QuestionForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>

    <style>
        .rb {
            font-size: 20px;
        }
    </style>
</head>
<body>
    <br />
    <form runat="server">
        <asp:Button ID="admin" CssClass="btn btn-primary me-5 " runat="server" Text="Admin" OnClick="admin_Click" />


        <div class="container" runat="server">

            <div class="row g-2">
                <div class="col-md">
                    <div class="form-floating">
                        <input type="email" class="form-control border-info" id="floatingInputGri" placeholder="name@example.com" runat="server" />
                        <label for="floatingInputGri">EPF අංකය</label>
                    </div>
                </div>
                <div class="col-md">
                    <div class="form-floating">
                        <input type="email" class="form-control border-info" id="floatingInputGrid" placeholder="name@example.com" runat="server" />
                        <label for="floatingInputGrid">ඔබගේ නම</label>
                    </div>
                </div>
            </div>

            <br />

            <div runat="server">
                <div class="form-row">
                    <p class="fw-semibold">1.ඔබට ලැබෙන වැටුප ඔබට ජිවත් වීම සදහා ප්‍රමාණවත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="rbExcellent" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="rbGood" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="rbNeutral" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="rbPoor" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton1" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">2.පසුගිය මස අතිකාල දීමනාව පිළිබද ඔබ තෘප්තිමත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton2" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton3" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton4" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton5" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton6" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">3.පසුගිය මස නිෂ්පාදන දිරිදීමනාව ලෙස ඔබට ලැබුණු මුදල් ප්‍රමාණය පිළිබද ඔබ තෘප්තිමත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton7" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton8" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton9" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton10" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton11" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">4.ආයතනයෙන් ලබා දෙන ආහාර වල රස සහ ගුණත්වය කෙබදුද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton12" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton13" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton14" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton15" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton16" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">5.ආයතනයෙන් ලබා දෙන ආහාර ප්‍රමාණය ඔබට ප්‍රමාණවත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton17" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton18" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton19" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton20" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton21" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">6.බස් රථ ප්‍රවාහන පහසුකම් සහ එහි ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton22" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton23" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton24" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton25" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton26" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">7.වෑන් රථ ප්‍රවාහන පහසුකම් සහ එහි ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton27" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton28" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton29" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton30" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton31" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">8.ඔබගේ මානසික සෞඛ්‍ය මට්ටම කෙබදුද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton32" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton33" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton34" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton35" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton36" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">9.වෛද්‍ය මද්‍යස්ථාන මගින් ඔබට ලැබෙන සේවය පිළිබද ඔබ තෘප්තිමත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton37" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton38" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton39" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton40" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton41" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">10.ආයතනයේ වැඩ පරිසරයේ ආරක්ෂාව පිළිබද ඔබගේ අදහස ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton42" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton43" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton44" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton45" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton46" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">11.ඔබට හොද නින්දක් ලැබෙනවාද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton47" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton48" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton49" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton50" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton51" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">12.ඔබට ඔබගේ පවුල සමග ගත කිරීමට ලැබෙන වේලාව කෙබදුද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton52" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton53" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton54" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton55" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton56" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">13.ආයතනය තුල ඔබට යහළුවන් සිටිනවාද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton57" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton58" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton59" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton60" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton61" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">14.වැඩ කරන පැය ගණන පිළිබද ඔබගේ අදහස කෙබදුද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton62" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton63" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton64" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton65" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton66" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">15.මනෝ විද්‍යා උපදේශකතුමියගේ සේවය පිළිබද ඔබගේ අදහස කුමක්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton67" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton68" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton69" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton70" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton71" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">16.ඔබගේ රැකියාව සම්බන්දව ඔබට ලැබෙන පුහුණුවීම් ප්‍රමාණවත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton72" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton73" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton74" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton75" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton76" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">17.ඔබගේ රැකියාවට අමතරව ඔබගේ හැකියාවන් වර්ධනයට ලැබෙන පුහුණුවීම් ප්‍රමාණවත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton77" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton78" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton79" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton80" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton81" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">18.පුහුණු උපදේශිකාවන් පිළිබද ඔබගේ අදහස ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton82" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton83" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton84" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton85" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton86" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">19.කලමනාකරිත්වය තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton87" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton88" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton89" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton90" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton91" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">20.සමූහ කණ්ඩායම් නායකයින් තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton92" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton93" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton94" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton95" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton96" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">21.කණ්ඩායම් නායකයින් තුලින් ඔබට ලැබෙන සහයෝගය ප්‍රමාණවත්ද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton97" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton98" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton99" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton100" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton101" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">22.සමානාත්මතාව සහ ගෞරවය රැකෙන පරිදි ඔබගේ උසස් නිලධාරීන් කටයුතු කරනවාද ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton102" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton103" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton104" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton105" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton106" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">23.සේවා උසස් වීම් සම්බන්දව ඔබගේ අදහස ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton107" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton108" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton109" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton110" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton111" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">24.ඔබ ලබා දෙන සේවය පිළිබද  ඇගයීම සම්බන්ද ඔබගේ අදහස ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton112" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton113" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton114" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton115" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton116" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">25.ආයතනය සමග තව ඉදිරියට රැදී සිටීමට බලාපොරොත්තු වන කාලය ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton117" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton118" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton119" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton120" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton121" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">26.ඔබට  නව යෝජනාවක් හෝ නව අදහසක් ඉදිරිපත් කිරීමට ඇති හැකියාව ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton122" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton123" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton124" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton125" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton126" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

                <div class="form-row">
                    <p class="fw-semibold">27.ඔබගේ නව අදහස් හා යෝජනා සම්බන්ද වන ඇගයීම සම්බන්ද ඔබේ අදහස ?</p>
                    <div class="mx-auto col-lg-8">
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton127" GroupName="feedback" class="rb" Text=" &#128515;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton128" GroupName="feedback" class="rb" Text=" &#128522;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton129" GroupName="feedback" class="rb" Text=" &#128578;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton130" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                        &nbsp;&nbsp;<asp:RadioButton ID="RadioButton131" GroupName="feedback" class="rb" Text=" &#128577;" runat="server" />
                    </div>
                </div>

                <hr />

            </div>
        </div>
    </form>


        <div class="progress-stacked">
        <div class="progress" role="progressbar" aria-label="Segment one" aria-valuenow="15" aria-valuemin="0" aria-valuemax="100" style="width: 15%">
            <div class="progress-bar"></div>
        </div>
        <div class="progress" role="progressbar" aria-label="Segment two" aria-valuenow="30" aria-valuemin="0" aria-valuemax="100" style="width: 30%">
            <div class="progress-bar bg-success"></div>
        </div>
        <div class="progress" role="progressbar" aria-label="Segment three" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100" style="width: 20%">
            <div class="progress-bar bg-info"></div>
        </div>
    </div>
</body>
</html>
