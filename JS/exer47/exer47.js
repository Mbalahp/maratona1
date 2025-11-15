var alunos = [];

function add() {
    var vezes = parseInt(document.getElementById('vezes').value);
    alunos.push(vezes);
    document.getElementById('vezes').value = '';
}

function calc() {
    var menos10 = 0;
    var entre10e15 = 0;
    var mais15 = 0;

    for (var i = 0; i < alunos.length; i++) {
        if (alunos[i] < 10) {
            menos10++;
        } else if (alunos[i] >= 10 && alunos[i] <= 15) {
            entre10e15++;
        } else {
            mais15++;
        }
    }

    var total = alunos.length;
    if (total == 0) return;
    var percMenos10 = (menos10 / total) * 100;
    var percEntre10e15 = (entre10e15 / total) * 100;
    var percMais15 = (mais15 / total) * 100;

    document.getElementById('res').innerHTML = 
        'Menos de 10 vezes: ' + percMenos10.toFixed(2) + '%<br>' +
        'Entre 10 e 15 vezes: ' + percEntre10e15.toFixed(2) + '%<br>' +
        'Mais de 15 vezes: ' + percMais15.toFixed(2) + '%';
    
    alunos = [];
}