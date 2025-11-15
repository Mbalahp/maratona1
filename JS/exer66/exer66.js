function substituir() {
    var frase = document.getElementById('frase').value;
    var res = document.getElementById('res');
    var novaFrase = '';
    var vogais = 'aeiouAEIOU';

    for (var i = 0; i < frase.length; i++) {
        var char = frase[i];
        if (vogais.indexOf(char) == -1 && char.match(/[a-zA-Z]/)) { // Check if it's a consonant
            novaFrase += '&';
        } else {
            novaFrase += char;
        }
    }

    res.innerText = novaFrase;
}
