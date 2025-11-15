function noVogais(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    var char = String.fromCharCode(charCode).toLowerCase();
    var vogais = 'aeiouáéíóúàèìòùãõâêîôû'; // Including accented vowels

    if (vogais.indexOf(char) != -1) {
        return false; // Prevent typing vowel
    }
    return true;
}
