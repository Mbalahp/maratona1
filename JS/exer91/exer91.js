function verificar() {
    var num = parseInt(document.getElementById('num').value);
    var res = document.getElementById('res');
    var ehTriangular = false;

    for (var i = 1; i * (i + 1) * (i + 2) <= num; i++) {
        if (i * (i + 1) * (i + 2) == num) {
            ehTriangular = true;
            break;
        }
    }

    if (ehTriangular) {
        res.innerText = 'O número ' + num + ' é triangular.';
    } else {
        res.innerText = 'O número ' + num + ' não é triangular.';
    }
}
