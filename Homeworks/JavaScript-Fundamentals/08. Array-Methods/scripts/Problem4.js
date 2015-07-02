//Problem 4

function createPerson(fname, lname, age, gender) {
    return {
        firstname: fname,
        lastname: lname,
        age: age,
        gender: !gender ? 'male' : 'female'
    };
}

var people = [createPerson('Eddard', 'Stark', 45, false),
    createPerson('Catelyn', 'Tully', 43, true),
    createPerson('Robb', 'Stark', 18, false),
    createPerson('Sansa', 'Stark', 16, true),
    createPerson('Arya', 'Stark', 13, true),
    createPerson('Bran', 'Stark', 11, false),
    createPerson('Rickon', 'Stark', 6, false)];

var women = people.filter(function(person){
    if (person.gender === 'female'){
        return person;
    }
}),
    result = women.reduce(function(sum, woman){
        var len = women.length;
        return (sum + woman.age / len);
    }, 0);

console.log('Problem 4:');
console.log('Average age of women in the array is: ' + result);
console.log('\n');