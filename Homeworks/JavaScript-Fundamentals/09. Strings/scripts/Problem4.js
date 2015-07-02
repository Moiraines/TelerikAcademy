//Problem 4

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

function replaceTags(text){
    text = text.replace(/<\s*upcase\s*>/gi, '<U>');
    text = text.replace(/<\s*\/upcase\s*>/gi, '</U>');
    text = text.replace(/<\s*lowcase\s*>/gi, '<L>');
    text = text.replace(/<\s*\/lowcase\s*>/gi, '</L>');
    text = text.replace(/<\s*mixcase\s*>/gi, '<M>');
    text = text.replace(/<\s*\/mixcase\s*>/gi, '</M>');

    return text;
}

text = replaceTags(text);

function changeCaseInText(input){
    var arr = input.split(' '),
        startIndex,
        endIndex,
        segment,
        temp,
        i,
        len = arr.length,
        len2,
        result = [];

    for (i =0; i < len; i+=1){
        segment = arr[i];
        len2 = segment.length;
        startIndex = 0;
        endIndex = len2-1;

        if(segment[0] === '<'){
            startIndex = 3;
            if(segment[len2-1] === '>'){
                endIndex = len2-5;
            }
            segment = checkType(segment, segment[1], startIndex, endIndex)
        }
        else{
            if(segment[len2-1] === '>'){
                endIndex = len2-5;
                segment = checkType(segment, segment[segment.length-2], startIndex, endIndex);
            }
            if(segment[len2-2] === '>'){
                temp = segment[len2-1];
                endIndex = len2-6;
                segment = checkType(segment, segment[segment.length-3], startIndex, endIndex);
                segment += temp;
            }
        }

        result.push(segment);
    }

    return result.join(' ');
}

function checkType(input, tag, start, end){
    var segment = '',
        i,
        j,
        result = '';

    for (i = start; i <= end; i+=1){
        segment += input[i];
    }

    switch (tag) {
        case 'M':
        {
            for (j = 0; j < segment.length; j+=1){
                if (!Math.round(Math.random())){
                    result += segment[j].toLowerCase();
                }
                else{
                    result += segment[j].toUpperCase();
                }
            }

        }
            break;
        case 'U':
        {
            result += segment.toUpperCase();
        }
            break;
        case 'L':
        {
            result += segment.toLowerCase();
        }
            break;
    }

    return result;
}

console.log('Problem 4: ');
console.log(changeCaseInText(text));
console.log('\n');
