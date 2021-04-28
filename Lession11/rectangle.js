function Rectangle(){
    this.width,
    this.height,
    this.setWidth = function(width){
        this.width = width;
    }
    this.setHeight = function(height){
        this.height = height;
    }
    this.getArea = function(){
        return (this.width + this.height)*2;
    }
    this.getPrimeter = function(){
        return this.width * this.height;
    }
}

function Rec(width, height){
    this.width = width,
    this.height = height,
    this.getArea = function(){
        return (this.width + this.height)*2;
    }
    this.getPrimeter = function(){
        return this.width * this.height;
    }
}

// let rec1 = new Rectangle();
// rec1.setHeight(200);
// rec1.setWidth(100);
// document.write(`Area: ${rec1.getArea()} <br>`);
// document.write(`Primeter: ${rec1.getPrimeter()} <br>`);



// let rec2 = new Rec(50,100);
// document.write(`Area: ${rec2.getArea()} <br>`);
// document.write(`Primeter: ${rec2.getPrimeter()} <br>`);

function calsArea(){
    let width = parseInt(document.getElementById('width').value);
    let height = parseInt(document.getElementById('height').value);
    let rec = new Rectangle();
    rec.setWidth(width);
    rec.setHeight(height);
    document.getElementById('result').innerHTML = `Area = ${rec.getArea()}`;
}

function calsPrimeter(){
    let width = parseInt(document.getElementById('width').value);
    let height = parseInt(document.getElementById('height').value);
    
    // let rec = new Rectangle();
    // rec.setWidth(width);
    // rec.setHeight(height);
    let rec = new Rec(width, height);
    document.getElementById('result').innerHTML = `Primeter = ${rec.getPrimeter()}`;
}