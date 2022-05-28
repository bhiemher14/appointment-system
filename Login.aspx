<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Appointment_System_and_Venue_Reservation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Appointment System and Venue Reservation</title>
 <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
            height: 358px;
        }
        form {
            border: 3px solid #f1f1f1;
        }
        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }
        button:hover {
            opacity: 0.8;
        }
        .cnbtn {
            background-color: #ec3f3f;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 49%;
        }
        .lgnbtn {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            cursor: pointer;
            border-radius: 8px;
            }
        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }
        img.avatar {
            width: 40%;
            border-radius: 50%;
        }
        .container {
            padding: 16px;
            height: 310px;
        }
        span.psw {
            float: right;
            padding-top: 16px;
        }
        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }
            .cnbtn {
                width: 100%;
                border-radius: 10px;
                
            }
        }
        .frmalg {
            margin: auto;
            width: 40%;
        }
        .errorMsg{
            padding-bottom: 10px;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="frmalg">
        <div class="container">
            <center>
                <h3>Login </h3>
            </center>
            <label for="uname"><b>Username</b></label>
            <asp:TextBox runat="server" ID="txtUsername" placeholder="Enter Username"></asp:TextBox>
            <label for="psw"><b>Password</b></label>
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="Enter Password"></asp:TextBox>
            <asp:Button runat="server" ID="btn_Login" CssClass="lgnbtn" Text="Submit" OnClick="btn_Login_Click1" Width="100%"> </asp:Button>
            <br />
            <asp:HyperLink runat="server" href="google.com" ID="txt_message" text="Forget Password?"/>
            <br />
            <br />
            <div class="errorMsg">
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            </div>
        </div>
    </form>
    
</body>
</html>
