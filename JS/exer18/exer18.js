function gerarTabuada() {
    var num = document.getElementById('num').value;
    var inicio = document.getElementById('inicio').value;
    var fim = document.getElementById('fim').value;
    var res = document.getElementById('res');
    var tabuada = '';

    if (parseInt(fim) < parseInt(inicio)) {
        res.innerText = 'O valor final não pode ser menor que o inicial.';
        return;
    }

    for (var i = inicio; i <= fim; i++) {
        tabuada += num + ' x ' + i + ' = ' + (num * i) + '<br>';
    }

    res.innerHTML = tabuada;
}