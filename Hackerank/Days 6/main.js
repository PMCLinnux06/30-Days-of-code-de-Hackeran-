const fs = require('fs');

function main() {
    const input = fs.readFileSync('/dev/stdin', 'utf-8');
    const lines = input.trim().split('\n');
    
    if (lines.length === 0 || lines[0].trim() === "") return;
    
    const t = parseInt(lines[0].trim(), 10);
    
    for (let i = 1; i <= t && i < lines.length; i++) {
        const palabra = lines[i].trim();
        let pares = "";
        let impares = "";
        
        for (let j = 0; j < palabra.length; j++) {
            if (j % 2 === 0) {
                pares += palabra[j];
            } else {
                impares += palabra[j];
            }
        }
        
        console.log(`${pares} ${impares}`);
    }
}

main();