function gerar() {
    var n = parseInt(document.getElementById('n').value);
    var res = document.getElementById('res');
    var fib = [0, 1];
    
    if (n < 2) {
        res.innerText = 'N deve ser maior ou igual a 2.';
        return;
    }

    for (var i = 2; i < n; i++) {
        fib[i] = fib[i-1] + fib[i-2];
    }

    res.innerText = fib.join(', ');
}
