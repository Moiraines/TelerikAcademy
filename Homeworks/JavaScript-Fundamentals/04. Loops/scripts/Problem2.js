//Problem 2
function PrintNotDivisible(n){
    for (var i = 1; i <=n; i += 1){
        if ((i % 3) && (i % 7)){
            console.log(i);
        }
    }
    console.log('\n');
}



console.log('Problem 2:');
console.log('Examples with 10 and 50:');
PrintNotDivisible(10);
PrintNotDivisible(50);