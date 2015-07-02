//Problem 8

function AreaCalculation(sideA, sideB, height){
    var area = ((sideA + sideB)/ 2 )* height;

    return (Math.round(area * 10000000)/ 10000000).toFixed(7);
}

console.log('Problem 8:');
console.log("Rectangle's Area is:", AreaCalculation(5, 7, 12));
console.log("Rectangle's Area is:", AreaCalculation(2, 1, 33));
console.log("Rectangle's Area is:", AreaCalculation(8.5, 4.3, 2.7));
console.log("Rectangle's Area is:", AreaCalculation(100, 200, 300));
console.log("Rectangle's Area is:", AreaCalculation(0.222, 0.333, 0.555));
console.log('\n');