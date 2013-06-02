<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RichalndCountyCheckRegistry._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Richland County Check Registry</h1>
            </hgroup>
            <p>
                Add description here...
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>
    <ol class="round">
        <li class="one">
            <h5>View Checks</h5>
            <a href="ViewChecks.aspx">Click Here...</a>
        </li>
        <li class="two">
            <h5>Contact Information</h5>
            <a href="Contact.aspx">Click Here...</a>
        </li>
        <li class="three">
            <h5>Official Richland County Website</h5>
            <a href="http://www.richlandonline.com/default.aspx">Click Here...</a>
        </li>
    </ol>
</asp:Content>
