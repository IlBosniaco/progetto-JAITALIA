$(document).ready(function () {
    $('#btnAccedi').click(function(){
		$.ajax({
			type: "GET",
			url: "data.txt",
			dataType: "text",
			success: function (data) {		
				var lines = data.split('\n');
				var mail=document.getElementById("txtmail").value;
				var password=document.getElementById("txtpsw").value;
				alert(mail+""+password);
				var trovato=false;
				for(var i=0;i< lines.length;i++)
				{					
					var entries = lines[i].split(',');
					if(mail==entries[0]&&password==entries[1])
						trovato=true;
				}
				
				
				if(trovato)
				{
					alert("corretto");
                    window.location.href = "http://portamatteo.altervista.org/progettoTecno/ordinazioni/index.html";
				}
				else{
					alert("credenziali errate, riprovare");
				}
			}			
		});
	});
});

/*
    $('#btnRegistrati').click(function(){
		$.ajax({
			type: "GET",
			url: "data.txt",
			dataType: "text",
			success: function (data) {		
				var lines = data.split('\n');
				var mail=document.getElementById("email").value;
				var password=document.getElementById("pssw").value;
				alert(mail+""+password);
				var trovato=false;
				for(var i=0;i< lines.length;i++)
				{					
					var entries = lines[i].split(',');
					if(mail==entries[0]&&password==entries[1])
						trovato=true;
				}
				
				
				if(trovato)
				{
					alert("mondo meticcio");
				}
				else{
					alert("tra africa e brasile");
				}
			}			
		});
	});
*/