function ord() {
    var nomesStr = document.getElementById('nomes').value;
    var res = document.getElementById('res');
    var nomes = nomesStr.split(',');
    
    for (var i = 0; i < nomes.length; i++) {
        nomes[i] = nomes[i].trim();
    }

    nomes.sort();

    res.innerText = nomes.join(', ');
}