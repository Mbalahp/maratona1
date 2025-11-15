function f() {
    let r = document.getElementById('r');
    let a = 0, b = 1, temp;
    let fib = [];
    for (let i = 0; i < 15; i++) {
        fib.push(a);
        temp = a + b;
        a = b;
        b = temp;
    }
    r.innerText = fib.join(', ');
}