function gerarTabuada() {
    var num = document.getElementById('num').value;
    var res = document.getElementById('res');
    var tabuada = '';

    for (var i = 1; i <= 13; i++) {
        tabuada += num + ' x ' + i + ' = ' + (num * i) + '<br>';
    }

    res.innerHTML = tabuada;
}