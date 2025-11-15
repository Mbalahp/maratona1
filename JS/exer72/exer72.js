function converter() {
    var num = parseInt(document.getElementById('num').value);
    var res = document.getElementById('res');

    if (num < 20 || num > 99) {
        res.innerText = 'Número fora do intervalo (20-99).';
        return;
    }

    var unidades = ['', 'um', 'dois', 'três', 'quatro', 'cinco', 'seis', 'sete', 'oito', 'nove'];
    var dezenas = ['', '', 'vinte', 'trinta', 'quarenta', 'cinquenta', 'sessenta', 'setenta', 'oitenta', 'noventa'];
    var especiais = ['dez', 'onze', 'doze', 'treze', 'quatorze', 'quinze', 'dezesseis', 'dezessete', 'dezoito', 'dezenove'];

    var texto = '';

    if (num >= 10 && num <= 19) {
        texto = especiais[num - 10];
    } else {
        var dezena = Math.floor(num / 10);
        var unidade = num % 10;

        texto = dezenas[dezena];
        if (unidade > 0) {
            texto += ' e ' + unidades[unidade];
        }
    }

    res.innerText = texto;
}
