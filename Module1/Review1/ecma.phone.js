class Contact{
    constructor(name, phoneNumber){
        this.name = name;
        this.phoneNumber = phoneNumber
    }
}

class PhoneBook{
    constructor(){
        this.contactList = [];
    }
    add(contact){
        this.contactList.push(contact);
    }

    check(name){
        for(let contact of this.contactList){
            if(contact.name.toLowerCase() == name.toLowerCase()){
                return contact;
            }
        }
        return null;
    }
    update(name, newPhone){
        let contact = this.check(name);
        if(contact != null){
            contact.phoneNumber = newPhone;
        }
    }

    remove(name){
        let contact = this.check(name);
        if(contact != null){
            let position = this.contactList.indexOf(contact);
            this.contactList.splice(position,1);
        }
    }

    search(name){
        let contact = this.check(name);
        if(contact != null){
            return contact;
        }

        return "Not exists";
    }
    showContacts(){
        let data = `<table border='1'>
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Phone number</th>
                        </tr>
                    </thead>
                    </tbody>`;
        for(let contact of this.contactList){
            data += `<tr>
                        <td>${contact.name}</td>
                        <td>${contact.phoneNumber}</td>
                    <tr>
                    `
        }

        data += "</tbody></table>";
        return data;
    }
}

let phoneBook = new PhoneBook();

function createContact(){
    let name = document.getElementById('name').value;
    let phoneNumber = document.getElementById('phonenumber').value;
    let contact = new Contact(name, phoneNumber);
    phoneBook.add(contact);
    reset();
    showContactList();
}

function reset(){
    document.getElementById('name').value = null;
    document.getElementById('phonenumber').value = null;
}
function showContactList(){
    document.getElementById('contactlist').innerHTML = phoneBook.showContacts();
}