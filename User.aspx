<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Appointment_System_and_Venue_Reservation.User" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
</p>
<table style="width: 100%; height: 130px">
    <tr>
        <td>&nbsp;</td>
        <td style="width: 318px">Firsname</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 318px">&nbsp;</td>
        <td style="width: 318px">Lastname</td>
        <td style="width: 318px">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td style="width: 318px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 318px; height: 25px;"></td>
        <td style="width: 318px; height: 25px;">Username</td>
        <td style="width: 318px; height: 25px;">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td style="width: 318px; height: 25px;"></td>
    </tr>
    <tr>
        <td style="width: 318px; height: 22px;"></td>
        <td style="width: 318px; height: 22px;">Usertype</td>
        <td style="width: 318px; height: 22px;">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="Admin"></asp:ListItem>
                <asp:ListItem Value="Client"></asp:ListItem>
            </asp:DropDownList>
        </td>
        <td style="width: 318px; height: 22px;"></td>
    </tr>
    <tr>
        <td style="width: 318px"></td>
        <td style="width: 318px">
            <asp:Button ID="Button1" runat="server" Text="ADD" Width="120px" OnClick="Button1_Click" />
        </td>
        <td style="width: 318px">
            <asp:Button ID="Button2" runat="server" Text="Clear" Width="120px" OnClick="Button2_Click" />
        </td>
        <td style="width: 318px">&nbsp;</td>
    </tr>
</table>
<p>
</p>
<asp:GridView ID="userList" runat="server" DataKeyNames="id"  OnRowDataBound="OnRowDataBound"
        OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit" OnRowUpdating="OnRowUpdating"
        OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added." AutoGenerateEditButton="true"
        ShowHeaderWhenEmpty="true" AutoGenerateDeleteButton="true">
    <%--<Columns>
                <asp:BoundField HeaderText="ID" />
                <asp:BoundField HeaderText="FIRSTNAME" />
                <asp:BoundField HeaderText="LASTNAME" />
                <asp:BoundField HeaderText="USERNAME" />
                <asp:BoundField HeaderText="USER_TYPE" />
                <asp:CommandField ShowEditButton="true" />
                <asp:CommandField ShowDeleteButton="true" />
                <asp:BoundField />
            </Columns>--%>
    <HeaderStyle BackColor="#666666" />
</asp:GridView>

</asp:Content>
