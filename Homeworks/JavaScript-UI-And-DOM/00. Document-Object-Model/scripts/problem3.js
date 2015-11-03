//Task 3
//Cråate a function that gets the value of <input type="color"> and sets the background of the body to this value

function onChangeBodyColorButtonClick() {
    'use strict';
    var color = document.querySelector('input[type=color]');

    document.body.style.backgroundColor = color.value;
}