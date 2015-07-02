//Problem 2

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
    createPerson('Sansa', 'Stark', 16, true)],
    result = people.some(function(person){
    return person.age < 18;
});

console.log('Problem 2:');
console.log(result? 'The array contains people under age of 18': 'This array contains only people of age 18 or greater');
console.log('\n');