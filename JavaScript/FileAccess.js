const fs = require('node:fs');

const fileData = fs.readFileSync("Hello.txt", "utf8");
console.log(fileData);
