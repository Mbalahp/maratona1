function mostrar() {
    var mult = [];
    for (var i = 7; i < 1000; i += 7) {
        mult.push(i);
    }
    document.getElementById('res').innerText = mult.join(', ');
}