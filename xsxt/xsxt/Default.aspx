<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="xsxt.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        * {
            margin: 0;
            border: 0;
            padding: 0;
        }

        #meu {
            margin: 0 auto;
            background-color: #f5f5f5;
            width: 100%;
            height: 40px;
            line-height: 40px;
        }

        #ul-left {
            margin: auto;
            width: 1250px;
            list-style: none;
        }

            #ul-left li {
                margin-right: 30px;
                float: left;
            }

        #ul-right {
            margin: auto;
            width: 1250px;
            list-style: none;
        }

            #ul-right li {
                margin-left: 30px;
                float: right;
            }

        #search {
            margin: auto;
            background-color: aqua;
            width: 1250px;
            height: 900px;
        }

        #Label8 {
            line-height: 100px;
            text-align: center;
        }

        #TextBox1 {
            margin-top: 26px;
            position: absolute;
        }

        #Button1 {
            margin-top: 26px;
            margin-left:704px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="meu">
                <div id="meu-left">
                    <ul id="ul-left">
                        <li>
                            <asp:Label ID="Label1" runat="server" Text="亲，请登录" ForeColor="#FF3300"></asp:Label></li>
                        <li>
                            <asp:Label ID="Label2" runat="server" Text="免费注册"></asp:Label></li>
                    </ul>
                </div>
                <div id="meu-right">
                    <ul id="ul-right">
                        <li>
                            <asp:Label ID="Label7" runat="server" Text="网站导航"></asp:Label></li>
                        <li>
                            <asp:Label ID="Label6" runat="server" Text="商品分类"></asp:Label></li>
                        <li>
                            <asp:Label ID="Label5" runat="server" Text="购物车" ForeColor="#FF3300"></asp:Label></li>
                        <li>
                            <asp:Label ID="Label4" runat="server" Text="个人信息"></asp:Label></li>
                        <li>
                            <asp:Label ID="Label3" runat="server" Text="首页"></asp:Label></li>
                    </ul>
                </div>
            </div>
            <div id="search">
                <asp:Label ID="Label8" runat="server" Text="零食热卖" Width="22%" Height="100px" Font-Size="32" ForeColor="#FF3300"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="700px" Height="40px" BorderWidth="2" BorderColor="#FF3300"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="搜索" Width="80px" Height="44px" BackColor="#FF3300" ForeColor="White" Font-Size="Large" />
            </div>
        </div>
    </form>
</body>
</html>
