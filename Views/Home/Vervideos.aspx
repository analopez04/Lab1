<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ver videos</title>
</head>
<body>
    <a href="Home/Index">Inicio</a>
    <form action="/Vervideos" method="post">
    
    <fieldset>
    <legend > Datos del Video </legend>
        <br />  
    <label for="idVideo">idVideo</label>
    <input type= "text" name= "idVideo" />
        <br />  
     <label for="titulo">titulo </label>
    <input type= "text" name= "Titulo" />
        <br />  
     <label for="reproducciones">reproducciones</label>
    <input type= "text" name= "reproducciones" />
        <br />  
     <label for="url">url</label>
    <input type= "text" name= "url" />
        <br />  
    <input  type="submit" value=" Mostrar video"/>

    </fieldset>
    </form>

</body>
</html>
