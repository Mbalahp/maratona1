function transformar() {
    var frase = document.getElementById('frase').value;
    var res = document.getElementById('res');
    var novaFrase = '';
    var vogais = 'aeiouAEIOU';

    for (var i = 0; i < frase.length; i++) {
        var char = frase[i];
        if (vogais.indexOf(char) != -1) { // É vogal
            novaFrase += '!';
        } else if (char.match(/[a-zA-Z]/)) { // É consoante
            novaFrase += char.toUpperCase();
        } else { // Não é letra
            novaFrase += char;
        }
    }

    res.innerText = novaFrase;
}
