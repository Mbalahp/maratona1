var nomesContagem = {};
var ultimoNome = '';
var contConsecutivo = 0;
var maisInserido = '';
var maxConsecutivo = 0;

function addNome() {
    var nome = document.getElementById('nome').value.toLowerCase();
    var listaNomes = document.getElementById('listaNomes');

    if (nomesContagem[nome]) {
        nomesContagem[nome]++;
    } else {
        nomesContagem[nome] = 1;
    }

    // Atualizar listbox
    var found = false;
    for (var i = 0; i < listaNomes.options.length; i++) {
        if (listaNomes.options[i].value == nome) {
            listaNomes.options[i].text = nome + ' (' + nomesContagem[nome] + ')';
            found = true;
            break;
        }
    }
    if (!found) {
        var opt = document.createElement('option');
        opt.value = nome;
        opt.text = nome + ' (' + nomesContagem[nome] + ')';
        listaNomes.add(opt);
    }

    // Lógica para o nome mais inserido consecutivamente
    if (nome == ultimoNome) {
        contConsecutivo++;
    } else {
        contConsecutivo = 1;
        ultimoNome = nome;
    }

    if (contConsecutivo > maxConsecutivo) {
        maxConsecutivo = contConsecutivo;
        maisInserido = nome;
    }

    document.getElementById('nome').value = '';
}

function processar() {
    var res = document.getElementById('res');
    var nomeMenosInserido = '';
    var minContagem = 999999999;

    for (var n in nomesContagem) {
        if (nomesContagem[n] < minContagem) {
            minContagem = nomesContagem[n];
            nomeMenosInserido = n;
        }
    }

    res.innerHTML = 
        'Nome mais inserido consecutivamente: ' + maisInserido + ' (' + maxConsecutivo + ' vezes)<br>' +
        'Nome menos inserido: ' + nomeMenosInserido + ' (' + minContagem + ' vezes)';
}
