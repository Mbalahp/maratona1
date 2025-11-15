var q = [];
var cont = 0;

function add() {
    var num = document.getElementById('num').value;
    if (num < 0) {
        alert('Apenas números positivos!');
        return;
    }

    if (cont < 20) {
        q.push(num);
        cont++;
        document.getElementById('c').innerText = cont;
        document.getElementById('num').value = '';
        if (cont == 20) {
            acharMaior();
        }
    }
}

function acharMaior() {
    var maior = q[0];
    var pos = 0;
    for (var i = 1; i < q.length; i++) {
        if (q[i] > maior) {
            maior = q[i];
            pos = i;
        }
    }
    document.getElementById('res').innerText = 'Maior: ' + maior + ' na posição ' + pos;
}