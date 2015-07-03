


<!DOCTYPE html>
<html lang="en" class=" is-copy-enabled">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    <meta name="viewport" content="width=1020">
    
    
    <title>JavaScript-OOP/README.md at master · TelerikAcademy/JavaScript-OOP</title>
    
  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
   
<h1></h1>

<h3><a id="user-content-task-1" class="anchor" href="#task-1" aria-hidden="true"><span class="octicon octicon-link"></span></a>Task 1.</h3>

<ul>
<li>Create a module for a <code>Telerik Academy course</code>

<ul>
<li>The course has a <code>title</code> and <code>presentations</code>

<ul>
<li>Each presentation also has a <code>title</code></li>
<li>There is a homework for each presentation</li>
</ul></li>
<li>There is a set of students listed for the course

<ul>
<li>Each student has <code>firstname</code>, <code>lastname</code> and an <code>ID</code>

<ul>
<li>IDs must be unique integer numbers which are at least 1</li>
</ul></li>
</ul></li>
<li>Each student can submit a homework for each presentation in the course</li>
<li>Create method <code>init()</code>

<ul>
<li>Accepts a <code>string</code> - course title</li>
<li>Accepts an <code>array of strings</code> - presentation titles</li>
<li>Throws if there is an invalid title

<ul>
<li>Titles do not start or end with spaces</li>
<li>Titles do not have consecutive spaces</li>
<li>Titles have at least one character</li>
</ul></li>
<li>Throws if there are no presentations</li>
</ul></li>
<li>Create method <code>addStudent()</code> which lists a student for the course

<ul>
<li>Accepts a string in the format <code>'Firstname Lastname'</code></li>
<li>Throws if any of the names are not valid

<ul>
<li>Names start with an upper case letter</li>
<li>All other symbols in the name (if any) are lowercase letters</li>
</ul></li>
<li>Generates a unique student ID and returns it</li>
</ul></li>
<li>Create method <code>getAllStudents()</code> that returns an array of students in the format:

<ul>
<li>{firstname: 'string', lastname: 'string', id: StudentID}</li>
</ul></li>
<li>Create method <code>submitHomework()</code>

<ul>
<li>Accepts <code>studentID</code> and <code>homeworkID</code>

<ul>
<li>homeworkID 1 is for the first presentation</li>
<li>homeworkID 2 is for the second one</li>
<li>...</li>
</ul></li>
<li>Throws if any of the IDs are invalid</li>
</ul></li>
<li>Create method <code>pushExamResults()</code>

<ul>
<li>Accepts an array of items in the format <code>{StudentID: ..., Score: ...}</code>

<ul>
<li>StudentIDs which are not listed get 0 points</li>
</ul></li>
<li>Throw if there is an invalid StudentID</li>
<li>Throw if same StudentID is given more than once ( he tried to cheat (: )</li>
<li>Throw if Score is not a number</li>
</ul></li>
<li>Create method <code>getTopStudents()</code> which returns an array of the top <strong>10 performing students</strong>

<ul>
<li>Array must be sorted from <strong>best to worst</strong></li>
<li>If there are less than 10, return them all</li>
<li>The final score that is used to calculate the top performing students is done as follows:

<ul>
<li>75% of the exam result</li>
<li>25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course</li>
</ul></li>
</ul></li>
</ul></li>
</ul>
</article>
  </div>

</div>
  </body>
</html>

