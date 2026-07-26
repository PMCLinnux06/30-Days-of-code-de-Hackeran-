'use strict';

class Person {
    constructor(firstName, lastName, idNumber) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.idNumber = idNumber;
    }

    printPerson() {
        console.log(`Name: ${this.lastName}, ${this.firstName}`);
        console.log(`ID: ${this.idNumber}`);
    }
}

class Student extends Person {
    constructor(firstName, lastName, idNumber, scores) {
        super(firstName, lastName, idNumber);
        this.scores = scores;
    }

    calculate() {
        let sum = this.scores.reduce((a, b) => a + b, 0);
        let avg = sum / this.scores.length;

        if (avg >= 90 && avg <= 100) return 'O';
        if (avg >= 80 && avg < 90) return 'E';
        if (avg >= 70 && avg < 80) return 'A';
        if (avg >= 55 && avg < 70) return 'P';
        if (avg >= 40 && avg < 55) return 'D';
        return 'T';
    }
}

const fs = require('fs');
const input = fs.readFileSync('/dev/stdin', 'utf-8').trim().split('\n');

let line = input[0].split(' ');
let firstName = line[0];
let lastName = line[1];
let id = line[2];
let scores = input[2].split(' ').map(Number);

let s = new Student(firstName, lastName, id, scores);
s.printPerson();
console.log("Grade: " + s.calculate());