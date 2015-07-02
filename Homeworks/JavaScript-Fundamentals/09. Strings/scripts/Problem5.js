//Problem 5

var text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. " +
        "So we are drinking all the day. We will move out of it in 5 days.";

function replaceWhiteSpaces(text){
    text = text.replace(/ /g, '&nbsp');
    return text;
}

console.log('Problem 5: ');
console.log('Result: ');
console.log(replaceWhiteSpaces(text));
console.log('\n');
