<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Turler.aspx.cs" Inherits="ImdbBAOdev.Turler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1>Film Türleri</h1>
                    <hr />
                    <div class="table-responsive">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>Film Türleri</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("FilminTuru") %></td>
                                            <td>
                                                <a href="Filmler.aspx?IDT=<%#Eval("FilmTuruID") %>"
                                                    class="btn btn-warning">Filmleri Sırala</a>
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
