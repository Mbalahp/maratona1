function fatorial(num) {
    if (num == 0) {
        return 1;
    }
    var fat = 1;
    for (var i = 1; i <= num; i++) {
        fat *= i;
    }
    return fat;
}

function cal() {
    var n = parseInt(document.getElementById('n').value);
    var res = document.getElementById('res');
    var e = 1;

    for (var i = 1; i <= n; i++) {
        e += 1 / fatorial(i);
    }

    res.innerText = 'O valor de E é: ' + e;
}
