function somar() {
    var soma = 0;
    for (var i = 1; i <= 100; i++) {
        soma += i;
    }
    document.getElementById('res').innerText = 'A soma é: ' + soma;
}