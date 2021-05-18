function Contact(name, phoneNumber){
    this.name = name;
    this.phoneNumber = phoneNumber;
}

function PhoneBook(){
    this.ContactList = [];

    this.add = function(contact){
        this.ContactList.push(contact);
    }

    this.check = function(name){
        // for(let i=0; i< this.ContactList.length ;i++){
        //     if(this.ContactList[i].name == name){
        //         return true;
        //     }
        // }
        for(let contact of this.ContactList){
            if(contact.name.toLowerCase() == name.toLowerCase()){
                return contact;
            }
        }
        return null;
    }

    this.update = function(name, newPhone){
        let contact = this.check(name);
        if(contact != null){
            contact.phoneNumber = newPhone;
        }
    }

    this.remove = function(name){
        let contact = this.check(name);
        if(contact != null){
            let position = this.ContactList.indexOf(contact);
            this.ContactList.splice(position,1);
        }
    }

    this.search = function(name){
        let contact = this.check(name);
        if(contact != null){
            return contact;
        }

        return "Not exists";
    }

    this.showContacts = function(){
        let data = `<table border='1'>
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Phone number</th>
                        </tr>
                    </thead>
                    </tbody>`;
        for(let contact of this.ContactList){
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
// let khoa = new Contact("Khoa", "0935216417");
// let thanh = new Contact("Thanh", "0935216417");

// phoneBook.add(khoa);
// phoneBook.add(thanh);

// document.write(phoneBook.showContacts());
