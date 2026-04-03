<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio2a.aspx.cs" Inherits="TP2_GRUPO_8.ejercicio2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 134px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style4 {
            width: 134px;
            height: 33px;
        }
        .auto-style5 {
            width: 346px;
        }
        .auto-style6 {
            height: 33px;
            width: 346px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 59px" Width="200px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
                        <asp:TextBox ID="txtApellido" runat="server" style="margin-left: 52px" Width="200px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="btnVerResumen" runat="server" Font-Size="Small" OnClick="btnVerResumen_Click" Text="Ver resumen" style="margin-left: 201px" />
                    </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
