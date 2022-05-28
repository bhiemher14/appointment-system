<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="event.aspx.cs" Inherits="Appointment_System_and_Venue_Reservation._event" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>

    </p>

    <table align="center" class="nav-justified" style="height: 213px">
        <tr>
            <td class="modal-sm" style="width: 342px">&nbsp;</td>
            <td class="modal-sm" style="width: 277px">Meeting Title</td>
            <td style="width: 469px">
                <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="247px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 40px; width: 342px;"></td>
            <td style="height: 40px; width: 277px;">Description</td>
            <td style="height: 40px; width: 469px;">
                <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="247px"></asp:TextBox>
            </td>
            <td style="height: 40px">
                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="To cancel an upcoming event."></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 40px; width: 342px;"></td>
            <td style="height: 40px; width: 277px;">Date</td>
            <td style="height: 40px; width: 469px;">
                <asp:TextBox ID="TextBox3" runat="server" Height="26px" Width="247px" TextMode="Date"></asp:TextBox>
            </td>
            <td style="height: 40px">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="142px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="height: 40px; width: 342px;"></td>
            <td style="height: 40px; width: 277px;">Time start</td>
            <td style="height: 40px; width: 469px;">
                <asp:TextBox ID="TextBox4" runat="server" Height="26px" Width="247px" TextMode="Time"></asp:TextBox>
            </td>
            <td style="height: 40px">
                <asp:Button ID="Button3" runat="server" Height="32px" OnClick="Button3_Click" Text="CANCEL" Width="143px" />
            </td>
        </tr>
        <tr>
            <td style="height: 40px; width: 342px;"></td>
            <td style="height: 40px; width: 277px;">Time end</td>
            <td style="height: 40px; width: 469px;">
                <asp:TextBox ID="TextBox5" runat="server" Height="26px" Width="247px" TextMode="Time"></asp:TextBox>
            </td>
            <td style="height: 40px"></td>
        </tr>
        <tr>
            <td style="height: 40px; width: 342px;"></td>
            <td style="height: 40px; width: 277px;">Created by</td>
            <td style="height: 40px; width: 469px;">
                <asp:DropDownList ID="DropDownList2" runat="server" Height="25px"  Width="204px">
                </asp:DropDownList>
            <td style="height: 40px; width: 469px;">
            <td style="height: 40px"></td>
        </tr>
        <tr>
            <td style="height: 40px; width: 342px;">&nbsp;</td>
            <td style="height: 40px; width: 277px;">
                <asp:Button ID="Button4" runat="server" Text="Submit" Width="186px" OnClick="Button1_Click" />
            </td>
            <td style="height: 40px; width: 469px;">
                <asp:Button ID="Button5" runat="server" Text="Clear" Width="186px" OnClick="Button2_Click" />
             <td style="height: 40px; width: 469px;">
            <td style="height: 40px"></td>
        </tr>
    </table>

    <p>

    </p>

        <asp:GridView ID="eventList" runat="server" 
         EmptyDataText="No records has been added."
        ShowHeaderWhenEmpty="True" Width="100%" Height="178px">
            <HeaderStyle BackColor="#666666" ForeColor="White" />
        </asp:GridView>

    

</asp:Content>

