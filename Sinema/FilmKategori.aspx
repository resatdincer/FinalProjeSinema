<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FilmKategori.aspx.cs" Inherits="Sinema.FilmKategori" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main-header">
        <%:Title %>
    </div>
    <asp:ListView ID="KategoriListView" runat="server">
        <LayoutTemplate>
            <div class="table-responsive">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>
                                ID
                            </th>
                            <th>
                                Adı
                            </th>
                            <th>
                                Açıklama
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server">
                        </asp:PlaceHolder>
                    </tbody>
                </table>
            </div>
        </LayoutTemplate>

        <ItemTemplate>
            <tr>
                <td>
                    <%# Eval("FilmKategoriId") %>
                </td>
                <td>
                    <%# Eval("FilmKategoriAdi") %>
                </td>
                <td>
                    <%# Eval("KategoriAciklama") %>
                </td>
                <td>
                    <a href='<%# "FilmKategoriDetay.aspx?FilmKategoriId="+Eval("FilmKategoriId") %>'>
                        Detay
                    </a>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
