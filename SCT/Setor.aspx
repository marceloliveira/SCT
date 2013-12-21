<%@ Page Title="Setor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Setor.aspx.cs" Inherits="SCT.Setor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/NovoSetor.aspx">Novo Setor</asp:HyperLink>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit"
        DataKeyNames="codigo" ForeColor="#333333" GridLines="None" Width="300">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="setor" HeaderText="Setor" SortExpression="setor" />
                <asp:CommandField DeleteText="Apagar" ShowDeleteButton="True" EditText="Editar" ShowEditButton="True"/>
            </Columns>
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
</asp:Content>
