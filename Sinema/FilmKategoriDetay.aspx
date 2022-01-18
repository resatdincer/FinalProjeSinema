<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FilmKategoriDetay.aspx.cs" Inherits="Sinema.FilmKategoriDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView ID="FormView1" runat="server" DataKeyNames="FilmKategoriID" DataSourceID="SqlDataSource1">
             
        <EditItemTemplate>
            FilmKategoriId:
            <asp:Label ID="FilmKategoriIdLabel1" runat="server" Text='<%# Eval("FilmKategoriId") %>' />
            <br />
            FilmKategoriAdi:
            <asp:TextBox ID="FilmKategoriAdiTextBox" runat="server" Text='<%# Bind("FilmKategoriAdi") %>' />
            <br />
            KategoriAciklama:
            <asp:TextBox ID="KategoriAciklamaTextBox" runat="server" Text='<%# Bind("KategoriAciklama") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            FilmKategoriAdi:
            <asp:TextBox ID="FilmKategoriAdiTextBox" runat="server" Text='<%# Bind("FilmKategoriAdi") %>' />
            <br />
            KategoriAciklama:
            <asp:TextBox ID="KategoriAciklamaTextBox" runat="server" Text='<%# Bind("KategoriAciklama") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
             
    <ItemTemplate>
        FilmKategoriId:
        <asp:Label ID="FilmKategoriIdLabel" runat="server" Text='<%# Eval("FilmKategoriId") %>' />
        <br />
        FilmKategoriAdi:
        <asp:Label ID="FilmKategoriAdiLabel" runat="server" Text='<%# Bind("FilmKategoriAdi") %>' />
        <br />
        KategoriAciklama:
        <asp:Label ID="KategoriAciklamaLabel" runat="server" Text='<%# Bind("KategoriAciklama") %>' />
        <br />
        <a href='<%# "FilmKategori.aspx?FilmKategoriId="+Eval("FilmKategoriId") %>'>
                        Sil
                    </a>
    </ItemTemplate>
</asp:FormView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ModelSinema %>" SelectCommand="SELECT * FROM [FilmKategori] WHERE ([FilmKategoriId] = @FilmKategoriId)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="1" Name="FilmKategoriId" QueryStringField="FilmKategoriId" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>
