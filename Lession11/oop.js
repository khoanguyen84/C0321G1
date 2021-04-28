let khoa = {}; //empty object

khoa.fristName = "Khoa";
khoa.lastName = "Nguyễn";
khoa.age = 18;

khoa.greeting = function(){
    return `Fullname: ${this.fristName} ${this.lastName}, Age: ${this.age}`;
}


let buu = {
    fristName: "Bữu",
    lastName: "Nguyễn",
    age : 18,
    greeting : function(){
        return `Fullname: ${this.fristName} ${this.lastName}, Age: ${this.age}`;
    },
    adult: function(){
        return `${this.age >= 18 ? 'adult' : 'Kid'}`;
    }
}

document.getElementsByTagName('h3')[0].innerHTML = buu.greeting();


khoa.adult = function(){
    return `${this.age >= 18 ? 'adult' : 'Kid'}`;
}

function Student(){
    this.fristName,
    this.lastName,
    this.age,
    this.phone,

    this.setPhone = function(phone){
        this.phone = phone;
    }
    this.getPhone = function(){
        return `${this.phone.substring(0, this.phone.length -3)}XXX` 
    }
    this.setFirstname = function(fristName){
        this.fristName = fristName.toUpperCase();
    }
    this.setLastname = function(lastName){
        this.lastName = lastName.toUpperCase();
    }
    this.setAge = function(age){
        this.age = age;
    }
    this.greeting = function(){
        return `Fullname: ${this.fristName} ${this.lastName}, Age: ${this.age}`;
    },
    this.adult = function(){
        return `${this.age >= 18 ? 'adult' : 'Kid'}`;
    }
}

let thanh = new Student();
thanh.setFirstname('Thanh');
thanh.setLastname('Hồ');
thanh.setAge(18);
thanh.setPhone('0935737475');

let hung = new Student();
hung.setFirstname('Hùng');
hung.setLastname('Nguyễn');
hung.setAge(19);

function Person(fristName, lastName, age, email){
    this.fristName = fristName,
    this.lastName = lastName,
    this.age = age,
    this.email = email,
    this.greeting = function(){
        return `Fullname: ${this.fristName} ${this.lastName}, Age: ${this.age}, Email: ${this.email}`;
    }
}

let long = new Person("Long", "Phạm", 18, "long.phan@codegym.vn");
let duy = new Person("Duy", "Trần", 18, "duy.tran@codegym.vn");