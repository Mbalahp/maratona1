function calcular() {
    var n = parseInt(document.getElementById('n').value);
    var res = document.getElementById('res');
    var maiorQuadrado = 0;
    var raiz = 0;

    for (var i = 1; i * i <= n; i++) {
        maiorQuadrado = i * i;
        raiz = i;
    }

    res.innerText = 'O maior quadrado menor ou igual a ' + n + ' é ' + maiorQuadrado + ' (quadrado de ' + raiz + ').';
}
