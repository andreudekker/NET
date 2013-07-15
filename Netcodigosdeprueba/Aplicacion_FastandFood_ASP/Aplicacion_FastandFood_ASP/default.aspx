<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Aplicacion_FastandFood_ASP._default" %>

<!doctype html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
	<title>Ring&Food</title>
	
	<link rel="stylesheet" href="normalize.css">
	<link rel="stylesheet" href="css/grid.css">
	<link rel="stylesheet" href="css/estilo.css">
	<link rel="stylesheet" href="css/style.css" />
	 
	

</head>
<body>
	
<header>
	<!--container-->
	<div class="container_12">
	<!-- grid1/logo-->	
     		<div class="grid_7"><img src="imagenes/logoRing&Food.png" alt="logoRing&food" id="logoFood"></div>
		<div class="grid_3">
			<nav> <!--navegacion-->
			        <div id="container">
			            <!-- Login Starts Here -->
			            <div id="loginContainer">
			                <a href="#" id="loginButton"><span>Inicio</span><em></em></a>
			                <div style="clear:both"></div>
			                <div id="loginBox">                
			                    <form id="loginForm" runat="server">
			                        <fieldset id="body">
			                            <fieldset>
			                                <label for="email">CorreoElectronico</label>
                                            <asp:TextBox ID="txtCorreoElectronico" runat="server" ></asp:TextBox>			
			                            </fieldset>
			                            <fieldset>
			                                <label for="password">Contraseña</label>
			                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox>			                    
			                            </fieldset>
                                        <asp:Button ID="login" runat="server" Text="Ingresar" />
                                                              	 
			                        </fieldset>
                                   
                                    <span> <asp:HyperLink ID="HyperLink1" runat="server">Registrate</asp:HyperLink></span>
			                       	 <span><asp:HyperLink ID="HyperLink2" runat="server">Olvido su clave</asp:HyperLink></span>
			                   
			                    </form>
			                </div>
			            </div>
			            <!-- Login Ends Here -->
				</div>
	 		</nav>
		</div>
		
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FastFoodConnectionString %>" SelectCommand="SP_consultaRegistro" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtCorreoElectronico" Name="correo" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="txtPassword" Name="clave" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
		
</header>  <!--fin header-->
	
<div id="centro">
	<div class="container_12">
		<div class="grid_12" id="imagenHamburguer">
			<img src="imagenes/hamburguerInicio.png" alt="hamburguerRong&food">
		</div>
	</div>
</div>	<!--centro-->

<footer>
	<div class="container_12">
		<div class="grid_4"  ><p class="Fuenteespecial"  id="fuenteSistema">Sistema creado por Andres Bernal</p></div>
		<div class="grid_4" ><p class="Fuenteespecial" id="fuenteContacto"> Contacto: @andreudekker</p></div>
		<div class="grid_4" ><p class="Fuenteespecial" id="fuenteDerechos"> Todos lo derechos reservados 2013</p></div>
         </div>
</footer>
<!--js-->
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js?ver=1.4.2"></script>
<script src="js/login.js"></script>	
</body>
</html>