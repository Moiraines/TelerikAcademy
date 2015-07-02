//Problem 10

var input = "The text is as follows: We ABBA are living in an yellow submarine. We don't have anything else. " +
    "Inside the submarine is exe very tight. So we are drinking all the lamal day. We will move out of it in 5 days.";

function extractPalindromes(text){
    var isPalindrome = true,
        i,
        j,
        arr = text.split(/,| /),
        len = arr.length,
        result = [];

    for (i = 0; i < len; i+=1)
    {
        for (j = 0; j < Math.floor(arr[i].length / 2); j++)
        {
            if (arr[i][j] != arr[i][arr[i].length - 1 -j])
            {
                isPalindrome = false;
                break;
            }
            else
            {
                isPalindrome = true;
            }
        }

        if (isPalindrome === true)
        {
            result.push(arr[i]);
        }
    }

    return result.join(', ');
}

console.log('Problem 10: ');
console.log('Result: ');
console.log(extractPalindromes(input));
console.log('\n');