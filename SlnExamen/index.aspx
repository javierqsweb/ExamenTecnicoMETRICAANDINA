<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SlnExamen.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtCadena" runat="server"></asp:TextBox>
        <asp:Button ID="btnDevolverCadena" runat="server" OnClick="btnDevolverCadena_Click" Text="Devolver cadena" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Resultado : "></asp:Label>
&nbsp;<asp:Label ID="lblResultado" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
