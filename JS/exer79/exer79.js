function verificar() {
    var str1 = document.getElementById('str1').value.toLowerCase();
    var str2 = document.getElementById('str2').value.toLowerCase();
    var res = document.getElementById('res');

    var str1Invertida = str1.split('').reverse().join('');

    if (str1Invertida == str2) {
        res.innerText = 'As strings são palíndromas mútuas.';
    } else {
        res.innerText = 'As strings não são palíndromas mútuas.';
    }
}
