function gerarTabela() {
    var res = document.getElementById('res');
    var tabela = '<table><tr><th>Número</th><th>Quadrado</th><th>Cubo</th></tr>';

    for (var i = 0; i <= 10; i++) {
        var quadrado = i * i;
        var cubo = i * i * i;
        tabela += '<tr><td>' + i + '</td><td>' + quadrado + '</td><td>' + cubo + '</td></tr>';
    }
    tabela += '</table>';

    res.innerHTML = tabela;
}
