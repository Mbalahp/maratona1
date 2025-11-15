var palavras = [];

function addPalavra() {
    var palavra = document.getElementById('palavra').value;
    var res = document.getElementById('res');

    palavras.push(palavra);

    if (palavra.toLowerCase().startsWith('f')) {
        processar();
        return;
    }
    document.getElementById('palavra').value = '';
}

function processar() {
    var r = '';
    for (var i = 0; i < palavras.length; i++) {
        var p = palavras[i];
        if (p.length > 0) {
            r += p + ': ' + p[0] + '-' + p[p.length - 1] + '<br>';
        }
    }
    res.innerHTML = r;
    palavras = []; // Clear data after processing
}
