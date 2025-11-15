var nums = [];

function add() {
    var num = parseInt(document.getElementById('num').value);
    
    if (num == 9999) {
        processar();
    } else {
        nums.push(num);
        document.getElementById('num').value = '';
    }
}

function processar() {
    var soma = 0;
    for (var i = 0; i < nums.length; i++) {
        soma += nums[i];
    }
    var media = soma / nums.length;

    document.getElementById('res').innerHTML = 
        'Soma: ' + soma + '<br>' +
        'Média: ' + media;
    
    nums = [];
}