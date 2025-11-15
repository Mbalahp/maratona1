function dividir() {
    var num1 = parseInt(document.getElementById('n1').value);
    var num2 = parseInt(document.getElementById('n2').value);
    var res = document.getElementById('res');

    if (num1 < 0 || num2 <= 0) {
        res.innerText = "Por favor, insira números inteiros positivos, com Num2 > 0.";
        return;
    }

    var quoc = 0;
    var resto = num1;

    while (resto >= num2) {
        resto = resto - num2;
        quoc = quoc + 1;
    }

    res.innerHTML = 'Quociente: ' + quoc + '<br>Resto: ' + resto;
}