function duplicar() {
    var frase = document.getElementById('frase').value;
    var res = document.getElementById('res');
    var novaFrase = '';

    for (var i = 0; i < frase.length; i++) {
        novaFrase += frase[i] + frase[i];
    }

    res.innerText = novaFrase;
}
