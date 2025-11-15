function contarEspacos() {
    var frase = document.getElementById('frase').value;
    var res = document.getElementById('res');
    var count = 0;

    for (var i = 0; i < frase.length; i++) {
        if (frase[i] == ' ') {
            count++;
        }
    }

    res.innerText = 'Número de espaços em branco: ' + count;
}
