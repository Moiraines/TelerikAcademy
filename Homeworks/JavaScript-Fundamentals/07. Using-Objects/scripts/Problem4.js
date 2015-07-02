//Problem 4

function hasProperty(obj, property){
    if (!obj.hasOwnProperty(property)){
        return false;
    }
    else{
        return true;
    }
}

//Example

function buildPoint(X, Y) {
    return {
        X: X,
        Y: Y
    }

}var point1 = buildPoint(1, 2);

console.log('Problem 4:');
console.log('point 1 has property X: ' + hasProperty(point1, 'X'));
console.log('point 1 has property Z: ' + hasProperty(point1, 'Z'));
console.log('\n');
