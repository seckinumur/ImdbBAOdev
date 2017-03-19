<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AktorDuzenle.aspx.cs" Inherits="ImdbBAOdev.AktorDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1>Aktör Düzenle</h1>
                    <table class="table table-bordered">
                        <tr>
                            <td>
                                <asp:Label ID="label1" runat="server" Text="Aktör Adı:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtAd" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="label2" runat="server" Text="Doğum Tarihi:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSoyad" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnGuncelle"
                                    runat="server"
                                    Text="Güncelle"
                                    CssClass="btn btn-info btn-block" OnClick="btnGuncelle_Click"
                                    ></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="Button1"
                                    runat="server"
                                    Text="Sil"
                                    CssClass="btn btn-info btn-block" OnClick="Button1_Click" 
                                    ></asp:Button>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
</asp:Content>
