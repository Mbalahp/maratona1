function repetir() {
    var frase = document.getElementById('frase').value;
    var res = document.getElementById('res');
    var palavras = frase.split(' ');
    var novaFrase = '';

    for (var i = 0; i < palavras.length; i++) {
        novaFrase += palavras[i] + ' ' + palavras[i] + ' ';
    }

    res.innerText = novaFrase.trim();
}
