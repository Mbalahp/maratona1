function c() {
    let op = document.getElementById('op').value;
    let n1 = parseFloat(document.getElementById('n1').value);
    let n2 = parseFloat(document.getElementById('n2').value);
    let r = document.getElementById('r');
    let res;

    switch (op) {
        case '+':
            res = n1 + n2;
            break;
        case '-':
            res = n1 - n2;
            break;
        case '*':
            res = n1 * n2;
            break;
        case '/':
            res = n1 / n2;
            break;
        default:
            res = 'Operação inválida';
    }
    r.innerText = res;
}