function c() {
    let s = document.getElementById('s').value;
    let h = Math.floor(s / 3600);
    let m = Math.floor((s % 3600) / 60);
    let seg = s % 60;
    document.getElementById('r').innerText = h + 'h ' + m + 'm ' + seg + 's';
}