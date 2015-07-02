//Problem 1

if (!String.prototype.format){
    String.prototype.format = function (options) {
        return this.replace(/#{(\w+)}/g, function ($0, $1) {
            return options[$1];
        });
    };
}

    var options1 = {name: 'John'},
        options2 = {name: 'John', age: 13};
        text = 'Hello, there! Are you #{name}?',
        text2 = 'My name is #{name} and I am #{age}-years-old.';
        text = text.format(options1);
        text2 = text2.format(options2);
console.log('Problem 1:');
console.log(text);
console.log(text2);
console.log('\n');