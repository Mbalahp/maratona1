var nums = [];
var cont = 0;

function add() {
    if (cont < 50) {
        var num = document.getElementById('num').value;
        nums.push(parseInt(num));
        cont++;
        document.getElementById('c').innerText = cont;
        document.getElementById('num').value = '';
        if (cont == 50) {
            processar();
        }
    }
}

function processar() {
    var somaPos = 0;
    var qtdNeg = 0;
    for (var i = 0; i < nums.length; i++) {
        if (nums[i] > 0) {
            somaPos += nums[i];
        } else if (nums[i] < 0) {
            qtdNeg++;
        }
    }
    document.getElementById('res').innerHTML = 'Soma dos positivos: ' + somaPos + '<br>Quantidade de negativos: ' + qtdNeg;
}