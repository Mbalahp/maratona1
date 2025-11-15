var funcs = [];
var qtdFuncs = 0;
var cont = 0;

function iniciar() {
    qtdFuncs = parseInt(document.getElementById('qtd').value);
    document.getElementById('total').innerText = qtdFuncs;
    document.getElementById('s1').style.display = 'none';
    document.getElementById('s2').style.display = 'block';
}

function add() {
    if (cont < qtdFuncs) {
        var nome = document.getElementById('nome').value;
        var sal = parseFloat(document.getElementById('sal').value);
        funcs.push({nome: nome, sal: sal});
        cont++;
        document.getElementById('c').innerText = cont;
        document.getElementById('nome').value = '';
        document.getElementById('sal').value = '';
        if (cont == qtdFuncs) {
            processar();
        }
    }
}

function processar() {
    var somaSal = 0;
    var maiorSal = funcs[0].sal;
    var menorSal = funcs[0].sal;

    for (var i = 0; i < funcs.length; i++) {
        somaSal += funcs[i].sal;
        if (funcs[i].sal > maiorSal) {
            maiorSal = funcs[i].sal;
        }
        if (funcs[i].sal < menorSal) {
            menorSal = funcs[i].sal;
        }
    }

    var media = somaSal / funcs.length;

    document.getElementById('res').innerHTML = 
        'Média de salários: ' + media.toFixed(2) + '<br>' +
        'Maior salário: ' + maiorSal.toFixed(2) + '<br>' +
        'Menor salário: ' + menorSal.toFixed(2);
}