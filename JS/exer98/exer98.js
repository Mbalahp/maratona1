function contar() {
    var limite = parseInt(document.getElementById('limite').value);
    var res = document.getElementById('res');
    var output = '';

    for (var i = 1; i <= limite; i++) {
        if (i % 2 == 0) {
            output += '<span class="par">' + i + '</span> ';
        } else {
            output += '<span class="impar">' + i + '</span> ';
        }
    }

    res.innerHTML = output;
}
