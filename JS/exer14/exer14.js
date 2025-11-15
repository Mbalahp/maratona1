function comp() {
    var p1 = document.getElementById('p1').value;
    var p2 = document.getElementById('p2').value;
    var res = document.getElementById('res');
    var r = '';

    if (p1 == p2) {
        r = 'As palavras são iguais.';
    } else {
        r = 'As palavras são diferentes.<br>';
        if (p1.length > p2.length) {
            r += 'A primeira palavra é maior.<br>';
        } else if (p2.length > p1.length) {
            r += 'A segunda palavra é maior.<br>';
        } else {
            r += 'As palavras têm o mesmo tamanho.<br>';
        }
    }

    if (p1.includes(p2)) {
        r += 'A segunda palavra é uma substring da primeira.';
    }

    res.innerHTML = r;
}