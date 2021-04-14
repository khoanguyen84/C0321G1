let date = new Date();
let now = date.toISOString().split("T")[0];
document.getElementById('checkin').value = now;
document.getElementById('checkout').value = now;
function payment(){
    let checkin_Date = new Date(document.getElementById('checkin').value);
    let checkout_Date = new Date(document.getElementById('checkout').value);
    let miliseconds = checkout_Date.getTime() - checkin_Date.getTime();
    let total_days = miliseconds/(24*60*60*1000);

    // 
    let roomTypes = document.getElementById('roomType');
    // let roomType = roomTypes.options[roomTypes.selectedIndex].text;
    let price = parseInt(roomTypes.value);

    let weeks = Math.floor(total_days/7);
    let days = total_days%7;
    let amount = 0;
    if(weeks == 0){
        amount = price * total_days;
        document.getElementById('amount').innerText = `You lives ${total_days} days and you have to pay: ${amount.toLocaleString('it-IT', { style: 'currency', currency: 'VND' })}`;
    }
    else{
        amount = weeks*7*0.9*price + days*price;
        document.getElementById('amount').innerText = `You lives ${weeks} weeks and ${days} days and you have to pay: ${amount.toLocaleString('it-IT', { style: 'currency', currency: 'VND' })}`;
    }
}