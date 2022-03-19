<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        supplier entry page
    </p>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="suppliers" runat="server" Text="Supplier name " width="195px"></asp:Label>
            <asp:TextBox ID="supplierName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="suppliers0" runat="server" Text="Start of supply" width="195px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="suppliers4" runat="server" Text="avilibilty" width="195px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="suppliers2" runat="server" Text="phones supplied" width="195px"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="suppliers3" runat="server" Text="supplier contact number" width="195px"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" Text="active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;<asp:Button ID="btnOK0" runat="server" OnClick="btnOK_Click" Text="OK" />
            &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
        </div>
    </form>
</body>
</html>
