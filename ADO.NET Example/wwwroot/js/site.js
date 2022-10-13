// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.onload = function () {
    initListeners();
}

function initListeners() {
    // setup each node to listen to a mouse-click
    let courseCode = document.getElementsByTagName("td");
    let code=courseCode.
    for (let i = 0; i < courseCode.length; i++) {
        courseCode[i].addEventListener('click', onClick);
    }
}

function onClick(event) {

    if (
    }
    else if (currPen.id == "cornflower-pen") {
        event.target.style.background = cornflower;
        dbSetNodeColor(event.target.id, cornflower);
    }
}
