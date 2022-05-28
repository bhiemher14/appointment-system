<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Appointment_System_and_Venue_Reservation.Account" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <br />



            <div class="card-card-header">
             <table style="width: 100%; height: 130px">
                    <tr>
                        <td style="height: 36px"></td>
                        <td style="width: 318px; height: 36px;">
                            Firstname</td>
                        <td style="height: 36px">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td style="height: 36px"></td>
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
                        <td style="width: 318px; height: 22px;">
                            <asp:Button ID="Button1" runat="server" Text="SUBMIT" Width="309px" OnClick="Button1_Click"  />
                        </td>
                        <td style="width: 318px; height: 22px;">
                            &nbsp;</td>
                        <td style="width: 318px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 318px"></td>
                        <td style="width: 318px">
                            &nbsp;</td>
                        <td style="width: 318px">
                            &nbsp;</td>
                        <td style="width: 318px">&nbsp;</td>
                    </tr>
                </table>
                </div>

    </asp:Content>
