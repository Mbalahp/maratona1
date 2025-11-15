function calcular() {
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