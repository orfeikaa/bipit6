<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Веб_приложение.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <p style="height: 38px; width: 881px">
                Модель оборудования:
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            </p>
            <p style="height: 38px; width: 881px">
                Вид работы: <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            </p>
            <p style="height: 38px; width: 881px">
                Дата получения: <asp:TextBox ID="dateEx" runat="server" type="date" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BorderStyle="None" ControlToValidate="dateEx" Display="Dynamic" ErrorMessage="Вы не выбрали дату!" ValidationGroup="Growp1">Вы не выбрали дату!
            </asp:RequiredFieldValidator>
            </p>
            <p style="height: 38px; width: 881px">
                Дата выполнения:
                <asp:TextBox ID="dateEx0" runat="server" type="date" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dateEx0" Display="dynamic" ErrorMessage="Вы не выбрали дату!" ValidationGroup="Growp1">Вы не выбрали дату!
            </asp:RequiredFieldValidator>
            </p>
            <p style="height: 38px; width: 881px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" ValidationGroup="Growp1" />
            </p>
        </div>
    </form>
</body>
</html>
