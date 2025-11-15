var nomes = [];
var cont = 0;

function add() {
    if (cont < 10) {
        var nome = document.getElementById('nome').value;
        nomes.push(nome);
        cont++;
        document.getElementById('c').innerText = cont;
        document.getElementById('nome').value = '';
        if (cont == 10) {
            document.getElementById('s1').style.display = 'none';
            document.getElementById('s2').style.display = 'block';
        }
    }
}

function buscar() {
    var nomeBusca = document.getElementById('nomeBusca').value;
    var achei = false;
    for (var i = 0; i < nomes.length; i++) {
        if (nomes[i] == nomeBusca) {
            achei = true;
            break;
        }
    }

    if (achei) {
        document.getElementById('res').innerText = 'ACHEI';
    } else {
        document.getElementById('res').innerText = 'NÃO ACHEI';
    }
}