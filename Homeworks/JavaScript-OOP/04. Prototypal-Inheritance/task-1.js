/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {
        var domElement = {};

        function attributesParser(arr) {
            var stringResult = '';
            var keys = [];

            for(var key in arr){
                keys.push(key);
            }

            keys.sort();
            var currentKey;

            for(var ind = 0, len = keys.length; ind < len; ind += 1){
                currentKey = keys[ind];
                stringResult += ' ' + currentKey + '="' + arr[currentKey] + '"';
            }

            return stringResult;
        }

        function hasChildren(children) {
            return !!children.length;
        }

        function validateType(type) {
            if(!/^[A-Za-z0-9]+$/i.test(type) || type === '') {
                throw new Error('Invalid type syntax');
            }
        }

        function validateAttribute(attribute) {
            if(!/^[A-Za-z0-9\-]+$/i.test(attribute) || attribute === '') {
                throw new Error('Invalid attribute');
            }
        }

        Object.defineProperty(domElement, 'init', {
            value: function(type) {
                this.type = type;
                this.attributes = [];
                this.children = [];
                this.parent;
                this.content = '';

                return this;
            }
        });
        Object.defineProperty(domElement, 'type', {
            get: function() {
                return this._type;
            },
            set: function(value) {
                validateType(value);
                this._type = value;
            }
        });
        Object.defineProperty(domElement, 'innerHTML', {
            get: function() {
                var i,
                    len,
                    resultHTML = '<' + this.type;
                resultHTML += attributesParser(this.attributes);
                resultHTML += '>';

                if(hasChildren(this.children)) {
                    for (i = 0, len = this.children.length; i < len; i+=1) {
                        if(typeof this.children[i] !== 'string'){
                            resultHTML+= this.children[i].innerHTML;
                        }
                        else {
                            resultHTML+= this.children[i];
                        }
                    }
                }
                else {
                    resultHTML += this.content;
                }

                resultHTML += '</' + this.type + '>';
                return resultHTML;
            }
        });
        Object.defineProperty(domElement, 'content', {
            get: function() {
                return this._content;
            },
            set: function(value) {
                if(hasChildren(this.children)) {
                    this._content = '';
                }
                else {
                    this._content = value;
                }
            }
        });
        Object.defineProperty(domElement, 'attributes', {
            get: function() {
                return this._attributes;
            },
            set: function(value) {
                this._attributes = value;
            }
        });
        Object.defineProperty(domElement, 'children', {
            get: function() {
                return this._children;
            },
            set: function(value) {
                this._children = value;
            }
        });
        Object.defineProperty(domElement, 'parent', {
            get: function() {
                return this._parent;
            },
            set: function(value) {
                this._parent = value;
            }
        });
        Object.defineProperty(domElement, 'appendChild', {
            value: function(child) {
                this.children.push(child);
                if (typeof child !== 'string'){
                    child.parent = this;
                }
                return this;
            }
        });
        Object.defineProperty(domElement, 'addAttribute', {
            value: function(name, value) {
                if (arguments.length !== 2) {
                    throw new Error('Invalid attribute input');
                }
                validateAttribute(name);
                this.attributes[name] = value;
                return this;
            }
        });
        Object.defineProperty(domElement, 'removeAttribute', {
            value: function(attribute) {
                if (this.attributes[attribute]) {
                    delete this.attributes[attribute];
                }
                else {
                    throw new Error('This attribute does not exist');
                }
                return this;
            }
        });

        return domElement;
    } ());
    return domElement;
}

module.exports = solve;

var domElement = solve();
var meta = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
    .init('head')
    .appendChild(meta);

var div = Object.create(domElement)
    .init('div')
    .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
    .init('body')
    .appendChild(div)
    .addAttribute('id', 'myid')
    .addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
    .init('html')
    .appendChild(head)
    .appendChild(body);

console.log(root.innerHTML);

