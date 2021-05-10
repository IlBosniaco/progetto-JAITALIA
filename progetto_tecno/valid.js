	//Validtion Code For Inputs

var email = document.forms['form']['email'];
var password = document.forms['form']['password'];

var email_error = document.getElementById('email_error');
var pass_error = document.getElementById('pass_error');

email.addEventListener('textInput', email_Verify);
password.addEventListener('textInput', pass_Verify);

function validated(){
	if (email.value.length < 9) {
		email.style.border = "1px solid red";
		email_error.style.display = "block";
		email.focus();
		return false;
	}
	if (password.value.length < 6) {
		password.style.border = "1px solid red";
		pass_error.style.display = "block";
		password.focus();
		return false;
	}

}
function email_Verify(){
	if (email.value.length >= 8) {
		email.style.border = "1px solid silver";
		email_error.style.display = "none";
		return true;
	}
}
function pass_Verify(){
	if (password.value.length >= 5) {
		password.style.border = "1px solid silver";
		pass_error.style.display = "none";
		return true;
	}
}

/*$(document).ready(function controllo() {
    $.ajax({
        type: "GET",
        url: "data.txt",
        dataType: "text",
        success: function(data) {processData(data);}
     });
});*/

function processData(allText) {
	
	//1 campo-->email
	//2 campo-->password
    //3 campo-->nome
    //4 campo-->cognome
    var linee = allText.split(/\r\n|\n/);
	var controllo =false;
	var emailinserita=document.getElementById("email").value;
	var passwordinserita=document.getElementById("password").value;
	for(var i=0; i<linee.length&&!controllo;i++)
	{
		var campo = linee[i].split(';');
		var email=campo[0];
		var password=campo[1];
		if(emailinserita==email&&passwordinserita==password)
		{
			controllo=true;
		}		
	}
	
	if(controllo)
	{
		alert("valido");
	}
	else{
		alert("non valido");
	}
	
    
}
