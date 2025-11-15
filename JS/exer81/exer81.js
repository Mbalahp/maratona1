function calcular() {
    var soma = 0;
    for (var i = 1; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    document.getElementById('res').innerText = 'A soma é: ' + soma;
}
