function imprimir() {
    var res = document.getElementById('res');
    var seq = '';

    for (var i = 1; i <= 10; i++) {
        seq += '(' + i + ', ';
        for (var j = 1; j <= 10; j++) {
            seq += j + ' ';
        }
        seq += ')<br>';
    }

    res.innerHTML = seq;
}