function contagem() {
    var num = parseInt(document.getElementById('num').value);
    var res = document.getElementById('res');
    var contagemStr = '';

    for (var i = num; i >= 0; i -= 2) {
        contagemStr += i + ' ';
    }

    res.innerText = contagemStr.trim();
}
