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
            <asp:Label ID="suppliersID" runat="server" Text="Supplier ID " width="195px"></asp:Label>
            <asp:TextBox ID="Supplier_ID" runat="server" style="position: relative; top: 0px; left: 0px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_click" Text="find" Height="35px" Width="63px" />
            <br />
            <asp:Label ID="suppliers" runat="server" Text="Supplier name " width="195px"></asp:Label>
            <asp:TextBox ID="supplierName" runat="server" style="position: relative; top: 0px; left: 0px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="suppliers0" runat="server" Text="Start of supply" width="195px"></asp:Label>
            <asp:TextBox ID="Supplier_date" runat="server" style="position: relative"></asp:TextBox>
            <br />
            <asp:Label ID="suppliers4" runat="server" Text="avilibilty" width="195px"></asp:Label>
            <asp:TextBox ID="Supplier_availibilty" runat="server" style="position: relative"></asp:TextBox>
            <br />
            <asp:Label ID="suppliers2" runat="server" Text="phones supplied" width="195px"></asp:Label>
            <asp:TextBox ID="Supplier_phones" runat="server" style="position: relative"></asp:TextBox>
            <br />
            <asp:Label ID="suppliers3" runat="server" Text="supplier contact details" width="195px"></asp:Label>
            <asp:TextBox ID="Supplier_contact" runat="server" style="position: relative"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" Text="active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;<asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
        </div>
    </form>
</body>
</html>
