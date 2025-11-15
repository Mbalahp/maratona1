function desenhar() {
    var base = document.getElementById('base').value;
    var res = document.getElementById('res');
    var triangulo = '';

    if (base < 5 || base > 15) {
        alert('A base deve ser entre 5 e 15.');
        return;
    }

    if (base % 2 == 0) {
        alert('A base deve ser um número ímpar.');
        return;
    }

    for (var i = 1; i <= base; i += 2) {
        var espacos = (base - i) / 2;
        for (var j = 0; j < espacos; j++) {
            triangulo += ' ';
        }
        for (var k = 0; k < i; k++) {
            triangulo += '#';
        }
        triangulo += '\n';
    }

    res.innerText = triangulo;
}