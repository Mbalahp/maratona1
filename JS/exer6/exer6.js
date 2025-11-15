function s() {
    let numsStr = document.getElementById('nums').value;
    let r = document.getElementById('r');
    let sum = 0;
    for (let i = 0; i < numsStr.length; i++) {
        sum += parseInt(numsStr[i]);
    }
    r.innerText = sum;
}