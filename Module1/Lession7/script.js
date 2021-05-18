// let inputs = document.getElementsByTagName('input');


// inputs[3].addEventListener('click', rank);

function rank(){
    // let toan = parseInt(inputs[0].value);
    // let ly = parseInt(inputs[1].value);
    // let hoa = parseInt(inputs[2].value);

    let toan = parseInt(document.getElementById('toan').value);
    let ly = parseInt(document.getElementById('ly').value);
    let hoa = parseInt(document.getElementById('hoa').value);
    let dtb = (toan + ly + hoa)/3
    let p = document.getElementsByTagName('p')[0];
    let xeploai ='';
    if(dtb < 5)
        xeploai = 'Yếu';
    if(dtb >=5)
        xeploai = "TB";
    if(dtb >=7)
        xeploai = "Khá";
    if(dtb >=8)
        xeploai = "Giỏi";
    if(dtb >=9)
        xeploai = "XS";
    p.innerHTML = `Xếp loại: ${xeploai}`;
}