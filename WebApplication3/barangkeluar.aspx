<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="barangkeluar.aspx.cs" Inherits="WebApplication3.barangkeluar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8">
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
			<div class="r-menu1">
				<div class="h1">
					<h1>Transaksi</h1>
				</div>
				<div class="content">
					<div class="form">
						<h2>Barang Keluar</h2>
                        <label class="label">Kode</label><br>
                        <asp:TextBox class="input2" ID="kode_klr" runat="server"></asp:TextBox>
                        <asp:Button class="button2" ID="Button1" runat="server" Text="Cari" OnClick="Button1_Click"/><br />
                        <asp:Label ID="Label1" Visible="false" runat="server" Text="Nama : "></asp:Label><asp:Label ID="nama_lbl" runat="server" Text=""></asp:Label><br />
                        <asp:Label ID="Label2" Visible="false" runat="server" Text="Kategori : "></asp:Label><asp:Label ID="kategori_lbl" runat="server" Text=""></asp:Label> <br />
                        <asp:Label ID="Label3" Visible="false" runat="server" Text="Stok : "></asp:Label><asp:Label ID="stok_lbl" runat="server" Text=""></asp:Label><br />
                        <asp:Label ID="Label4" Visible="false" runat="server" Text="Harga : "></asp:Label><asp:Label ID="harga_lbl" runat="server" Text=""></asp:Label><br /><br />
                        <asp:Label ID="jml_lbl" Visible="false" runat="server" Text="Jumlah Barang Keluar"></asp:Label>
                        <br>
                        <asp:TextBox Visible="false" class="input2" ID="jml_klr" runat="server"></asp:TextBox><br>
                        <asp:Button Visible="false" ID="Button3" class="button2" runat="server" Text="Proses" OnClick="Button3_Click" />

					</div>
				</div>	
		    </div>
		</div>
    </form>
</body>
</html>
