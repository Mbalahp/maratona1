function acharPrimos() {
    var n = document.getElementById('n').value;
    var res = document.getElementById('res');
    var divCont = document.getElementById('divs');
    var primos = [];
    var divisoes = 0;

    for (var i = 2; i <= n; i++) {
        var ehPrimo = true;
        for (var j = 2; j < i; j++) {
            divisoes++;
            if (i % j == 0) {
                ehPrimo = false;
                break;
            }
        }
        if (ehPrimo) {
            primos.push(i);
        }
    }

    res.innerText = 'Primos: ' + primos.join(', ');
    divCont.innerText = 'Número de divisões: ' + divisoes;
}