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
    if (nums.length == 0) return;
    var maior = nums[0];
    for (var i = 1; i < nums.length; i++) {
        if (nums[i] > maior) {
            maior = nums[i];
        }
    }

    document.getElementById('res').innerText = 'Maior: ' + maior;
    
    nums = [];
}