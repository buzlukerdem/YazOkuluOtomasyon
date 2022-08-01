<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group ">
            <div style="background-color: orange; margin-left: 400px; margin-right: 400px; margin-bottom: 30px; font-size: 18px; border: solid 3px; border-radius: 10px; text-align: center"><strong>ÖĞRENCİ GÜNCELLEME SAYFASI</strong></div>
            <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                <strong>
                    <asp:Label for="txtid" runat="server" Text="Öğrenci ID"></asp:Label>
                </strong>
                <asp:TextBox ID="txtid" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                <strong>
                    <asp:Label for="txtad" runat="server" Text="Öğrenci Ad"></asp:Label>
                </strong>
                <asp:TextBox ID="txtad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                    <strong>
                        <asp:Label for="txtsoyad" runat="server" Text="Öğrenci Soyad"></asp:Label>
                    </strong>
                    <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                    <strong>
                        <asp:Label for="txtno" runat="server" Text="Öğrenci Numara"></asp:Label>
                    </strong>
                    <asp:TextBox ID="txtno" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>



            <div class="form-group">
                <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                    <strong>
                        <asp:Label for="txtsifre" runat="server" Text="Öğrenci Şifre"></asp:Label>
                    </strong>
                    <asp:TextBox ID="txtsifre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                <strong>
                    <asp:Label for="txtbakiye" runat="server" Text="Öğrenci Bakiye"></asp:Label>
                </strong>
                <asp:TextBox ID="txtbakiye" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                <strong>
                    <asp:Label for="txtfoto" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
                </strong>
                <asp:TextBox ID="txtfoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button Style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px" ID="Button1" runat="server" Text="KAYDET" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>

