//Problem 2
var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

Array.prototype.removeAll = function (element){
    var i,
        length = this.length;

    for (i = 0; i < length; i+=1){
        if(this[i] === element){
            this.splice(i, 1);
            i-=1;
            length-=1;
        }

    }
}

console.log('Problem 2:');
arr.removeAll(1);
console.log('Result:');
console.log(arr);
console.log('\n');