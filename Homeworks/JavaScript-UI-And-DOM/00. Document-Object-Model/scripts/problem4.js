//Task 4
//*Write a script that shims querySelector and querySelectorAll in older browsers

(function() {
    'use strict';
    function querySelectorAll(selector) {
        switch(selector[0]) {
            case '.':
                return document.getElementsByClassName(selector.slice(1));
            case '#':
                return document.getElementById(selector.slice(1));
            default:
                return document.getElementsByTagName(selector);
        }
    }

    function querySelector(selector) {
        switch (selector[0]) {
            case '.':
                return document.getElementsByClassName(selector.slice(1))[0];
            case '#':
                return document.getElementById(selector.slice(1));
            default:
                return document.getElementsByTagName(selector)[0];
        }
    }

    if (typeof document.querySelector !== 'function') {
        document.querySelector = querySelector;
    }

    if (typeof document.querySelectorAll !== 'function') {
        document.querySelectorAll = querySelectorAll;
    }
})();