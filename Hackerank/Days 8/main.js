function processData(input) {
    const lines = input.trim().split('\n');
    const n = parseInt(lines[0]);

    const phoneBook = {};

    for (let i = 1; i <= n; i++) {
        const [name, number] = lines[i].trim().split(' ');
        phoneBook[name] = number;
    }

    for (let i = n + 1; i < lines.length; i++) {
        const query = lines[i].trim();

        if (phoneBook[query]) {
            console.log(`${query}=${phoneBook[query]}`);
        } else {
            console.log("Not found");
        }
    }
}

process.stdin.resume();
process.stdin.setEncoding("utf8");

let inputString = "";

process.stdin.on("data", function(input) {
    inputString += input;
});

process.stdin.on("end", function() {
    processData(inputString);
});