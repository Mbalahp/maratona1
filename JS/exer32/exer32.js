function calcular() {
    var total = 0;
    var graos = 1;
    for (var i = 0; i < 64; i++) {
        total += graos;
        graos *= 2;
    }
    document.getElementById('res').innerText = 'Total de grãos: ' + total;
}