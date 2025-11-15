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
    var pares = 0;
    var impares = 0;
    for (var i = 0; i < nums.length; i++) {
        if (nums[i] % 2 == 0) {
            pares++;
        } else {
            impares++;
        }
    }

    document.getElementById('res').innerHTML = 
        'Pares: ' + pares + '<br>' +
        'Ímpares: ' + impares;
    
    nums = [];
}