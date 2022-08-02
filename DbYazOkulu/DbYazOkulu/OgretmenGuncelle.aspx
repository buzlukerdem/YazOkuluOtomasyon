<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgretmenGuncelle.aspx.cs" Inherits="OgretmenGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group ">
            <div style="background-color: orange; margin-left: 400px; margin-right: 400px; margin-bottom: 30px; font-size: 18px; border: solid 3px; border-radius: 10px; text-align: center"><strong>ÖĞRETMEN GÜNCELLEME SAYFASI</strong></div>
            <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                <strong>
                    <asp:Label for="txtid" runat="server" Text="Öğretmen ID"></asp:Label>
                </strong>
                <asp:TextBox ID="txtid" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                <strong>
                    <asp:Label for="txtadsoyad" runat="server" Text="Öğretmen Ad Soyad"></asp:Label>
                </strong>
                <asp:TextBox ID="txtadsoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                    <strong>
                        <asp:Label for="txtbrans" runat="server" Text="Öğretmen Branş"></asp:Label>
                    </strong>
                    <asp:TextBox ID="txtbrans" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>

            
        <asp:Button Style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px" ID="Button1" runat="server" Text="KAYDET" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>


