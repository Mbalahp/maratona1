function getVals() {
    var a = parseInt(document.getElementById('a').value);
    var b = parseInt(document.getElementById('b').value);
    return {a: a, b: b};
}

function execA() {
    var vals = getVals();
    var res = '';
    for (var i = 0; i < 10; i++) {
        res += 'Iteração ' + (i + 1) + ': ' + (vals.a % vals.b) + '<br>';
    }
    document.getElementById('res').innerHTML = res;
}

function execB() {
    // Para não executar nenhuma vez, a condição do loop deve ser falsa desde o início.
    var res = 'Não executou nenhuma vez.';
    for (var i = 0; i < 0; i++) {
        // este código nunca será executado
    }
    document.getElementById('res').innerHTML = res;
}

function execC() {
    var vals = getVals();
    var res = '';
    var count = 0;
    for (var i = 0; i < 10; i++) {
        for (var j = 0; j < 10; j++) {
            count++;
            res += 'Iteração ' + count + ': ' + (vals.a % vals.b) + '<br>';
        }
    }
    document.getElementById('res').innerHTML = res;
}

function execD() {
    var vals = getVals();
    var n = parseInt(document.getElementById('n').value);
    var res = '';
    for (var i = 0; i < n; i++) {
        res += 'Iteração ' + (i + 1) + ': ' + (vals.a % vals.b) + '<br>';
    }
    document.getElementById('res').innerHTML = res;
}