//Problem 3

function clone(obj) {
    var copy;

    // Handle the 3 simple types, and null or undefined
    if (null == obj || "object" != typeof obj) return obj;

    // Handle Date
    if (obj instanceof Date) {
        copy = new Date();
        copy.setTime(obj.getTime());
        return copy;
    }

    // Handle Array
    if (obj instanceof Array) {
        copy = [];
        for (var i = 0, len = obj.length; i < len; i++) {
            copy[i] = clone(obj[i]);
        }
        return copy;
    }

    // Handle Object
    if (obj instanceof Object) {
        copy = {};
        for (var attr in obj) {
            if (obj.hasOwnProperty(attr)) copy[attr] = clone(obj[attr]);
        }
        return copy;
    }

    throw new Error("Unable to copy obj! Its type isn't supported.");
}

var arr = [1, 2, 3, 4, 5, 6];
    arr2 = clone(arr);

arr2[0] = 8;
console.log('Problem 3:');
console.log('Print two arrays, after change first element of the cloned one: ');
console.log("Original: ");
console.log(arr);
console.log("Cloned: ");
console.log(arr2);
console.log('\n');










