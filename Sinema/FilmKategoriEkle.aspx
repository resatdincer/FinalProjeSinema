
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FilmKategoriEkle.aspx.cs" Inherits="Sinema.FilmKategoriEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <asp:validationsummary runat="server" showmodelstateerrors="true" />
<asp:FormView runat="server" ID="addFilmKategoriForm" 
    ItemType="Sinema.Model.FilmKategori"  
    InsertMethod="addFilmKategoriForm_InsertItem" DefaultMode="Insert"
    RenderOuterTable="false" OnItemInserted="addFilmKategoriForm_ItemInserted">
    <InsertItemTemplate>
        <fieldset>
            <ol>
                <asp:DynamicEntity runat="server" Mode="Insert" />
            </ol>
            <asp:Button runat="server" Text="Insert" CommandName="Insert" />
            <asp:Button runat="server" Text="Cancel" CausesValidation="false" OnClick="cancelButton_Click" />
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>
</asp:Content>
