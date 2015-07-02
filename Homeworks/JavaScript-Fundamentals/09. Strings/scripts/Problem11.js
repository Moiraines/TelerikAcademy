//Problem 11

var frmt = '{0}, {1}, {0} text {2}';

function stringFormat(){
    var i,
        j,
        args,
        placeholder,
        text;
    args = [].slice.apply(arguments);
    text = args.shift();

    for (i = 1; i <= args.length; i+=1){
        placeholder = '{' + (i-1) + '}';
        for (j = 0; j < text.length; j+=1) {
            text = text.replace(placeholder, args[i-1]);
        }
    }

    return text;
}

console.log('Problem 11: ');
console.log('Result: ');
console.log(stringFormat('Hello {0}!', 'Peter'));
console.log(stringFormat(frmt, 1, 'Pesho', 'Gosho'));
console.log('\n');