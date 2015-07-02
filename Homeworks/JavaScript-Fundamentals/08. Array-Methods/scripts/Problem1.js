//Problem 1

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
    createPerson('Robb', 'Stark', 18, false)];

console.log('Problem 1:');
people.forEach(function(person){
    console.log(person);
});
console.log('\n');
