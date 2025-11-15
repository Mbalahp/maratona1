function mostrarHora() {
    var data = new Date();
    var h = data.getHours();
    var m = data.getMinutes();
    var s = data.getSeconds();

    // Adicionar zero à esquerda se for menor que 10
    h = (h < 10) ? '0' + h : h;
    m = (m < 10) ? '0' + m : m;
    s = (s < 10) ? '0' + s : s;

    document.getElementById('hora').innerText = h + ':' + m + ':' + s;
}

// Atualizar a cada segundo
setInterval(mostrarHora, 1000);

// Mostrar a hora imediatamente ao carregar a página
mostrarHora();
