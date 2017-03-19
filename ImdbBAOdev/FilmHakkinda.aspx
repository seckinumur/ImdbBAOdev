<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="FilmHakkinda.aspx.cs" Inherits="ImdbBAOdev.FilmHakkinda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    /
    <link href="css/portfolio-item.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <asp:Label ID="FilmBaslik" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="row">
             <div class="col-md-4">
            <asp:Repeater ID="Bilgileri" runat="server">
                <ItemTemplate>
                        <img class="img-responsive" src="<%#Eval ("FilmAfisi") %>" alt="" style="width: 400px" />
                 <h3 id="yonetmenismi">
                   <a href="Yonetmenler.aspx?ID=<%#Eval("YonetmenID") %>">Yönetmeni</a>
                 </h3>
                </ItemTemplate>
            </asp:Repeater>
                <asp:Repeater ID="Oyunculari" runat="server">
                    <ItemTemplate>
                      <p>
                           <a href="Aktorler.aspx?ID=<%#Eval("AktorID") %>" ><h4><%#Eval ("AktorAdi") %></h4></a>
                            </p>
                            </ItemTemplate>
                </asp:Repeater>
            <div class="col-md-4">
                    <p>
                         <asp:Label ID="Yapimyili" runat="server" Text=""></asp:Label><br />
                       <asp:Label ID="turu" runat="server" Text=""></asp:Label>
                 </p>
                 </div>
                  <div class="col-md-12">
                    <asp:Label ID="Konusus" runat="server" Text="Filmin Konusu" Visible="False"></asp:Label>
                <p>
                   <asp:Label ID="Konu" runat="server" Text=""></asp:Label>
                </p>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                <p>
                    <a href="FilmDuzenleme.aspx?ID=<%#Eval("FilmID") %>" class="btn btn-primary">Düzenle</a> <a href="Filmler.aspx" class="btn btn-default">Film Sayfası</a>
                </p>
                        </ItemTemplate>
                     </asp:Repeater>
        </div>
</div>
        </div>
    </div>
    
    <script src="js/jquery.js"></script>
    
    <script src="js/bootstrap.min.js"></script>
</asp:Content>
