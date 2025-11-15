function calcular() {
    var massa = parseFloat(document.getElementById('massa').value);
    var res = document.getElementById('res');
    var tempo = 0;

    while (massa >= 0.05) {
        massa /= 2;
        tempo += 50;
    }

    res.innerText = 'Tempo necessário: ' + tempo + ' segundos.';
}