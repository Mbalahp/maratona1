var nums = [];
var cont = 0;

function isPrime(num) {
    if (num <= 1) return false;
    for (var i = 2; i < num; i++) {
        if (num % i == 0) return false;
    }
    return true;
}

function addNum() {
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
    var somaPares = 0;
    var somaPrimos = 0;

    for (var i = 0; i < nums.length; i++) {
        if (nums[i] % 2 == 0) {
            somaPares += nums[i];
        }
        if (isPrime(nums[i])) {
            somaPrimos += nums[i];
        }
    }

    document.getElementById('res').innerHTML = 
        'Soma dos pares: ' + somaPares + '<br>' +
        'Soma dos primos: ' + somaPrimos;
    
    nums = [];
    cont = 0;
    document.getElementById('c').innerText = cont;
}
