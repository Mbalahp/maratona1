function calcular() {
    var res = document.getElementById('res');
    var countMult5 = 0;
    var totalNumeros = 10000;

    for (var i = 1; i <= totalNumeros; i++) {
        if (i % 5 == 0) {
            countMult5++;
        }
    }

    var percentMult5 = (countMult5 / totalNumeros) * 100;

    res.innerHTML = 
        'Quantidade de múltiplos de 5: ' + countMult5 + '<br>' +
        'Percentagem de múltiplos de 5: ' + percentMult5.toFixed(2) + '%';
}
