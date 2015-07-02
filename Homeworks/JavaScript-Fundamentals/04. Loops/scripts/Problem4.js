//Problem 4
var smallest,
    largest,
    prop;

function DocumentSort(){
    smallest = 'zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz';
    largest = '';
    for (prop in document){
        if (prop < smallest){
            smallest = prop;
        }

        if (prop > largest){
            largest = prop;
        }
    }
    console.log('Document:\nSmallest prop = ' + smallest + '\nLargest prop = ' + largest);
    console.log('\n');
}

function WindowSort(){
    smallest = 'zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz';
    largest = '';
    for (prop in window){
        if (prop < smallest){
            smallest = prop;
        }

        if (prop > largest){
            largest = prop;
        }
    }
    console.log('Window:\nSmallest prop = ' + smallest + '\nLargest prop = ' + largest);
    console.log('\n');
}

function NavigatorSort(){
    smallest = 'zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz';
    largest = '';
    for (prop in navigator){
        if (prop < smallest){
            smallest = prop;
        }

        if (prop > largest){
            largest = prop;
        }
    }
    console.log('Navigator:\nSmallest prop = ' + smallest + '\nLargest prop = ' + largest);
    console.log('\n');
}
console.log('Problem 4:');
DocumentSort();
WindowSort();
NavigatorSort();