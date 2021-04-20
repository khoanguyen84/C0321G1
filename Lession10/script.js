let array = [];
let size = 15;
let min = 10;
let max = 90;
for(let i=0;i<size;i++){
    array[i] = Math.floor(Math.random()*(max-min + 1) + min);
}

let chars =["B","A","F","G","H","C"];

let arr = array.sort(function(n1,n2){
    return n2-n1;
})

// for(let index in array){
//     array[index]*=2;
// // }
// array.map(function(v,i){
//     return v*2;
// })
// document.write('------FOR IN-------<br>');
// for(let index in array){
//     document.write(`${index} - ${array[index]} <br>`);
// }

// document.write('------FOR OF-------<br>');

// for(let item of array){
//     document.write(`${array.indexOf(item)} - ${item}<br>`);
// }

// document.write('------FOR EACH-------<br>');
// array.forEach(function(value, index){
//     document.write(`${index} - ${value}<br>`);
// })