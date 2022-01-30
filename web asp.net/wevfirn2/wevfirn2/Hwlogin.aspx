<%@ Page Title="login " Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Hwlogin.aspx.cs" Inherits="Account_Hwlogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
  <div class="form-group text-Danger bg-success" style="margin-top:120px;margin-left:390px;margin-right:390px;border-radius:15px 50px;border-block-color:crimson crimson crimson crimson;border-style:groove;background-color:lightskyblue">
    
      <h2 class="he text-center">LoginPage </h2>
      <label for="exampleInputEmail1" style="margin-left:50px">Email address</label>
      <asp:TextBox ID="TextBoxEmail" class="form-control"  runat="server" aria-describedby="emailHelp" placeholder="Enter email" style="margin-left:40px"> </asp:TextBox>
    <small id="emailHelp" class="form-text text-muted" style="margin-left:50px">We'll never share your email with anyone else.</small>
  <div class="form-group glyphicon-align-center">
    <label for="exampleInputPassword1"  style="margin-left:40px">Password</label>
            <asp:TextBox ID="TextBoxPassword" class="form-control" runat="server" aria-describedby="emailHelp" placeholder="Password" TextMode="Password" style="margin-left:40px;margin-bottom:10px"> </asp:TextBox>
<asp:Button ID="ButtonSumbitid"  class="btn btn-primary"  runat="server" OnClick="Button1_Click" Text="Sumbit" style="margin-left: 45px" />
             <asp:Label ID="LabelMessage" runat="server" Text="Message" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
   
</div>
        
  </div>

    
       

</asp:Content>
