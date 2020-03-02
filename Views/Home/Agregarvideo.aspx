<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Agregarvideo</title>
</head>
<body>
    <a href="Home/Index">Inicio</a>
    <form action="/Home/Agregarvideo" method="post">
    <fieldset>
    <legend > Agregar Video </legend>
        <br />  
    <label for="idVideo">Id Video</label>
    <input type= "text" name= "idVideo" />
        <br />  
     <label for="titulo">Titulo </label>
    <input type= "text" name= "Titulo" />
        <br />  
     <label for="numReproducciones">Num. Reproducciones</label>
    <input type= "text" name= "reproducciones" />
        <br />  
     <label for="url">URL</label>
    <input type= "text" name= "url" />
        <br />  
    <input  type="submit" value=" Agregar"/>

    </fieldset>
    </form>
</body>
</html>
