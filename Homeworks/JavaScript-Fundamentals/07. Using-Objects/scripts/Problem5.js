//Problem 5
var doncho = new Person('Doncho', 'Minkov', 27),
    ivo = new Person('Ivaylo', 'Kenov', 26),
    niki = new Person('Nikolay', 'Kostov', 24),
    evlogi = new Person('Evlogi', 'Hristov', 29),
    people = [doncho, ivo, niki, evlogi];

function Person(fname, lname, age) {
    return {
        FirstName: fname,
        LastName: lname,
        Age: age,
        toString: function personToString() {
            return this.FirstName + ' ' + this.LastName;
        }
    }
}

function YoungestPerson(array){
    var minAge = Number.MAX_VALUE,
        youngestPerson;

    for (var person of array){  //for-of loop is not recognizable in most browsers but still work fine for that Problem
        if (person.Age < minAge){
            minAge = person.Age;
            youngestPerson = person;
        }
    }
    return youngestPerson.toString();
}

console.log('Problem 5:');
console.log('Youngest person in the array is: ' + YoungestPerson(people));
console.log('\n');
