<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="DashboardPage.aspx.cs" Inherits="Happiness_Index.DashboardPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        @media only screen and (max-width: 767px) {
            .col-sm {
                width: 100% !important;
            }
        }

        .cardView{
            background-color:#f5f5f5;
            box-shadow:1px 1px 1px #888;
        }

        .cardView:hover{
            background-color:skyblue;
            color:white;
            box-shadow:3px 3px 3px #888;
            transition-duration: all 0.2s;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />


    <div class="container p-2">
        <div class="row p-2 text-center">
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 1</div>
                    <div class="card-body">Excellent &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q1e" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 1</div>
                    <div class="card-body">Good &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q1g" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 1</div>
                    <div class="card-body">Neutral &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q1n" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 1</div>
                    <div class="card-body">Poor &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q1p" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 1</div>
                    <div class="card-body">Disappointed &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q1d" runat="server" Text="0" />
                    </div>
                </div>
            </div>
        </div>

        <hr />

        <div class="row p-2 text-center">
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 2</div>
                    <div class="card-body">Excellent &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q2e" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 2</div>
                    <div class="card-body">Good &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q2g" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 2</div>
                    <div class="card-body">Neutral &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q2n" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 2</div>
                    <div class="card-body">Poor &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q2p" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 2</div>
                    <div class="card-body">Disappointed &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q2d" runat="server" Text="0" />
                    </div>
                </div>
            </div>
        </div>

        <hr />

        <div class="row p-2 text-center">
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 3</div>
                    <div class="card-body">Excellent &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q3e" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 3</div>
                    <div class="card-body">Good &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q3g" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 3</div>
                    <div class="card-body">Neutral &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q3n" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 3</div>
                    <div class="card-body">Poor &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q3p" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 3</div>
                    <div class="card-body">Disappointed &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q3d" runat="server" Text="0" />
                    </div>
                </div>
            </div>
        </div>

        <hr />

        <div class="row p-2 text-center">
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 4</div>
                    <div class="card-body">Excellent &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q4e" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 4</div>
                    <div class="card-body">Good &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q4g" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 4</div>
                    <div class="card-body">Neutral &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q4n" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 4</div>
                    <div class="card-body">Poor &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q4p" runat="server" Text="0" />
                    </div>
                </div>
            </div>
            <div class="col-sm">
                <div class="card cardView">
                    <div class="card-header">Question 4</div>
                    <div class="card-body">Disappointed &#128515; </div>
                    <div class="card-footer">
                        <asp:Label ID="l1q4d" runat="server" Text="0" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
