<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="myClass">
        <asp:TextBox ID="txtBoxInput" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Who Rules?" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
