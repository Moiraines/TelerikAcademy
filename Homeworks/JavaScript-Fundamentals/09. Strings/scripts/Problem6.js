//Problem 6

var input = '<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body>	</html>';

function extractText(text){
    var inTag = false,
        outTag = false,
        result = "";

    for(i = 0; i < text.length; i+=1)
    {
        if (text.substr(i, 1) === "<")
        {
            inTag = true;
            outTag = false;
        }
        else if(text.substr(i, 1) === ">")
        {
            inTag = false;
            outTag = true;
        }
        else
        {
            if(inTag === false)
            {
                result = result + text.substr(i, 1);
            }
        }
    }
    return result;

}

console.log('Problem 6: ');
console.log('Result: ');
console.log(extractText(input));
console.log('\n');