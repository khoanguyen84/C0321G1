const step = 5;
const side1 = '50px';
const side2 = '100px';

let setting = confirm('do you want to use keyboard?')
if(setting == true){
    document.getElementsByTagName('body')[0].addEventListener('keydown', controlCar);
}

setInterval(
    function(){
        document.getElementsByTagName('body')[0].removeEventListener('keydown', controlCar);
    }
    , 5*1000);


function init(){
    let car = document.getElementById('car');
    car.src = 'images/right.png';
    car.style.width = side2;
    car.style.height = side1;
    car.style.position ='relative';
    car.style.left = '0px';
    car.style.top = '0px';
    // window.addEventListener('keydown', controlCar)

}

function moveToRight(){
    let car = document.getElementById('car');
    let leftPos = parseInt(car.style.left);
    car.src = 'images/right.png';
    car.style.width = side2;
    car.style.height = side1;
    if(leftPos + parseInt(side2) + step < window.innerWidth){
        car.style.left = `${leftPos + step}px`;
    }
    
}
function moveToLeft(){
    let car = document.getElementById('car');
    let leftPos = parseInt(car.style.left);
    car.src = 'images/left.png';
    car.style.width = side2;
    car.style.height = side1;
    if(leftPos > 0){
        car.style.left = `${leftPos - step}px`;
    }
    
}

function moveToDown() {
    let car = document.getElementById('car');
    let topPos = parseInt(car.style.top);
    car.src = 'images/down.png';
    car.style.width = side1;
    car.style.height = side2;
    if(topPos + parseInt(side2) + step < window.innerHeight){
        car.style.top = `${parseInt(car.style.top) + step}px`;
    }
}

function moveToUp() {
    let car = document.getElementById('car');
    let topPos = parseInt(car.style.top);
    car.src = 'images/up.png';
    car.style.width = side1;
    car.style.height = side2;
    if(topPos >0){
        car.style.top = `${parseInt(car.style.top) - step}px`;
    }
}

function controlCar(event) {
    switch(event.keyCode){
        case 39:{
            moveToRight();
            break;
        }
        case 40:{
            moveToDown();
            break;
        }
        case 38:{
            moveToUp();
            break;
        }
        case 37:{
            moveToLeft();
            break;
        }
        default:{
            alert(`please using one in four keys { left, right, up and down }`);
        }
    }
}   