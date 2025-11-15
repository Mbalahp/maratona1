function verificar() {
    var texto = document.getElementById('texto').value;
    var res = document.getElementById('res');

    var textoLimpo = texto.toLowerCase().replace(/[^a-z0-9]/g, '');
    var textoInvertido = textoLimpo.split('').reverse().join('');

    if (textoLimpo == textoInvertido) {
        res.innerText = 'O texto "' + texto + '" é um palíndromo.';
    } else {
        res.innerText = 'O texto "' + texto + '" não é um palíndromo.';
    }
}
