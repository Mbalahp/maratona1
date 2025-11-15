function fatorial() {
    var num = parseInt(document.getElementById('num').value);
    var res = document.getElementById('res');
    var fat = 1;

    if (num < 0) {
        res.innerText = 'Não existe fatorial de número negativo.';
        return;
    }
    
    if (num == 0) {
        fat = 1;
    } else {
        for (var i = 1; i <= num; i++) {
            fat *= i;
        }
    }

    res.innerText = 'O fatorial é: ' + fat;
}

function parImpar() {
    var num = parseInt(document.getElementById('num').value);
    var res = document.getElementById('res');

    if (num % 2 == 0) {
        res.innerText = 'O número é par.';
    } else {
        res.innerText = 'O número é ímpar.';
    }
}

function primo() {
    var num = parseInt(document.getElementById('num').value);
    var res = document.getElementById('res');
    var ehPrimo = true;

    if (num <= 1) {
        ehPrimo = false;
    } else {
        for (var i = 2; i < num; i++) {
            if (num % i == 0) {
                ehPrimo = false;
                break;
            }
        }
    }

    if (ehPrimo) {
        res.innerText = 'O número é primo.';
    } else {
        res.innerText = 'O número não é primo.';
    }
}
