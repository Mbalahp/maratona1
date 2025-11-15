function obterSobrenome() {
    var nomeCompleto = document.getElementById('nomeCompleto').value;
    var res = document.getElementById('res');

    var partes = nomeCompleto.split(' ');
    var sobrenome = partes[partes.length - 1];

    res.innerText = 'Sobrenome: ' + sobrenome;
}
