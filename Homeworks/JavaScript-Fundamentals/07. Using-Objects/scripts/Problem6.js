//Problem 6

var doncho = new Person('Doncho', 'Minkov', 27),
    ivo = new Person('Ivaylo', 'Kenov', 26),
    niki = new Person('Nikolay', 'Kostov', 24),
    evlogi = new Person('Evlogi', 'Hristov', 29),
    evlogiSecond = new Person('Evlogi', 'Kostov', 27),
    people = [doncho, ivo, niki, evlogi, evlogiSecond];

function Person(fname, lname, age) {
    return {
        FirstName: fname,
        LastName: lname,
        Age: age
    }
}

function groupPeople(array, key){
    var groupArr = {},
        i;

    for(i in array) {
        var groupProperty = array[i][key];

        if (!groupArr.hasOwnProperty(groupProperty)) {
            groupArr[groupProperty] = [];
        }

        groupArr[groupProperty].push(array[i]);
    }

    return groupArr;
}

console.log('Problem 6:');
var groupedByAge = groupPeople(people, 'Age');
console.log('Grouped by Age:')
console.log(groupedByAge);
var groupedByFirstname = groupPeople(people, 'FirstName');
console.log('Grouped by First name:')
console.log(groupedByFirstname);
var groupedByLastName = groupPeople(people, 'LastName');
console.log('Grouped by Last name:')
console.log(groupedByLastName);