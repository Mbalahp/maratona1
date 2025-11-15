function multiplicar() {
    var n1 = parseInt(document.getElementById('n1').value);
    var n2 = parseInt(document.getElementById('n2').value);
    var res = document.getElementById('res');
    var resultado = 0;

    for (var i = 0; i < n2; i++) {
        resultado += n1;
    }

    res.innerText = 'Resultado: ' + resultado;
}