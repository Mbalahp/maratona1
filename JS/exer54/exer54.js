function calcular() {
    var chicoAlt = 1.50; // metros
    var zeAlt = 1.10;   // metros
    var anos = 0;

    while (zeAlt <= chicoAlt) {
        chicoAlt += 0.02; // 2 cm por ano
        zeAlt += 0.03;    // 3 cm por ano
        anos++;
    }

    document.getElementById('res').innerText = 'Serão necessários ' + anos + ' anos.';
}
