var nums = [];
var cont = 0;

function add() {
    if (cont < 10) {
        var num = parseInt(document.getElementById('num').value);
        nums.push(num);
        cont++;
        document.getElementById('c').innerText = cont;
        document.getElementById('num').value = '';
        if (cont == 10) {
            processar();
        }
    }
}

function processar() {
    var soma = 0;
    var maior = nums[0];
    var menor = nums[0];

    for (var i = 0; i < nums.length; i++) {
        soma += nums[i];
        if (nums[i] > maior) {
            maior = nums[i];
        }
        if (nums[i] < menor) {
            menor = nums[i];
        }
    }

    var media = soma / nums.length;

    document.getElementById('res').innerHTML = 
        'Média: ' + media + '<br>' +
        'Maior: ' + maior + '<br>' +
        'Menor: ' + menor;
}