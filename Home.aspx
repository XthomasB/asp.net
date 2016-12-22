<%@ Page Title="Home" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content id="head" ContentPlaceHolderID="head" runat="server">



</asp:Content> 

<asp:Content ID="Home" ContentPlaceHolderID ="ContentPlaceHolder1" runat="server">
  <div class="w3-content w3-section" style="max-width:400px">
  <img class="mySlides" src="Assets/slider1.jpg" style="width:90%"/>
  <img class="mySlides" src="Assets/slider2.jpg" style="width:90%"/>
  <img class="mySlides" src="Assets/slider3.jpg" style="width:90%"/>
    <img class="mySlides" src="Assets/slider4.jpg" style="width:90%"/>
    <img class="mySlides" src="Assets/slider5.jpg" style="width:90%"/>
    </div>
    <br />
    <br />

   <div class="w3-container">
  <h2>Slideshow Indicators</h2>
  </div>


<style>
.mySlides {display:none;}

.mySlides img{ height: 500px !important;}
</style>

<script>
    var slideIndex = 0;
    carousel();

    function carousel() {
        var i;
        var x = document.getElementsByClassName("mySlides");
        for (i = 0; i < x.length; i++) {
            x[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > x.length) { slideIndex = 1 }
        x[slideIndex - 1].style.display = "block";
        setTimeout(carousel, 2000); // Change image every 2 seconds
    }
</script>
    
</asp:Content>