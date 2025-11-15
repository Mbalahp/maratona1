function buscarPalavra() {
    var frase = document.getElementById('frase').value;
    var palavra = document.getElementById('palavra').value;
    var res = document.getElementById('res');

    var indice = frase.indexOf(palavra);

    if (indice != -1) {
        res.innerText = 'A palavra "' + palavra + '" foi encontrada na posição: ' + indice;
    } else {
        res.innerText = 'A palavra "' + palavra + '" não foi encontrada na frase.';
    }
}
