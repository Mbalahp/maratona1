function v() {
    let x = parseInt(document.getElementById('x').value);
    let y = parseInt(document.getElementById('y').value);
    let z = parseInt(document.getElementById('z').value);
    let r = document.getElementById('r');

    if (x + y > z && x + z > y && y + z > x) {
        if (x === y && y === z) {
            r.innerText = 'Equilátero';
        } else if (x === y || x === z || y === z) {
            r.innerText = 'Isósceles';
        } else {
            r.innerText = 'Escaleno';
        }
    } else {
        r.innerText = 'Não forma um triângulo';
    }
}