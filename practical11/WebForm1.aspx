﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical11.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    You can enable and disable this textbox:
            <asp:TextBox ID="txtEnableDisable" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnEnableDisable" runat="server" OnClick="btnEnableDisable_Click" Text="Enable/Disable" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="117px"></asp:TextBox>
            <asp:Button ID="btnChangeWidth" runat="server" OnClick="btnChangeWidth_Click" Text="Change Width" />
    </div>
    </form>
</body>
</html>
