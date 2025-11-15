var numAndares = 0;
var andarAtual = 1;
var pessoasNoElevador = 0;
var pessoasDescer = 0;

function iniciar() {
    numAndares = parseInt(document.getElementById('andares').value);
    document.getElementById('s1').style.display = 'none';
    document.getElementById('s2').style.display = 'block';
    document.getElementById('andarAtual').innerText = andarAtual;
}

function proximoAndar() {
    var entrar = parseInt(document.getElementById('entrar').value);
    var sair = parseInt(document.getElementById('sair').value);

    pessoasNoElevador += entrar;
    pessoasNoElevador -= sair;

    if (pessoasNoElevador > 15) {
        var excesso = pessoasNoElevador - 15;
        document.getElementById('res').innerHTML += 'EXCESSO DE PASSAGEIROS. DEVEM SAIR ' + excesso + ' PESSOAS.<br>';
        pessoasNoElevador = 15; // Limita a 15
    }

    document.getElementById('entrar').value = '';
    document.getElementById('sair').value = '';

    if (andarAtual < numAndares) {
        andarAtual++;
        document.getElementById('andarAtual').innerText = andarAtual;
    } else {
        pessoasDescer = pessoasNoElevador;
        document.getElementById('res').innerHTML += 'No último andar, ' + pessoasDescer + ' pessoas irão descer.';
        document.getElementById('s2').style.display = 'none';
    }
}
