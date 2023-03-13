// JavaScript source code

//q1
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};

let sum = 0;

for (let key in salaries) {
    sum += salaries[key];
}

console.log(sum); // Output: 390



//q2

function multiplynumeric(obj) {
    for (let key in obj) {
        if (typeof obj[key] === 'number') {
            obj[key] *= 2;
        }
    }
}



//q3
function checkEmailId(str) {
    // convert the string to lowercase to make it case-insensitive
    str = str.toLowerCase();

    // check if the string contains '@' and '.'
    if (str.includes('@') && str.includes('.')) {
        // get the index of '@' and '.'
        const atIndex = str.indexOf('@');
        const dotIndex = str.indexOf('.');

        // check if '@' appears before '.'
        if (atIndex < dotIndex) {
            // check if there are some characters between '@' and '.'
            if (dotIndex - atIndex > 1) {
                return true;
            }
        }
    }

    return false;
}




//q4
function truncate(str, maxlength) {
    if (str.length > maxlength) {
        return str.slice(0, maxlength - 3) + "...";
    }
    return str;
}


//q5
let styles = ['James', 'Brennie'];
console.log(styles);

styles.push('Robert');
console.log(styles);

let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = 'Calvin';
console.log(styles);

let removedValue = styles.shift();
console.log(removedValue);
console.log(styles);

styles.unshift('Rose', 'Regal');
console.log(styles);




