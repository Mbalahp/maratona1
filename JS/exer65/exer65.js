function asteriscar() {
    var frase = document.getElementById('frase').value;
    var res = document.getElementById('res');
    var palavras = frase.split(' ');
    var fraseAsterisco = '';

    for (var i = 0; i < palavras.length; i++) {
        for (var j = 0; j < palavras[i].length; j++) {
            fraseAsterisco += '*';
        }
        fraseAsterisco += ' ';
    }

    res.innerText = fraseAsterisco.trim();
}
