//Problem 3
var substring;

function SearchingWord(text, word, isCaseSensitive){
   if (!isCaseSensitive){
       word = word.toLowerCase();
       text = text.toLowerCase();
   }

    substring = text.split((word));
    return substring.length-1;
}

console.log('Problem 3:');
console.log('Occurrences of the word in the text is: ' + SearchingWord("The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.", 'We', true));
console.log('Occurrences of the word in the text is: ' + SearchingWord("The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.", 'We'));
console.log('\n');

