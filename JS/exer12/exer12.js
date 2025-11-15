let nums = [];
let c = 0;

function add() {
    if (c < 10) {
        let n = parseInt(document.getElementById('n').value);
        nums.push(n);
        c++;
        document.getElementById('c').innerText = c;
        document.getElementById('n').value = '';
        if (c === 10) {
            document.getElementById('step1').style.display = 'none';
            document.getElementById('step2').style.display = 'block';
        }
    }
}

function comp() {
    let n2 = parseInt(document.getElementById('n2').value);
    let count = 0;
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] < n2) {
            count++;
        }
    }
    document.getElementById('r').innerText = 'Existem ' + count + ' números inferiores a ' + n2;
}