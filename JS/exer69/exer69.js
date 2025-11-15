function inverter() {
    var nome = document.getElementById('nome').value;
    var res = document.getElementById('res');

    var nomeInvertido = nome.split('').reverse().join('').toUpperCase();

    res.innerText = nomeInvertido;
}
