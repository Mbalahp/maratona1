function analisar() {
    var str = document.getElementById('str').value;
    var res = document.getElementById('res');
    var r = '';

    // a
    r += 'Número de caracteres: ' + str.length + '<br>';

    // b
    r += 'Maiúsculas: ' + str.toUpperCase() + '<br>';

    // c
    var vogais = 'aeiouAEIOU';
    var numVogais = 0;
    for (var i = 0; i < str.length; i++) {
        if (vogais.indexOf(str[i]) != -1) {
            numVogais++;
        }
    }
    r += 'Número de vogais: ' + numVogais + '<br>';

    // d
    if (str.substring(0, 3).toUpperCase() == 'UNI') {
        r += 'Começa com "UNI".<br>';
    } else {
        r += 'Não começa com "UNI".<br>';
    }

    // e
    if (str.substring(str.length - 3).toUpperCase() == 'RIO') {
        r += 'Termina com "RIO".<br>';
    } else {
        r += 'Não termina com "RIO".<br>';
    }

    // f
    var numDigitos = 0;
    var digitos = '0123456789';
    for (var i = 0; i < str.length; i++) {
        if (digitos.indexOf(str[i]) != -1) {
            numDigitos++;
        }
    }
    r += 'Número de dígitos: ' + numDigitos + '<br>';

    // g
    var reverso = str.split('').reverse().join('');
    if (str.toLowerCase().split(' ').join('') == reverso.toLowerCase().split(' ').join('')) {
        r += 'É um palíndromo.<br>';
    } else {
        r += 'Não é um palíndromo.<br>';
    }

    res.innerHTML = r;
}