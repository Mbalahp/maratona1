function mostrarData() {
    var dataStr = document.getElementById('data').value;
    var res = document.getElementById('res');

    var partes = dataStr.split('/');
    var dia = parseInt(partes[0]);
    var mes = parseInt(partes[1]);
    var ano = parseInt(partes[2]);

    var meses = [
        'Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho',
        'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'
    ];

    res.innerText = 'Você nasceu em ' + dia + ' de ' + meses[mes - 1] + ' de ' + ano;
}
