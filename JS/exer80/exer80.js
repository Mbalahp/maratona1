function desenhar() {
    var tamanho = parseInt(document.getElementById('tamanho').value);
    var forma = document.getElementById('forma').value;
    var res = document.getElementById('res');
    var desenho = '';

    if (tamanho <= 0) {
        res.innerText = 'Tamanho deve ser positivo.';
        return;
    }

    if (forma == 'triangulo') {
        for (var i = 1; i <= tamanho; i++) {
            for (var j = 0; j < i; j++) {
                desenho += '%';
            }
            desenho += '\n';
        }
    } else if (forma == 'losango') {
        // Parte superior do losango
        for (var i = 1; i <= tamanho; i++) {
            for (var esp = 0; esp < tamanho - i; esp++) {
                desenho += ' ';
            }
            for (var ast = 0; ast < 2 * i - 1; ast++) {
                desenho += '%';
            }
            desenho += '\n';
        }
        // Parte inferior do losango
        for (var i = tamanho - 1; i >= 1; i--) {
            for (var esp = 0; esp < tamanho - i; esp++) {
                desenho += ' ';
            }
            for (var ast = 0; ast < 2 * i - 1; ast++) {
                desenho += '%';
            }
            desenho += '\n';
        }
    }

    res.innerText = desenho;
}
