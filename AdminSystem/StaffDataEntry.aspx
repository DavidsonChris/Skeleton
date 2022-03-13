<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaff_id" runat="server" Text="Staff Identity" width="327px"></asp:Label>
        <asp:TextBox ID="intStaff_id" runat="server" width="368px"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaff_fullname" runat="server" Text="Staff Fullname" width="327px"></asp:Label>
            <asp:TextBox ID="txtStaff_fullname" runat="server" width="368px"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaff_department" runat="server" Text="Staff Department" width="246px"></asp:Label>
        <asp:TextBox ID="txtStaff_department" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaff_DOB" runat="server" Text="Staff DOB" width="327px"></asp:Label>
            <asp:TextBox ID="txtStaff_DOB" runat="server" width="368px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmail_Address" runat="server" Text="Email Address" width="327px"></asp:Label>
            <asp:TextBox ID="txtEmail_Address" runat="server" width="368px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkAvailability" runat="server" Text="Availability" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
