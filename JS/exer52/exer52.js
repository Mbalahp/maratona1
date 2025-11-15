function dividir() {
    var num = parseFloat(document.getElementById('num').value);
    var res = document.getElementById('res');
    var contDiv = 0;
    var ultimoRes = num;

    while (ultimoRes >= 1) {
        ultimoRes /= 2;
        contDiv++;
    }

    res.innerHTML = 
        'Último resultado: ' + ultimoRes.toFixed(4) + '<br>' +
        'Quantidade de divisões: ' + contDiv;
}
