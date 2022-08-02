<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgretmenListesi.aspx.cs" Inherits="OgretmenListesi" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğretmen ID</th>
            <th>Ögretmen Ad-Soyad</th>
            <th>Öğretmen Branş</th>
            <th>Düzenle</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Ogrtid")%></td>
                        <td><%#Eval("Adsoyad")%></td>
                        <td><%#Eval("Brans")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"~/OgretmenGuncelle.aspx?OgretmenID=" + Eval("Ogrtid")%>' ID="HyperLink2" runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>


