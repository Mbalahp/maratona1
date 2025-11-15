var habitantes = [];

function addHab() {
    var idade = parseInt(document.getElementById('idade').value);
    
    if (idade == -1) {
        processar();
        return;
    }

    var sexo = document.getElementById('sexo').value.toUpperCase();
    var olhos = document.getElementById('olhos').value.toUpperCase();
    var cabelo = document.getElementById('cabelo').value.toUpperCase();

    habitantes.push({idade: idade, sexo: sexo, olhos: olhos, cabelo: cabelo});

    document.getElementById('idade').value = '';
    document.getElementById('sexo').value = '';
    document.getElementById('olhos').value = '';
    document.getElementById('cabelo').value = '';
}

function processar() {
    var res = document.getElementById('res');
    var maiorIdade = 0;
    var fem18a35 = 0;
    var olhosVerdesCabeloLouro = 0;

    if (habitantes.length == 0) {
        res.innerText = 'Nenhum dado adicionado.';
        return;
    }

    for (var i = 0; i < habitantes.length; i++) {
        if (habitantes[i].idade > maiorIdade) {
            maiorIdade = habitantes[i].idade;
        }

        if (habitantes[i].sexo == 'F' && habitantes[i].idade >= 18 && habitantes[i].idade <= 35) {
            fem18a35++;
        }

        if (habitantes[i].olhos == 'V' && habitantes[i].cabelo == 'L') {
            olhosVerdesCabeloLouro++;
        }
    }

    res.innerHTML = 
        'Maior idade: ' + maiorIdade + '<br>' +
        'Mulheres entre 18 e 35 anos: ' + fem18a35 + '<br>' +
        'Indivíduos com olhos verdes e cabelos louros: ' + olhosVerdesCabeloLouro;
    
    habitantes = []; // Clear data after processing
}
