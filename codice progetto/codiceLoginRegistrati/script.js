function ConfermaPsw()
{
    var psw=document.getElementById("txtpsw").value;
    var confPsw=document.getElementById("txtCpsw").value;
    if (psw!=confPsw) {
       alert("Password diversa, inserire la password uguale");
        document.getElementById("txtpsw").value="";
        document.getElementById("txtCpsw").value="";
        goto(start);
    }
}