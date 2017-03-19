<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="FilmEkle.aspx.cs" Inherits="ImdbBAOdev.FilmEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1>Film Ekle</h1>
                    <hr />

                    <table class="table table-bordered">
                        <tr>
                            <td>
                                <asp:Label ID="label1" runat="server" Text="Filmin Adı:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtAd" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label2" runat="server" Text="Yapım Yılı:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSoyad" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label3" runat="server" Text="Filmin Afişi(url):"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtTel" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label4" runat="server" Text="FilmTuru:"></asp:Label>
                               
                            </td>
                            <td>
                                <asp:DropDownList ID="FilmTuru" runat="server" DataSourceID="SqlDataSource1" DataTextField="FilminTuru" DataValueField="FilminTuru"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IbmdDB %>" SelectCommand="SELECT [FilminTuru] FROM [FilmTurus]"></asp:SqlDataSource>
                                <asp:EntityDataSource ID="EntityDataSource1" runat="server">
                                </asp:EntityDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label5" runat="server" Text="Filmin Konusu"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Konu" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label6" runat="server" Text="Filmin Yonetmeni:"></asp:Label>
                               
                            </td>
                            <td>
                                 <asp:TextBox ID="Yonetmensecim" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label7" runat="server" Text="Oyuncu 1"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Oyuncu1ri" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label9" runat="server" Text="Oyuncu 1 Doğum tarihi"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Odo" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label ID="label8" runat="server" Text="Oyuncu 2"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Oyuncu2ri" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label10" runat="server" Text="Oyuncu 2 Doğum tarihi"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="odo2" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnGuncelle"
                                    runat="server"
                                    Text="Ekle"
                                    CssClass="btn btn-info btn-block" OnClick="btnGuncelle_Click"  
                                    ></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="Button1"
                                    runat="server"
                                    Text="Vazgeç"
                                    CssClass="btn btn-info btn-block"  
                                    ></asp:Button>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
</asp:Content>
