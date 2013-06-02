<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewChecks.aspx.cs" Inherits="RichalndCountyCheckRegistry.CountyChecks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Richland County Check Registry</h1>
            </hgroup>
            <p>
                You can filter and sort the data below.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:MultiView ID="ChecksMultiView" runat="server">
        <asp:View ID="CountyView" runat="server">
            <asp:UpdatePanel ID="CountyGridViewUpdatePanel" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <asp:GridView ID="CountyGridView" runat="server"
                        CellPadding="3" CellSpacing="3" GridLines="Both" BorderStyle="Solid" BackColor="White"
                        ItemType="RichalndCountyCheckRegistry.CountyCheck"
                        AllowSorting="true" AllowPaging="true" AutoGenerateColumns="false" SelectMethod="CountyGridView_GetData" OnSorting="CountyGridView_Sorting">
                        <AlternatingRowStyle BackColor="#ccffff" />
                        <HeaderStyle BackColor="#66ccff" />
                        <PagerStyle BackColor="#66ccff" />
                        <Columns>
                            <asp:TemplateField HeaderText="Check Number">
                                <ItemTemplate>
                                    <asp:Label ID="CheckNumber" runat="server" Text="<%#:Item.CheckNumber%>"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Check Date">
                                <ItemTemplate>
                                    <asp:Label ID="CheckDate" runat="server" Text='<%#:Item.CheckDate.ToString("d") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Category" SortExpression="Category">
                                <ItemTemplate>
                                    <asp:Label ID="Category" runat="server" Text="<%#:Item.Category %>"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SubSystem" SortExpression="Subsystem">
                                <ItemTemplate>
                                    <asp:Label ID="Subsystem" runat="server" Text="<%#:Item.Subsystem %>"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Vendor Name" SortExpression="VenderName">
                                <ItemTemplate>
                                    <asp:Label ID="VendorName" runat="server" Text="<%#:Item.VenderName %>"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status" SortExpression="Status_CD">
                                <ItemTemplate>
                                    <asp:Label ID="Status" runat="server" Text="<%#:Item.Status_CD %>"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Amount" SortExpression="Amount">
                                <ItemTemplate>
                                    <asp:Label ID="Amount" runat="server" Text='<%#:String.Format("{0:C}",Item.Amount) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </asp:View>
        <asp:View ID="CityView" runat="server">
        </asp:View>
    </asp:MultiView>
</asp:Content>
