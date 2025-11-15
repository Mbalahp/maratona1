function o() {
    let n1 = parseFloat(document.getElementById('n1').value);
    let n2 = parseFloat(document.getElementById('n2').value);
    let n3 = parseFloat(document.getElementById('n3').value);
    let r = document.getElementById('r');

    let nums = [n1, n2, n3];
    nums.sort((a, b) => a - b);

    r.innerText = 'Menor: ' + nums[0] + ', Intermediário: ' + nums[1] + ', Maior: ' + nums[2];
}