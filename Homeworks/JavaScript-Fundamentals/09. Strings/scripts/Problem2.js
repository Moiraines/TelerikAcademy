//Problem 2

function checkBrackets(input){
    var stack = [],
        i,
        len = input.length;

    for (i = 0; i < len; i+=1){
        if (input[i] === '('){
            stack.push(input[i]);
        }
        else if (input[i] === ')'){
            if (stack[stack.length-1] === '('){
                stack.pop();
            }
            else{
                return 'No';
            }
        }
    }

    if (!(stack.length)) {
        return 'Yes';
    }
    else{
        return 'No';
    }
}

console.log('Problem 2: ');
console.log('Is "((a+b)/5-d)" a correct expression: ' + checkBrackets('((a+b)/5-d)'));
console.log('Is ")(a+b))" a correct expression: ' + checkBrackets(')(a+b))'));
console.log('\n');
