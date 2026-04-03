<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP2_GRUPO_8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 110px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 317px;
        }
        .auto-style4 {
            width: 317px;
            height: 37px;
        }
        .auto-style5 {
            height: 37px;
        }
    </style>
</head>
<body style="height: 143px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbProducto1" runat="server" Text="Ingrese el nombre del producto:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtProd1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="lblCantidad1" runat="server" Text="Cantidad:"></asp:Label>
                    <asp:TextBox ID="txtCantidad1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lbProducto2" runat="server" Text="Ingrese el nombre del producto:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtProd2" runat="server" style="margin-left: 1px" Width="163px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblCantidad2" runat="server" Text="Cantidad:"></asp:Label>
                    <asp:TextBox ID="txtCantidad2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
                <td class="auto-style5">
                    </td>
                <td class="auto-style5">
                    </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" style="font-weight: 700" Text="Generar Tabla " Width="140px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblTabla" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
