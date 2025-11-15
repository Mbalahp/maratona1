var alunos = [];

function addAluno() {
    var mat = parseInt(document.getElementById('mat').value);
    
    if (mat == 9999) {
        processar();
        return;
    }

    var n1 = parseFloat(document.getElementById('n1').value);
    var n2 = parseFloat(document.getElementById('n2').value);
    var n3 = parseFloat(document.getElementById('n3').value);

    alunos.push({mat: mat, n1: n1, n2: n2, n3: n3});

    document.getElementById('mat').value = '';
    document.getElementById('n1').value = '';
    document.getElementById('n2').value = '';
    document.getElementById('n3').value = '';
}

function processar() {
    var res = document.getElementById('res');
    var totalAlunos = alunos.length;
    var aprovados = 0;
    var reprovados = 0;
    var r = '';

    for (var i = 0; i < alunos.length; i++) {
        var mf = ((2 * alunos[i].n1) + (3 * alunos[i].n2) + (4 * alunos[i].n3)) / 9;
        var status = '';
        if (mf >= 5) {
            status = 'APROVADO';
            aprovados++;
        } else {
            status = 'REPROVADO';
            reprovados++;
        }
        r += 'Matrícula: ' + alunos[i].mat + ', Média Final: ' + mf.toFixed(2) + ', Status: ' + status + '<br>';
    }

    r += '<br>Total de alunos: ' + totalAlunos + '<br>';
    r += 'Total de aprovados: ' + aprovados + '<br>';
    r += 'Total de reprovados: ' + reprovados;

    res.innerHTML = r;
    alunos = []; // Clear data after processing
}
