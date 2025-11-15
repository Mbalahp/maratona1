var qtdNumeros = 0;
var cont = 0;
var resultados = [];

function fatorial(num) {
    if (num < 0) return 'Inválido';
    if (num == 0) return 1;
    var fat = 1;
    for (var i = 1; i <= num; i++) {
        fat *= i;
    }
    return fat;
}

function iniciar() {
    qtdNumeros = parseInt(document.getElementById('qtd').value);
    document.getElementById('total').innerText = qtdNumeros;
    document.getElementById('s1').style.display = 'none';
    document.getElementById('s2').style.display = 'block';
}

function addNum() {
    if (cont < qtdNumeros) {
        var num = parseInt(document.getElementById('num').value);
        resultados.push({numero: num, fatorial: fatorial(num)});
        cont++;
        document.getElementById('c').innerText = cont;
        document.getElementById('num').value = '';
        if (cont == qtdNumeros) {
            processar();
        }
    }
}

function processar() {
    var res = document.getElementById('res');
    var tabela = '<table><tr><th>Número</th><th>Fatorial</th></tr>';

    for (var i = 0; i < resultados.length; i++) {
        tabela += '<tr><td>' + resultados[i].numero + '</td><td>' + resultados[i].fatorial + '</td></tr>';
    }
    tabela += '</table>';

    res.innerHTML = tabela;
    resultados = [];
    cont = 0;
}
