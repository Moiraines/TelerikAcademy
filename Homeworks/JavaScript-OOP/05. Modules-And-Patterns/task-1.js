/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    var students = [],
        studentsHomework = [],
        studentsScores = [],
        studentsFinal = [],
        studentInd = 0,
        cheatInspector = [];

    function createFinalArr() {
        var examPartValue,
            homeworkPartValue,
            isSeen,
            tempObj;
        for(key of students) {
            isSeen = false;
            for(student of studentsScores) {
                if(key.id === student.StudentID) {
                    isSeen = true;
                    examPartValue = 0.75 * student.score;
                    tempObj = {ID: key.id, FirstName: key.firstname, LastName: key.lastname, TotalScore: examPartValue};
                    studentsFinal.push(tempObj);
                    break;
                }
            }
            if(isSeen === false) {
                studentsFinal.push({ID: key.id, FirstName: key.firstname, LastName: key.lastname, TotalScore: 0});
            }

            for(element of studentsHomework) {
                if(key.id === element.StudentID) {
                    homeworkPartValue = 0.25 * element.homeworkCount;
                    tempObj.TotalScore += homeworkPartValue;
                    break;
                }
            }
        }
    }

    function sortFinalArr() {
        studentsFinal.sort(function(a, b){
            return b.TotalScore - a.TotalScore;
        });

        return studentsFinal;
    }

    function studentsValidator(input) {
        if(typeof input !== 'number' || input <1 || input > studentInd) {
            throw Error('Invalid StudentID');
        }
    }

    function scoreValidator(input) {
        if(typeof input !== 'number') {
            throw Error('Invalid score');
        }
    }

    function integerChecker (value) {
            return typeof value === "number" &&
                isFinite(value) &&
                Math.floor(value) === value;
    }

    function iDValidator(ID, list) {
        if(!integerChecker(ID) || ID < 1 || ID > list.length) {
            throw Error('Invalid ID');
        }
    }

    function validateAndAddToArr(input) {
        if(typeof input !== 'string') {
            throw Error('Invalid student');
        }
        else{
            var arr = input.split(' ');
            if(arr.length !== 2) {
                throw Error('Invalid student');
            }
            else {
                var i,
                    j,
                    len,
                    len2,
                    word;

                for (i = 0, len = arr.length; i < len; i+=1) {
                    word = arr[i];
                    for (j = 0, len2 = word.length; j < len2; j+=1) {
                        if(j === 0 ) {
                            if (word.charCodeAt(j) < 65 || word.charCodeAt(j) > 90) {
                                throw Error('Invalid student');
                            }
                        }
                        else{
                            if(word.charCodeAt(j) < 97 || word.charCodeAt(j) > 122) {
                                throw Error('Invalid student');
                            }
                        }
                    }
                }
            }
        }
        studentInd +=1;

        var student = {
            firstname: arr[0],
            lastname: arr[1],
            id: studentInd
        };
        return student;
    }

    function validateTitle(title) {
        if(title.length < 1 || title === '' || title[0] === ' ' || title[(title.length)-1] === ' ' || title.match(/\s{2,}/)) {
            throw Error('Invalid course input');
        }
    }

    function validatePresentationTitle(presentations) {
        presentations.forEach(function (item){
            validateTitle(item);
        })
    }

    var Course = {

        init: function(title, presentations) {
            var tempArr = arguments;
            if(tempArr.length < 2 || tempArr[1].length < 1) {
                throw Error('Invalid course input');
            }

            validateTitle(title);
            this.title = title;
            validatePresentationTitle(presentations);
            this.presentations = presentations;

            return this;
        },
        addStudent: function(name) {
            var ID;
            students.push(validateAndAddToArr(name));
            ID = studentInd;
            return ID;
        },
        getAllStudents: function() {
            return students.slice();
        },
        submitHomework: function(studentID, homeworkID) {
            var hasSeen = false;
            iDValidator(studentID, students);
            iDValidator(homeworkID, this.presentations);
            for(element of studentsHomework){
                if(studentID === element.StudentID) {
                    hasSeen = true;
                    element.homeworkCount += homeworkID;
                    break;
                }
            }

            if(hasSeen === false) {
                studentsHomework.push({StudentID: studentID, homeworkCount: homeworkID});
            }

        },
        pushExamResults: function(results) {
            if(arguments.length === 0 || !Array.isArray(results)){
                throw Error('Invalid ExamResults');
            }
            for (var k = 0, len = results.length; k < len; k+=1) {
                var singleStudent = results[k];

                if(!singleStudent.hasOwnProperty('score')) {
                    throw Error('Invalid Score');
                }

                for(var key in singleStudent){
                    if(key === 'StudentID') {
                        if(cheatInspector.indexOf(singleStudent[key]) > -1) {
                            throw Error('This Student already exist');
                        }
                        else{
                            studentsValidator(singleStudent[key]);
                            cheatInspector.push(singleStudent[key]);
                        }
                    }
                    else{
                        scoreValidator(singleStudent[key]);
                    }
                }

                studentsScores.push(singleStudent);
            }
        },
        getTopStudents: function() {
            createFinalArr();
            return sortFinalArr().slice(0, 10);
        }
    };

    return Course;
}


module.exports = solve;

//Example
var Course = solve();
var id, jsoop = Object.create(Course);
jsoop.init(getValidTitle(), [getValidTitle(), getValidTitle()]);
jsoop.addStudent('Doncho' + ' ' + 'Minkov');
id = jsoop.addStudent('Nikolay' + ' ' + 'Kostov');
jsoop.submitHomework(1, 1);
jsoop.submitHomework(2, 1);
jsoop.submitHomework(2, 2);
jsoop.pushExamResults([{StudentID:1,score:3},{StudentID:2, score:5}]);

var result = jsoop.getTopStudents();
console.log(result);

