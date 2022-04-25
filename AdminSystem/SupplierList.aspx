<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstSupplierList" runat="server" Height="326px" Width="381px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="ADD" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="EDIT" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="DELETE" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter a Phone model"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="LblError"></asp:Label>
        </div>
    </form>
</body>
</html>
