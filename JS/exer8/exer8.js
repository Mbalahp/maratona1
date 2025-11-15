function f() {
    let r = document.getElementById('r');
    let res = [];
    for (let i = 1000; i <= 9999; i++) {
        let p1 = Math.floor(i / 100);
        let p2 = i % 100;
        let sum = p1 + p2;
        if (sum * sum === i) {
            res.push(i);
        }
    }
    r.innerText = res.join(', ');
}