function processar() {
    var pares = [];
    var soma = 0;
    for (var i = 84; i >= 32; i -= 2) {
        pares.push(i);
        soma += i;
    }
    document.getElementById('res').innerHTML = 'Pares: ' + pares.join(', ') + '<br>Soma: ' + soma;
}