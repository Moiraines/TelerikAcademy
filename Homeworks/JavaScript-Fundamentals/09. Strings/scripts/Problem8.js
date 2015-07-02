//Problem 8

var input = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit' +
    ' <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceTags(text) {
    var result;

    result = text.replace(/<[^>]a>/g, '[/URL]');
    result = result.replace(/<a href=\"/g, '[URL=');
    result = result.replace(/\">/g, ']');
    return result;
}

console.log('Problem 8: ');
console.log('Result: ');
console.log(replaceTags(input));
console.log('\n');