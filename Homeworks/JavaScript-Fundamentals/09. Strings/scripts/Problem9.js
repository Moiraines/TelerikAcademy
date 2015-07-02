//Problem 9

var input = 'This is our mail: fens@abv.bg. Please lyubomir@com@alabala.bg use it instead of culture@abv.bg, ' +
    'since it is our old one. This is fake mail: com.yahoo@office';

if (!String.prototype.contains) {
    String.prototype.contains = function (searchPattern) {

        var patternLen = searchPattern.length;

        for (var i = 0, length = this.length - patternLen; i < length; i++) {

            var isMatch = true;

            for (var j = 0; j < patternLen; j++) {

                if (searchPattern[j] !== this[i + j]) {

                    isMatch = false;

                    break;

                }

            }

            if (isMatch) {

                return true;

            }

        }

    }
}

function extractEmail(text){
    var i,
        arr = text.split(/,| /),
        len = arr.length,
        result = [];

    for (i = 0; i < len; i+=1)
    {
        if (arr[i].contains('@') && arr[i].indexOf('@') === arr[i].lastIndexOf('@'))
        {
            if (arr[i][arr[i].length - 1] === ('.'))
            {
                arr[i] = arr[i].substr(0, arr[i].length - 1);
            }

            if (arr[i].contains('.') && arr[i].indexOf('@') < arr[i].indexOf('.'))
            {
                result.push(arr[i]);
            }
        }
    }
    return result.join(', ');
}

console.log('Problem 9: ');
console.log('Result: ');
console.log(extractEmail(input));
console.log('\n');