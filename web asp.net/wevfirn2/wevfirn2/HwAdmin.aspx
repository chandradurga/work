
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HwAdmin.aspx.cs" Inherits="Account_HwAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
  
    <div class="form-group text-Danger bg-success text" style="margin-top:60px;margin-left:390px; margin-right:250px;border-radius:10px 50px;border-block-color:crimson crimson crimson crimson;border-style:groove;background-color:lightskyblue">
                                         <h2 class="he text-center">LoginPage </h2>

        <asp:Label ID="Label1" runat="server" Text="Text1"></asp:Label>
                    <asp:TextBox ID="TextBoxDefaultPageTex2"  Class ="form-control" runat ="server" TextMode="MultiLine" Width="1469px" OnTextChanged="TextBoxDefaultPageTex2_TextChanged" style="margin-left: 115px; margin-top: 0;"></asp:TextBox>
               
                     <asp:Label ID="Label2" runat="server" Text="Text2"></asp:Label>
                     <asp:TextBox ID="TextBoxDefaultPageTex"  Class ="form-control" runat ="server" TextMode="MultiLine" Width="1462px" style="margin-top: 0; margin-left: 118px;" OnTextChanged="TextBoxDefaultPageTex_TextChanged" BackColor="White"></asp:TextBox>
               
                     <asp:Label ID="Label3hea" runat="server" Text="Header"></asp:Label>
                     <asp:TextBox ID="TextBox1hea"  Class ="form-control" runat ="server" TextMode="MultiLine" Width="1463px" style="margin-top: 0; margin-left: 118px;" OnTextChanged="TextBox1hea_TextChanged" BackColor="white"></asp:TextBox>
              
                     <asp:Label ID="Label3foo" runat="server" Text="footer"></asp:Label>
                     <asp:TextBox ID="TextBox1foot"  Class ="form-control" runat ="server" TextMode="MultiLine" Width="1468px" style="margin-top: 0; margin-left: 118px; margin-bottom:10px" OnTextChanged="TextBox1foot_TextChanged" BackColor="White"></asp:TextBox>
                <asp:Button ID="ButtonSave" runat="server" Text="Save" class="btn btn-primary"  OnClick="ButtonSave_Click" Width="120px"  style="margin-left: 180px" />

        </div>
    

    

    
    
    


    
</asp:Content>

