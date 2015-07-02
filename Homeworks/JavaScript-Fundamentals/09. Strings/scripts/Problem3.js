//Problem 3

var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. " +
    "So we are drinking all the day. We will move out of it in 5 days.",
    substring = 'in';

function subStrCount(text, substring){
   var insensitive = text.toLowerCase(),
       position = -1,
       counter = 0,
       index;
    while (true){
        index = insensitive.indexOf(substring, position+1);
        if (index <=-1){
            break;
        }
        position = index;
        counter +=1;
    }

    return counter;
}

console.log('Problem 3: ');
console.log('Result: ' + subStrCount(text, substring));
console.log('\n');