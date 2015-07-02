//Problem 4
function OrderByDescending(a, b, c){
    if (a > b && a > c)
    {
        if (b > c)
        {
            console.log(a + ' ' + b + ' ' + c);
        }
        else
        {
            console.log(a + ' ' + c + ' ' + b);
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            console.log(b + ' ' + a + ' ' + c);
        }
        else
        {
            console.log(b + ' ' + c + ' ' + a);
        }
    }
    else if (c > a && c > b)
    {
        if (a >b)
        {
            console.log(c + ' ' + a + ' ' + b);
        }
        else
        {
            console.log(c + ' ' + b + ' ' + a);
        }
    }

    if (a == b && b == c)
    {
        console.log(a + ' ' + a + ' ' + a);
    }

}
console.log('Problem 4:');
console.log('Results:');
OrderByDescending(5, 2, 2);
OrderByDescending(-2, -2, 1);
OrderByDescending(-2, 4, 3);
OrderByDescending(0, -2.5, 5);
OrderByDescending(-0.1, -0.5, -1.1);
OrderByDescending(10, 20, 30);
OrderByDescending(1, 1, 1);
console.log('\n');
