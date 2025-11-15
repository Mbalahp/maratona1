var alunos = [];
var cont = 0;

function add() {
    if (cont < 45) {
        var idade = parseInt(document.getElementById('idade').value);
        var altura = parseFloat(document.getElementById('altura').value);
        alunos.push({idade: idade, altura: altura});
        cont++;
        document.getElementById('c').innerText = cont;
        document.getElementById('idade').value = '';
        document.getElementById('altura').value = '';
        if (cont == 45) {
            processar();
        }
    }
}

function processar() {
    var somaIdade = 0;
    var contIdade = 0;
    var somaAltura = 0;
    var contAltura = 0;

    for (var i = 0; i < alunos.length; i++) {
        if (alunos[i].altura < 1.70) {
            somaIdade += alunos[i].idade;
            contIdade++;
        }
        if (alunos[i].idade > 20) {
            somaAltura += alunos[i].altura;
            contAltura++;
        }
    }

    var mediaIdade = 0;
    if(contIdade > 0) {
        mediaIdade = somaIdade / contIdade;
    }

    var mediaAltura = 0;
    if(contAltura > 0) {
        mediaAltura = somaAltura / contAltura;
    }

    document.getElementById('res').innerHTML = 
        'Idade média (altura < 1.70m): ' + mediaIdade.toFixed(2) + '<br>' +
        'Altura média (idade > 20 anos): ' + mediaAltura.toFixed(2);
}