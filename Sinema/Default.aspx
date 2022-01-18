<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sinema._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Dinçer SİNEMA</h1>
        <p class="lead">Film, Oyuncu, Yönetmen bilgilerinin ve film yorumlarını bulabileceğiniz platform..</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Hakkımızda &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>FİLMLER</h2>
            <p>
                Filmlerin hakkındaki bilgilerin, gişe rakamlarını, vizyona girdiği yılı ve daha birçok bilgiye ulaşabileceksiniz.
            </p>
            <p>
                <a class="btn btn-default" href="#">Filmler &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>OYUNCULAR</h2>
            <p>
                Film artistlerinin bulabileceğiniz ve onlar hakkında bilgileri öğrenebileceksiniz. Oynadıkları filmleri listeleyebileceksiniz.
            </p>
            <p>
                <a class="btn btn-default" href="#">Oyuncular &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>YÖNETMENLER</h2>
            <p>
                Yönetmenleri takip edebileceksiniz. Hangi filmi hangi yönetmenin yönettiği bilgisini edineceksiniz.
            </p>
            <p>
                <a class="btn btn-default" href="#">Yönetmenler &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
