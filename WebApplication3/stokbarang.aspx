<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stokbarang.aspx.cs" Inherits="WebApplication3.stokbarang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.3.1.js"></script> 
    <script src="jquery.js"></script>
    <link rel="stylesheet" type="text/css" href="index1.css">
</head>
<body>
    <form id="form1" runat="server" class="body">
        <div class="l-body">
			<div class="menu">
				<ul>
					<li class="menu1">Transaksi</li>
                    <a href="index.aspx"><li class="hide hide1">-- Barang Masuk</li></a>
					<a href="barangkeluar.aspx"><li class="hide hide2">-- Barang Keluar</li></a>
					<a href="stokbarang.aspx"><li class="menu2">Stok Barang</li></a>
					<a href="laporan.aspx"><li class="menu3">Laporan</li></a>
					<a href="logout.aspx"><li class="menu4">LogOut</li></a>
				</ul>
			</div>
		</div>
		<div class="r-body">
			<div class="r-menu3">
				<div class="h1">
					<h1>Stok Barang</h1>
				</div>
				<div class="content">
					<div class="form">
                            <asp:Label ID="Label1" runat="server" Text="Urut Berdasarkan "></asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>Nama (ASC)</asp:ListItem>
                                <asp:ListItem>Nama (DESC)</asp:ListItem>
                                <asp:ListItem>Stok (ASC)</asp:ListItem>
                                <asp:ListItem>Stok (DESC)</asp:ListItem>
                                <asp:ListItem>Harga (ASC)</asp:ListItem>
                                <asp:ListItem>Harga (DESC)</asp:ListItem>
                                <asp:ListItem>Kode (ASC)</asp:ListItem>
                                <asp:ListItem>Kode (DESC)</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button ID="Button1" class="button2" runat="server" Text="Urut" OnClick="Button1_Click" /><br />
                        <br />
                        <asp:GridView class="" ID="GridView1" runat="server" Width="1109px"></asp:GridView>
						</div>
					</div>
				</div>
			</div>
		</div>
    </form>
</body>
</html>
