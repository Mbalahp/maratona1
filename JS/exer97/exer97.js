function somar() {
    var numerosStr = document.getElementById('numeros').value;
    var res = document.getElementById('res');
    var numerosArr = numerosStr.split(',');
    var soma = 0;

    if (numerosArr.length != 15) {
        res.innerText = 'Por favor, digite exatamente 15 números.';
        return;
    }

    for (var i = 0; i < numerosArr.length; i++) {
        soma += parseInt(numerosArr[i].trim());
    }

    res.innerText = 'A soma dos números é: ' + soma;
}
