<%@ Page Title="login " Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Hwlogin.aspx.cs" Inherits="Account_Hwlogin" %>

<asp:Content ID="Content1"  ContentPlaceHolderID="MainContent" Runat="Server">
  <div class="text-success">
    <label for="exampleInputEmail1 ">Email address</label>
      <asp:TextBox ID="TextBoxEmail" class="form-control"  runat="server" aria-describedby="emailHelp" placeholder="Enter email" style="margin-left: 62px"> </asp:TextBox>
    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
  <div class="form-group">
    <label for="exampleInputPassword1">Password</label>
            <asp:TextBox ID="TextBoxPassword" class="form-control" runat="server" aria-describedby="emailHelp" placeholder="Password" TextMode="Password" style="margin-left: 60px"> </asp:TextBox>
</div>
  </div>

    <asp:Button ID="ButtonSumbitid"  class="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Sumbit" />
             <asp:Label ID="LabelMessage" runat="server" Text="Message" Font-Size="Large" ForeColor="#CC0000"></asp:Label>

</asp:Content>

