function calc() {
    var popA = 80000;
    var popB = 200000;
    var taxaA = 0.03;
    var taxaB = 0.015;
    var anos = 0;

    while (popA < popB) {
        popA = popA + (popA * taxaA);
        popB = popB + (popB * taxaB);
        anos++;
    }

    document.getElementById('res').innerText = 'Levará ' + anos + ' anos.';
}