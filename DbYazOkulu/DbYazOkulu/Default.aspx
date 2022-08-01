<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px">
                <strong>
                    <asp:Label for="txtadd" runat="server" Text="Öğrenci Ad"></asp:Label>
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
                        <asp:Label for="txtfoto" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
                    </strong>
                    <asp:TextBox ID="txtfoto" runat="server" CssClass="form-control"></asp:TextBox>
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
        <asp:Button style="margin-left: 400px; margin-right: 400px; margin-bottom: 30px" ID="Button1" runat="server" Text="KAYDET" OnClick="Button1_Click1" CssClass="btn btn-info" />
    </form>
</asp:Content>

