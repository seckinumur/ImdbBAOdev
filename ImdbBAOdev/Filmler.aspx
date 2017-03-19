<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Filmler.aspx.cs" Inherits="ImdbBAOdev.FilmListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

         <!-- Page Content -->
    <div class="container">
        <!-- Title -->
        <div class="row">
            <div class="col-lg-12">
                <h3>Film Listesi</h3>
            </div>
        </div>
        <hr/>
        <!-- /.row -->
        <!-- Page Features -->
       
        <div class="row text-center">
             <asp:Repeater ID="FilmKarti" runat="server">
                 <ItemTemplate>
            <div class="col-md-3 col-sm-6 hero-feature">
                <div class="thumbnail">
                    <img src="<%#Eval ("FilmAfisi") %>" alt="" style="width:800px"/>
                    <div class="caption">
                        <h3><%#Eval ("Adi") %></h3>
                            <h4><%#Eval ("YapimYili") %></h4>
                        <p>
                            <a href="FilmDuzenleme.aspx?ID=<%#Eval("FilmID") %>" class="btn btn-primary">Düzenle</a> <a href="FilmHakkinda.aspx?ID=<%#Eval("FilmID") %>" class="btn btn-default">Hakkında</a>
                        </p>
                    </div>
                </div>
            </div>
                     </ItemTemplate>
             </asp:Repeater>
        </div>
        
        <hr/>
    </div>
    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>

</asp:Content>
