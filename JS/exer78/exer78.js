function substituirEspacos() {
    var frase = document.getElementById('frase').value;
    var res = document.getElementById('res');

    var novaFrase = frase.replace(/ /g, '#');

    res.innerText = novaFrase;
}
