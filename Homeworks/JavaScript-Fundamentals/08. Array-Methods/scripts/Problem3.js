//Problem 3

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


console.log('Problem 3:');
    people.filter(function(person){
    return person.age < 18;
})
    .forEach(function(person){
        console.log(person);
    });

console.log('\n');