var profs = [];

function addProf() {
    var cod = document.getElementById('cod').value;
    if (cod == 99999) {
        alert('Código 99999 é para finalizar. Clique em "Calcular Folha".');
        return;
    }
    var sexo = document.getElementById('sexo').value.toUpperCase();
    var horas = document.getElementById('horas').value;

    profs.push({cod: cod, sexo: sexo, horas: horas});

    document.getElementById('cod').value = '';
    document.getElementById('sexo').value = '';
    document.getElementById('horas').value = '';
}

function calcFolha() {
    var res = document.getElementById('res');
    var relat = '';
    var salLiqMasc = 0;
    var countMasc = 0;
    var salLiqFem = 0;
    var countFem = 0;

    for (var i = 0; i < profs.length; i++) {
        var p = profs[i];
        var salBruto = p.horas * 30;
        var desc;
        if (p.sexo == 'M') {
            desc = salBruto * 0.10;
            countMasc++;
        } else {
            desc = salBruto * 0.05;
            countFem++;
        }
        var salLiq = salBruto - desc;

        if (p.sexo == 'M') {
            salLiqMasc += salLiq;
        } else {
            salLiqFem += salLiq;
        }

        relat += 'Código: ' + p.cod + ', Salário Bruto: ' + salBruto.toFixed(2) + ', Salário Líquido: ' + salLiq.toFixed(2) + '<br>';
    }

    if(countMasc > 0){
        var mediaMasc = salLiqMasc / countMasc;
        relat += '<br>Média Salário Líquido (Masc): ' + mediaMasc.toFixed(2) + '<br>';
    }
    if(countFem > 0){
        var mediaFem = salLiqFem / countFem;
        relat += 'Média Salário Líquido (Fem): ' + mediaFem.toFixed(2) + '<br>';
    }

    res.innerHTML = relat;
    profs = [];
}