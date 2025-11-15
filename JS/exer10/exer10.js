let nums = [];

function a() {
    let n = parseInt(document.getElementById('n').value);
    let r = document.getElementById('r');

    if (n >= 0) {
        nums.push(n);
        document.getElementById('n').value = '';
    } else {
        let sum = 0;
        for (let i = 0; i < nums.length; i++) {
            sum += nums[i];
        }
        let avg = sum / nums.length;
        r.innerText = 'Média: ' + avg;
        nums = [];
    }
}