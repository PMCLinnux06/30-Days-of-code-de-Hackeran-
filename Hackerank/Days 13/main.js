'use strict';

class Book {
    constructor(title, author) {
        if (this.constructor === Book) {
            throw new TypeError("Do not attempt to directly instantiate an abstract class.");
        }

        this.title = title;
        this.author = author;
    }

    display() {
        throw new Error("Method 'display()' must be implemented.");
    }
}

class MyBook extends Book {

    constructor(title, author, price) {
        super(title, author);
        this.price = price;
    }

    display() {
        console.log("Title: " + this.title);
        console.log("Author: " + this.author);
        console.log("Price: " + this.price);
    }
}

const title = "The Alchemist";
const author = "Paulo Coelho";
const price = 248;

const book = new MyBook(title, author, price);
book.display();