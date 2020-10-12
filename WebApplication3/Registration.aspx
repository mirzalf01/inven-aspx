<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication3.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8">
    <script src="jquery-3.3.1.js"></script>
    <script src="login.js"></script>
	<link rel="stylesheet" type="text/css" href="login.css">
</head>
<body>
   <form id="form1" runat="server" class="body">
        <div class="l-body">
			<div class="menu">
				<ul>
					<li class="menu1">Register</li>
				</ul>
			</div>
		</div>
		<div class="r-body">
			<div class="r-menu1">
				<div class="h1">
					<h1>Register</h1>
					<form class="form">
                        <asp:TextBox ID="TextBox1" class="input" runat="server" placeholder="Enter Username"></asp:TextBox><br />
                        <asp:TextBox ID="TextBox2" class="input" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox><br />
                        <asp:Button ID="Button1" runat="server" class="button" Text="Register" OnClick="Button1_Click" /><br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="">Already have an Account? <a href="login.aspx">Click Here</a></asp:Label>
                    </form>
                 </div>
              </div>
         </div>
    </form>
</body>
</html>
