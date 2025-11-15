function abrev() {
    var nome = document.getElementById('nome').value;
    var r = document.getElementById('res');
    var p = nome.split(' ');
    var a = '';
    for (var i = 0; i < p.length; i++) {
        if (p[i].length > 2) {
            a += p[i][0].toUpperCase() + '. ';
        } else {
            a += p[i] + ' ';
        }
    }
    r.innerText = a.trim();
}