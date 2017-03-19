<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="YonetmenDuzenle.aspx.cs" Inherits="ImdbBAOdev.YonetmenDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1>Yonetmen Düzenle</h1>
                    <hr />
                    <table class="table table-bordered">
                        <tr>
                            <td>
                                <asp:Label ID="label1" runat="server" Text="Yönetmen Adı::"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtAd" CssClass="form-control" runat="server"></asp:TextBox>
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
                    </table>
                </div>
            </div>
        </div>
</asp:Content>
