<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Happiness_Index.Admin.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
    <style>
        .wrapper1 {
            height: 100vh !important;
            display: flex;
            align-items: center;
            flex-direction: column;
            justify-content: center;
            width: 100% !important;
            padding: 20px;
            background-color: #f5f5f5 !important;
        }

        .logincontainer {
            border-radius: 0px;
            background-color: #fff;
            width: 90%;
            max-width: 450px;
            position: relative;
            padding: 20px;
            border: 1px white solid;
            box-shadow: 0 15px 10px -10px #acacac;
        }

        .img-login {
            height:50px;
            width:50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="wrapper1">
                <div class="logincontainer">
                    <h3>
                        <img class="img-login" src="../Images/h2.png" />
                        User Login
                    </h3>

                    <hr />

                    <asp:TextBox ID="txtUsername" placeholder="Enter Username..." class="form-control" runat="server"></asp:TextBox>
                    <br />

                    <asp:TextBox ID="txtPassword" placeholder="Enter Password..." class="form-control" TextMode="Password" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-info form-control" OnClick="btnLogin_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
