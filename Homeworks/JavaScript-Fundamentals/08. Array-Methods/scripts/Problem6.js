//Problem 6

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
    createPerson('Rickon', 'Stark', 6, false),
    createPerson('Benjen', 'Stark', 42, false)];

var result = people.sort(function(x, y){
    return x.firstname > y.firstname;
})
    .reduce(function (obj, item) {

    if (obj[item.firstname[0]]) {
        obj[item.firstname[0]].push(item);
    } else {
        obj[item.firstname[0]] = [item];
    }
    return obj;
}, {});

console.log('Problem 6:');
console.log(result);
console.log('\n');