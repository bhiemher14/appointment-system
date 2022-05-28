<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Appointment_System_and_Venue_Reservation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    



    <table align="center" class="nav-justified" style="height: 165px">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Width="479px">
                    <HeaderStyle BackColor="#666666" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add appointment" Width="149px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

    



</asp:Content>
