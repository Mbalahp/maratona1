function somarSemOperador() {
    var n1 = parseInt(document.getElementById('n1').value);
    var n2 = parseInt(document.getElementById('n2').value);
    var res = document.getElementById('res');

    // Soma sem operador de soma
    var soma = n1;
    for (var i = 0; i < Math.abs(n2); i++) {
        if (n2 > 0) {
            soma++;
        } else {
            soma--;
        }
    }

    var parOuImpar = (soma % 2 == 0) ? 'par' : 'ímpar';

    res.innerText = 'A soma é: ' + soma + ' e é ' + parOuImpar + '.';
}
