let sT;
let nR;

function s() {
    let t = Math.random() * 5000 + 1000; 
    setTimeout(() => {
        document.getElementById('w').innerText = 'Agora!';
        nR = Math.floor(Math.random() * 10);
        document.getElementById('n').innerText = nR;
        sT = new Date().getTime();
    }, t);
}

function c() {
    let eT = new Date().getTime();
    let iN = parseInt(document.getElementById('in').value);
    if (iN === nR) {
        let tT = (eT - sT) / 1000;
        document.getElementById('r').innerText = 'Tempo: ' + tT + 's';
    } else {
        document.getElementById('r').innerText = 'Número errado!';
    }
    document.getElementById('w').innerText = '';
    document.getElementById('n').innerText = '';
}