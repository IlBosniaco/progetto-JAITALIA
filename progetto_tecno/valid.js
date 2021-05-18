/*function vai(){
	var mail=document.getElementById("email").value;
	alert(mail);
	$.ajax({
		type: "GET",
		url: "data.csv",
		dataType: "text",
		cache: false,
		success: function(data) {
			alert("ok");
		}
		
	});
}*/



$(document).ready(function () {
	$('btnAccedi').click(function(){
		$.ajax({
			url: "data.csv",
			dataType: "text",
			success: function (data) {				
				var lines = data.split(/\r?\n|\r/);

				var entries = lines[0].split(',');
				
				alert(entries);
			}
		});
	});

});
