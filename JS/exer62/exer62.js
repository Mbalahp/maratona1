function calcular() {
    var produto = 1;
    for (var i = 1; i <= 15; i += 2) {
        produto *= i;
    }
    document.getElementById('res').innerText = 'O produto dos ímpares de 1 a 15 é: ' + produto;
}
