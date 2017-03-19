<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Aktorler.aspx.cs" Inherits="ImdbBAOdev.Aktorler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1>AKTÖRLER</h1>
                    <hr />
                    <div class="table-responsive">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>Adı</th>
                                    <th>Doğum Tarihi</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("AktorAdi") %></td>
                                            <td><%#Eval("AktorDogumTarihi") %></td>
                                            <td>
                                                <a href="Filmler.aspx?ID=<%#Eval("FilmID") %>"
                                                    class="btn btn-warning">Filmleri Sırala</a>
                                                <a href="AktorDuzenle.aspx?ID=<%#Eval("AktorID") %>"
                                                    class="btn btn-danger">Duzenle</a>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </tbody>
                        </table>

                    </div>
                   
                </div>
                
            </div>
        </div>
</asp:Content>
