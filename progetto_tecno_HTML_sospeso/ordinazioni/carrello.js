var lista = [
    {
        nome: "panzerotto", quantita: 0, costo: 2
    },
    {
        nome: "pizza", quantita: 0, costo: 1
    },
    {
        nome: "panzerotto1_5", quantita: 0, costo: 1.5
    },
    {
        nome: "piadina", quantita: 0, costo: 1.5
    },
    {
        nome: "panino", quantita: 0, costo: 2
    },
    {
        nome: "patatine", quantita: 0, costo: 1
    },
    {
        nome: "acqua naturale", quantita: 0, costo: 0.8
    },
    {
        nome: "acqua naturale", quantita: 0, costo: 0.8
    },
    {
        nome: "acqua frizzante", quantita: 0, costo: 0.8
    },
    {
        nome: "acqua naturale", quantita: 0, costo: 1
    }
]

var spesa="";
var costo=0;
function aggiungiPanzerotto() {
    var nEl = document.getElementById("idPanzerotto").value;
    lista[0].quantita = nEl;
    costo=costo+ lista[0].costo*lista[0].quantita;
    alert(costo);
    //alert(lista[0].quantita);
}
function aggiungiPizza() {
    var nEl = document.getElementById("idPizza").value;
    lista[1].quantita = nEl;
    costo+=lista[1].costo*lista[1].quantita;
    //alert(lista[1].quantita);
    alert(costo);
}
function aggiungiPanzerottojr() {
    var nEl = document.getElementById("idPanzerottojr").value;
    lista[2].quantita = nEl;
    costo+=lista[2].costo*lista[2].quantita;
    //alert(lista[2].quantita);
}
function aggiungiPiadina() {
    var nEl = document.getElementById("idPiadina").value;
    lista[3].quantita = nEl;
    costo+=lista[3].costo*lista[3].quantita;
    //(lista[3].quantita);
}
function aggiungiPanino() {
    var nEl = document.getElementById("idPanino").value;
    lista[4].quantita = nEl;
    costo+=lista[4].costo*lista[4].quantita;
    //alert(lista[4].quantita);
}

function aggiungiPatatine() {
    var nEl = document.getElementById("idPatatine").value;
    lista[5].quantita = nEl;
    costo+=lista[5].costo*lista[5].quantita;
    //alert(lista[5].quantita);
}
function aggiungiAcquaN() {
    var nEl = document.getElementById("idAcquaN").value;
    lista[6].quantita = nEl;
    costo+=lista[6].costo*lista[6].quantita;
    //alert(lista[6].quantita);
}

function aggiungiAcquaF() {
    var nEl = document.getElementById("idAcquaF").value;
    lista[7].quantita = nEl;
    costo+=lista[7].costo*lista[7].quantita;
    //alert(lista[7].quantita);
}
function aggiungiCola() {
    var nEl = document.getElementById("idCola").value;
    lista[8].quantita = nEl;
    costo+=lista[8].costo*lista[8].quantita;
    //alert(lista[8].quantita);
}
