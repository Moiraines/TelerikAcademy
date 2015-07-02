//Problem 7

var input = 'http://telerikacademy.com/Courses/Courses/Details/239';

function buildURL(protocol, server, resource){
    return{
        protocol: protocol,
        server: server,
        resource: resource
    }
}

function parseURL(url){
    var i,
        result,
        protocol = '',
        server = '',
        resource = '',
        inProtocol = true,
        inServer = false,
        inResource = false;

    for (i = 0; i < url.length; i+=1)
    {

        if (url[i] == ':')
        {
            inProtocol = false;
        }

        if (url[i] == '/' && url[i-1] == '/')
        {
            inServer = true;
            continue;
        }
        else if (url[i] == '/' && inServer == true)
        {
            inServer = false;
            inResource = true;
        }

        if (inProtocol == true)
        {
            protocol += url[i];
        }

        if (inServer == true)
        {
            server += url[i];
        }

        if (inResource == true)
        {
            resource += url[i];
        }
    }

    result = buildURL(protocol, server, resource);

    return result;
}

console.log('Problem 7: ');
console.log('Result: ');
console.log(parseURL(input));
console.log('\n');