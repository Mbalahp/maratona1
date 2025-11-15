function gerar() {
    var res = document.getElementById('res');
    var fib = [0, 1];
    
    for (var i = 2; i < 20; i++) {
        fib[i] = fib[i-1] + fib[i-2];
    }

    res.innerText = fib.join(', ');
}