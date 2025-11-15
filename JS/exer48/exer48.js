function somar() {
    var soma = 0;
    var termo = 3;
    while (termo <= 6561) {
        soma += termo;
        termo *= 3;
    }
    document.getElementById('res').innerText = 'A soma da PG é: ' + soma;
}