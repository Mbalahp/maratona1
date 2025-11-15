function getDivSum(n) {
    let sum = 1;
    for (let i = 2; i * i <= n; i++) {
        if (n % i === 0) {
            sum += i;
            if (i * i !== n) {
                sum += n / i;
            }
        }
    }
    return sum;
}

function f() {
    let r = document.getElementById('r');
    let res = [];
    for (let i = 2; i <= 100000; i++) {
        let sum1 = getDivSum(i);
        if (sum1 > i && sum1 <= 100000) {
            let sum2 = getDivSum(sum1);
            if (sum2 === i) {
                res.push('(' + i + ', ' + sum1 + ')');
            }
        }
    }
    r.innerHTML = res.join('<br>');
}