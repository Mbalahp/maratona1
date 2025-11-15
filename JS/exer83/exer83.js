// a. Receber apenas números.
function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return true;
}

// b. Receber apenas texto.
function isTextKey(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if ((charCode >= 65 && charCode <= 90) || (charCode >= 97 && charCode <= 122) || charCode == 32) {
        return true;
    }
    return false;
}

// c. Receber apenas números pares.
function checkEven(input) {
    var num = parseInt(input.value);
    if (isNaN(num) || num % 2 != 0) {
        alert('Apenas números pares!');
        input.value = '';
    }
}

// d. Receber apenas vogais.
function isVowelKey(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    var char = String.fromCharCode(charCode).toLowerCase();
    var vogais = 'aeiou';
    if (vogais.indexOf(char) != -1) {
        return true;
    }
    return false;
}

// e. Receber apenas números primos.
function isPrime(num) {
    if (num <= 1) return false;
    for (var i = 2; i < num; i++) {
        if (num % i == 0) return false;
    }
    return true;
}

function checkPrime(input) {
    var num = parseInt(input.value);
    if (isNaN(num) || !isPrime(num)) {
        alert('Apenas números primos!');
        input.value = '';
    }
}

// f. Receber apenas valores que estão numa lista lida pelo programa.
var listaValores = ['apple', 'banana', 'orange']; // Exemplo de lista

function checkList(input) {
    var val = input.value.toLowerCase();
    if (listaValores.indexOf(val) == -1) {
        alert('Valor não está na lista permitida: ' + listaValores.join(', '));
        input.value = '';
    }
}
