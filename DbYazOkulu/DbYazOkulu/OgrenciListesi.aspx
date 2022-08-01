<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Ogrenci Bakiye</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Düzenle</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Ogrid")%></td>
                        <td><%#Eval("Ad")%></td>
                        <td><%#Eval("Soyad")%></td>
                        <td><%#Eval("Numara")%></td>
                        <td><%#Eval("Sifre")%></td>
                        <td><%#Eval("Bakiye")%></td>
                        <td><%#Eval("Fotograf")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciSil.aspx?OgrenciID=" + Eval("Ogrid")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OgrenciID=" + Eval("Ogrid")%>' ID="HyperLink2" runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

