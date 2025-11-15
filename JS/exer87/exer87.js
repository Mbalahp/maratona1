function conjugar() {
    var verbo = document.getElementById('verbo').value.toLowerCase();
    var res = document.getElementById('res');
    var conjugacao = '';

    if (!verbo.endsWith('er')) {
        res.innerText = 'Por favor, digite um verbo terminado em "ER".';
        return;
    }

    var radical = verbo.substring(0, verbo.length - 2);

    conjugacao += 'Eu ' + radical + 'o<br>';
    conjugacao += 'Tu ' + radical + 'es<br>';
    conjugacao += 'Ele/Ela ' + radical + 'e<br>';
    conjugacao += 'Nós ' + radical + 'emos<br>';
    conjugacao += 'Vós ' + radical + 'eis<br>';
    conjugacao += 'Eles/Elas ' + radical + 'em<br>';

    res.innerHTML = conjugacao;
}
