// let i=1;
// for(; i<=10;){
//     document.write(`<p>Số ${i}</p>`);
//     i++;
// }
// alert(i);

// for(let i=1;i<=10;i++){
//     if(i%2==0){
//         document.write(`<p>Số ${i}</p>`);
//     }      
// }

// for(let i=2;i<=10;i+=2){
//     document.write(`<p>Số ${i}</p>`);   
// }

// for(let i=1;i<=10;i++){
//     i++;
//     document.write(`<p>Số ${i}</p>`);   
// }

// for(let i=2;i<=10; i+=2){
//     if(i==8)
//         break;
//     document.write(`<p>Số ${i}</p>`);   
// }
// for(let i=2, count=0; i<=10 && count <3;i+=2){
//     count++;
//     document.write(`<p>Số ${i}</p>`);   
// }

// for(let i=1;i<=10;i++){
//     if(i%2!=0 || i>=8)
//         continue;
//     document.write(`<p>Số ${i}</p>`);   
// }

// for(let i=10;i>0;i--){
//     document.write(`<p>Số ${10 - i + 1}</p>`);   
// }

// for(let i=10;i>0;i--){
//     if(i%2==0){
//         document.write(`<p>Số ${10 - i + 2}</p>`);   
//     }
// }

// let i=1;
// let count =0;
// while(i<=10){
//     if(i%2==0){
//         count++;
//         document.write(`<p>Số ${i}</p>`);   
//     }
//     if(count>2){
//         break;
//     }
//     i++;
// }

// i=1;
// do{
//     if(i%2==0){
//         document.write(`<p>Số ${i}</p>`);   
//     }    
//     i++;
// }
// while(i<=10)

// let number = 0;
// do{
//     number = +prompt('Enter number:');
//     document.write(`<p>Số ${number}</p>`); 
// }
// while(number !=0)

// let number = +prompt('Enter number:');
// while(number !=0){
//     document.write(`<p>Số ${number}</p>`);
//     number = +prompt('Enter number:');
// }

// let number = +prompt('Enter number:');
// for(;number != 0;){
//     document.write(`<p>Số ${number}</p>`);
//     number = +prompt('Enter number:');
// }

// let number = 0;
// do{
//     number = Number(prompt('Enter number:'));
// }
// while(isNaN(number) || !Number.isInteger(number))

// let aveScore = 0;
// do{
//     aveScore = Number(prompt('Enter average score:'));
// }
// while(isNaN(aveScore) || aveScore <0 || aveScore >10);

// switch(Math.floor(aveScore)){
//     case 9:
//     case 10:{
//         alert('Xuất sắc');
//         break;
//     }
//     case 8:{
//         alert('Giỏi');
//         break;
//     }
//     case 7:{
//         alert('Khá');
//         break;
//     }
//     case 6:
//     case 5:{
//         alert('TB');
//         break;
//     }
//     default:{
//         alert('Yếu');
//         break;
//     }

// }

let table = '<table border="1">';

// let i=1, j=2;
// while(i<=10){
//     table += '<tr>';
//     j=2;
//     do{
//         table += `<td style='text-align:right;'>${j} x ${i} = ${i*j}</td>`;
//         j++;
//     }
//     while(j<10)
//     i++;
//     table += '</tr>';
// }
// for(let i=1;i<=10; i++){
//     table += '<tr>';
//     for(let j=2;j<10;j++){
//         table += `<td style='text-align:right;'>${j} x ${i} = ${i*j}</td>`;
//     }
//     table += '</tr>';
// }

for(let i=1;i<=10; i++){
    table += '<tr>';
    let j=2;
    do{
        table += `<td style='text-align:right;'>${j} x ${i} = ${i*j}</td>`;
        j++;
    }
    while(j<10)
    table += '</tr>';
}

table += '</table>';
document.write(table);