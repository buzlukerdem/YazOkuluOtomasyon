<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DersListesi.aspx.cs" Inherits="DersListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form runat="server" style="text-align:center">
        <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px; font-size: 20px;"><strong>ÖĞRENCİ DERS SEÇME SAYFASI</strong></div>
        <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px;">
            <strong>
            <asp:Label ID="Label1" runat="server" Text="Ders Seç" style="font-size: 16px"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" ></asp:DropDownList>
            </strong>
        </div>

            <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px;">
            <strong>
            <asp:Label ID="Label2" runat="server" Text="Ogrenci ID" style="font-size: 16px"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            </strong>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Kayıt Yap" CssClass="btn btn-info" OnClick="Button1_Click"/>


    </form>
</asp:Content>

