﻿/*
 Task 3. _ClickON_TheButton in JavaScript

Refactor the following examples to produce code with well-named identifiers in JavaScript

function _ClickON_TheButton( THE_event, argumenti) {
  var moqProzorec= window,
      brauzyra = moqProzorec.navigator.appCodeName,
      ism=brauzyra=="Mozilla";
  if(ism) {
    alert("Yes");
  } else {
    alert("No");
  }
}
 */

function browserCheck(event, input) {
    'use strict';
    var myWindow = window,
        browser = myWindow.navigator.appCodeName;

    if (browser === 'Mozilla') {
        alert('Yes');
    } else {
        alert('No');
    }
}