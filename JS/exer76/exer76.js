function substituir() {
    var frase = document.getElementById('frase').value;
    var antiga = document.getElementById('antiga').value;
    var nova = document.getElementById('nova').value;
    var res = document.getElementById('res');

    var ultimaOcorrencia = frase.lastIndexOf(antiga);

    if (ultimaOcorrencia != -1) {
        var novaFrase = frase.substring(0, ultimaOcorrencia) + nova + frase.substring(ultimaOcorrencia + antiga.length);
        res.innerText = novaFrase;
    } else {
        res.innerText = 'Palavra antiga não encontrada.';
    }
}
