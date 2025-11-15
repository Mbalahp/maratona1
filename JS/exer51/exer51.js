var funcs = [];

function addFunc() {
    var nome = document.getElementById('nome').value;
    var sal = parseFloat(document.getElementById('sal').value);

    if (nome.toLowerCase() == 'fim') {
        processar();
        return;
    }

    funcs.push({nome: nome, sal: sal});

    document.getElementById('nome').value = '';
    document.getElementById('sal').value = '';
}

function processar() {
    var res = document.getElementById('res');
    var somaSal = 0;
    var maiorSal = 0;
    var menorSal = 999999999; // Um número grande para começar

    if (funcs.length == 0) {
        res.innerText = 'Nenhum funcionário adicionado.';
        return;
    }

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

    res.innerHTML = 
        'Média de salários: ' + media.toFixed(2) + '<br>' +
        'Maior salário: ' + maiorSal.toFixed(2) + '<br>' +
        'Menor salário: ' + menorSal.toFixed(2);
    
    funcs = []; // Clear data after processing
}
