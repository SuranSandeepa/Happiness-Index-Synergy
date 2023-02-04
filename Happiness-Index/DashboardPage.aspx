<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="DashboardPage.aspx.cs" Inherits="Happiness_Index.DashboardPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <div class="container">
        <div class="progress-stacked">
            <div class="progress" role="progressbar" aria-label="Segment one" aria-valuenow="15" aria-valuemin="0" aria-valuemax="100" style="width: 15%">
                <div class="progress-bar">15%&#128515;</div>
            </div>
            <div class="progress" role="progressbar" aria-label="Segment two" aria-valuenow="30" aria-valuemin="0" aria-valuemax="100" style="width: 30%">
                <div class="progress-bar bg-success">20%&#128515;</div>
            </div>
            <div class="progress" role="progressbar" aria-label="Segment three" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100" style="width: 20%">
                <div class="progress-bar bg-info"></div>
            </div>
            <div class="progress" role="progressbar" aria-label="Segment four" aria-valuenow="10" aria-valuemin="0" aria-valuemax="100" style="width: 10%">
                <div class="progress-bar bg-warning"></div>
            </div>
        </div>
    </div>

</asp:Content>
