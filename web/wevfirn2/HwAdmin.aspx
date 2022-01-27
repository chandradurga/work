
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HwAdmin.aspx.cs" Inherits="Account_HwAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row d-flex justify-content-center" >
<div class ="col-md-5" style="left: 0px; top: 0px"><br />
    <br />
        <br />
        <br />
    <div class="text-danger">
<table class="center
    " style="width: 2153px; margin-right: 157px">
    
            <tr>
                <td style="height: 82px; width: 219px;" aria-selected="false" aria-sort="none">
                                        &nbsp;</td>
                <td style="height: 82px; width: 1861px;" aria-selected="false" aria-sort="none">
                                        <asp:Label ID="Label1" runat="server" Text="Text1"></asp:Label>

                    <asp:TextBox ID="TextBoxDefaultPageTex2"  Class ="form-control" runat ="server" TextMode="MultiLine" Width="1698px" OnTextChanged="TextBoxDefaultPageTex2_TextChanged" style="margin-left: 115px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 115px; width: 219px;" aria-selected="false" aria-sort="none"> 
                     &nbsp;</td>
                <td style="height: 115px" aria-live="off" aria-selected="false" aria-sort="none"> 
                     <asp:Label ID="Label2" runat="server" Text="Text2"></asp:Label>
                     <asp:TextBox ID="TextBoxDefaultPageTex"  Class ="form-control" runat ="server" TextMode="MultiLine" Width="1698px" style="margin-top: 0; margin-left: 118px;" OnTextChanged="TextBoxDefaultPageTex_TextChanged" BackColor="White"></asp:TextBox>
                </td>
            </tr>
    <tr>
                <td style="height: 115px; width: 219px;" aria-selected="false" aria-sort="none"> 
                     &nbsp;</td>
                <td style="height: 115px" aria-live="off" aria-selected="false" aria-sort="none"> 
                     <asp:Label ID="Label3hea" runat="server" Text="Header"></asp:Label>
                     <asp:TextBox ID="TextBox1hea"  Class ="form-control" runat ="server" TextMode="MultiLine" Width="1698px" style="margin-top: 0; margin-left: 118px;" OnTextChanged="TextBox1hea_TextChanged" BackColor="white"></asp:TextBox>
                </td>
            </tr>
    <tr>
                <td style="height: 115px; width: 219px;" aria-selected="false" aria-sort="none"> 
                     &nbsp;</td>
                <td style="height: 115px" aria-live="off" aria-selected="false" aria-sort="none"> 
                     <asp:Label ID="Label3foo" runat="server" Text="footer"></asp:Label>
                     <asp:TextBox ID="TextBox1foot"  Class ="form-control" runat ="server" TextMode="MultiLine" Width="1698px" style="margin-top: 0; margin-left: 118px;" OnTextChanged="TextBox1foot_TextChanged" BackColor="White"></asp:TextBox>
                </td>
            </tr>

            </table>
    </div>

</div>
</div>
     <div class="row">

<div class ="col">


 </div>
</div>

         <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" Width="94px" />
    

    
    
    


    
</asp:Content>

