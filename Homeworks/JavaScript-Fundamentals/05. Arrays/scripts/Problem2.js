//Problem 2

var arrFirst = ['a', 'f', 'a', 'x', 'd', 'j', 's'],
    arrSecond = ['a', 'b', 'c', 's', 'g', 'z', 'w'],
    arrThird = ['a', 'f', 'a', 'x', 'd', 'j', 's'],
    areEqual;

function LexicographicallyComparison (arr1, arr2){
    if (arr1.length !== arr2.length){
        areEqual = false;
    }
    else {
        areEqual = true;
        for ( var i = 0; i < arr1.length; i += 1){
            if (arr1[i] !== arr2[i]){
                areEqual = false;
                break;
            }
        }
    }

    console.log('Arrays are same -->' + areEqual);
}


console.log('Problem 2:');
console.log("Compare arrFirst = ['a', 'f', 'a', 'x', 'd', 'j', 's'] and arrSecond = ['a', 'b', 'c', 's', 'g', 'z', 'w'] ");
LexicographicallyComparison(arrFirst, arrSecond);
console.log("Compare arrFirst = ['a', 'f', 'a', 'x', 'd', 'j', 's'] and arrThird = ['a', 'f', 'a', 'x', 'd', 'j', 's'] ");
LexicographicallyComparison(arrFirst, arrThird);
console.log('\n');
