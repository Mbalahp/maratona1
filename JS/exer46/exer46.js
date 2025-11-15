function somar() {
    var soma = 0;
    var x = 1;
    do {
        soma += x;
        x++;
    } while (x < 11);
    
    document.getElementById('res').innerText = 'A soma é: ' + soma;
}