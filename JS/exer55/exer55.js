function gerarPA() {
    var n = parseInt(document.getElementById('n').value);
    var a1 = parseInt(document.getElementById('a1').value);
    var r = parseInt(document.getElementById('r').value);
    var res = document.getElementById('res');
    var termos = [];
    var soma = 0;

    for (var i = 0; i < n; i++) {
        var termoAtual = a1 + i * r;
        termos.push(termoAtual);
        soma += termoAtual;
    }

    res.innerHTML = 
        'Termos da PA: ' + termos.join(', ') + '<br>' +
        'Soma dos termos: ' + soma;
}
