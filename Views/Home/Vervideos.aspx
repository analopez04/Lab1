<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ver videos</title>
</head>
<body>
    <a href="/Home/Index">Inicio</a>
    <form action="/Home/Vervideos" method="post">
    
    <fieldset>
    <legend > Datos del Video </legend>
        <br />      
     <label for="titulo">Titulo </label>
    <input type= "text" name= "Titulo" />
       
    <input  type="submit" value=" Mostrar video"/>

    </fieldset>
    </form>

</body>
</html>
