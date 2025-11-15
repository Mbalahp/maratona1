function removerEspacos() {
    var texto = document.getElementById('texto').value;
    var res = document.getElementById('res');

    var novoTexto = texto.replace(/ /g, '');

    res.innerText = novoTexto;
}
