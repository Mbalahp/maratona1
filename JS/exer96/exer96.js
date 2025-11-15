function formatar() {
    var texto = document.getElementById('texto').value;
    var res = document.getElementById('res');
    var textoFormatado = '';
    var inComment = false;

    for (var i = 0; i < texto.length; i++) {
        if (texto[i] == '/' && texto[i+1] == '*') {
            inComment = true;
            textoFormatado += texto[i];
        } else if (texto[i] == '*' && texto[i+1] == '/') {
            inComment = false;
            textoFormatado += texto[i];
            i++; // Skip next character '/'
            textoFormatado += texto[i];
        } else if (inComment) {
            textoFormatado += '<span style="color: red;">' + texto[i] + '</span>';
        } else {
            textoFormatado += texto[i];
        }
    }

    res.innerHTML = textoFormatado;
}
