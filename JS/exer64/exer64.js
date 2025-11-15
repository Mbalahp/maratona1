var clientes = [];

function addCliente() {
    var nome = document.getElementById('nome').value;
    var diarias = parseInt(document.getElementById('diarias').value);

    clientes.push({nome: nome, diarias: diarias});

    document.getElementById('nome').value = '';
    document.getElementById('diarias').value = '';
}

function processar() {
    var res = document.getElementById('res');
    var r = '';
    var totalHotel = 0;

    for (var i = 0; i < clientes.length; i++) {
        var diarias = clientes[i].diarias;
        var taxaServico;

        if (diarias < 15) {
            taxaServico = 4.00;
        } else if (diarias == 15) {
            taxaServico = 3.60;
        } else {
            taxaServico = 3.00;
        }

        var contaCliente = (diarias * 50) + (diarias * taxaServico);
        totalHotel += contaCliente;

        r += 'Cliente: ' + clientes[i].nome + ', Conta Total: R$ ' + contaCliente.toFixed(2) + '<br>';
    }

    r += '<br>Total ganho pelo hotel: R$ ' + totalHotel.toFixed(2);

    res.innerHTML = r;
    clientes = []; // Clear data after processing
}
