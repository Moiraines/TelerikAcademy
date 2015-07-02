//Problem 5

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

if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i+=1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}

var result = people.filter(function(person){
        if (person.gender === 'male'){
            return person;
        }
    })
    .sort(function(x, y){
        return x.age - y.age;
    })
    .find(function(man){
    return man;
});

console.log('Problem 5:');
console.log('The youngest male in array is: ' + result.firstname + ' ' + result.lastname + '. He is only on age of ' + result.age + '.');
console.log('\n');