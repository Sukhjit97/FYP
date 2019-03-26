<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true" CodeFile="viewcatalogue.aspx.cs" Inherits="User_viewcatalogue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
    div.gallery {
  margin: 5px;
  border: 1px solid #ccc;
  float: left;
  width: 180px;
        height: 273px;
    }

div.gallery:hover {
  border: 1px solid #777;
}

div.gallery img {
  width: 100%;
  height: auto;
}

div.desc {
  padding: 15px;
  text-align: center;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="gallery">
  <a target="_blank" href="img_5terre.jpg">
    <img src="website-Logo.png" alt="Cinque Terre" width="600" height="400">
  </a>
  <div class="desc">Add a description of the image here</div>
</div>

<div class="gallery">
  <a target="_blank" href="img_forest.jpg">
    <img src="Wool.jpg" " alt="Forest" width="600" height="400"/>
  </a>
  <div class="desc">Add a description of the image here</div>
</div>

<div class="gallery">
  <a target="_blank" href="img_lights.jpg">
    <img src="img_lights.jpg" alt="Northern Lights" width="600" height="400">
  </a>
  <div class="desc">Add a description of the image here</div>
</div>

<div class="gallery">
  <a target="_blank" href="img_mountains.jpg">
    <img src="img_mountains.jpg" alt="Mountains" width="600" height="400">
  </a>
  <div class="desc">Add a description of the image here</div>
</div>
</asp:Content>

