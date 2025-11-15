var nums = [];

function add() {
    var num = document.getElementById('num').value;
    nums.push(parseFloat(num));
    document.getElementById('num').value = '';
}

function calc() {
    var soma = 0;
    var pos = 0;
    var neg = 0;

    for (var i = 0; i < nums.length; i++) {
        soma += nums[i];
        if (nums[i] >= 0) {
            pos++;
        } else {
            neg++;
        }
    }

    var media = soma / nums.length;
    var percPos = (pos / nums.length) * 100;
    var percNeg = (neg / nums.length) * 100;

    var res = 'Média: ' + media + '<br>' +
              'Positivos: ' + pos + '<br>' +
              'Negativos: ' + neg + '<br>' +
              'Percentual Positivos: ' + percPos.toFixed(2) + '%<br>' +
              'Percentual Negativos: ' + percNeg.toFixed(2) + '%';

    document.getElementById('res').innerHTML = res;
    nums = [];
}