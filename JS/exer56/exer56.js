var pessoas = [];

function addPessoa() {
    var idade = parseInt(document.getElementById('idade').value);
    
    if (idade < 0) {
        processar();
        return;
    }

    var sexo = document.getElementById('sexo').value.toUpperCase();
    var sal = parseFloat(document.getElementById('sal').value);

    pessoas.push({idade: idade, sexo: sexo, sal: sal});

    document.getElementById('idade').value = '';
    document.getElementById('sexo').value = '';
    document.getElementById('sal').value = '';
}

function processar() {
    var res = document.getElementById('res');
    var somaSal = 0;
    var maiorIdade = 0;
    var menorIdade = 999; // Um número grande para começar
    var mulheresSalAte100 = 0;

    if (pessoas.length == 0) {
        res.innerText = 'Nenhum dado adicionado.';
        return;
    }

    for (var i = 0; i < pessoas.length; i++) {
        somaSal += pessoas[i].sal;
        
        if (pessoas[i].idade > maiorIdade) {
            maiorIdade = pessoas[i].idade;
        }
        if (pessoas[i].idade < menorIdade) {
            menorIdade = pessoas[i].idade;
        }

        if (pessoas[i].sexo == 'F' && pessoas[i].sal <= 100) {
            mulheresSalAte100++;
        }
    }

    var mediaSal = somaSal / pessoas.length;

    res.innerHTML = 
        'Média de salário do grupo: ' + mediaSal.toFixed(2) + '<br>' +
        'Maior idade do grupo: ' + maiorIdade + '<br>' +
        'Menor idade do grupo: ' + menorIdade + '<br>' +
        'Mulheres com salário até R$100,00: ' + mulheresSalAte100;
    
    pessoas = []; // Clear data after processing
}
