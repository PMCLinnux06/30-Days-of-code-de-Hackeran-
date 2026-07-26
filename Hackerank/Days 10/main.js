'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');
    main();
});

function readLine() {
    return inputString[currentLine++];
}

function main() {
    const n = parseInt(readLine().trim(), 10);
    
    const binary = n.toString(2);
    const onesGroups = binary.split('0');
    let maxOnes = 0;

    for (let group of onesGroups) {
        if (group.length > maxOnes) {
            maxOnes = group.length;
        }
    }

    console.log(maxOnes);
}
