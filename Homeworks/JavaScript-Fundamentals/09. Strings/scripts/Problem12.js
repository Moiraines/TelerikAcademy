//Problem 12

var people = [{name: 'Peter', age: 14}],
    template = '<strong>-{name}-</strong> <span>-{age}-</span>';
    peopleList = generateList(people, template);
function generateList(people, template) {
    var result = '',
        i;

    result += '<ul>';

    for (i = 0; i < people.length; i+=1){
        result += '<li>';
        result += (template.replace('-{name}-', people[i].name)).replace('-{age}-', people[i].age);
        result += '</li>';
    }

    result += '</ul>';

    return result;
}

console.log('Problem 12: ');
console.log('Result: ');
console.log(peopleList);
console.log('\n');