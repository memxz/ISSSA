let currPen = null;
const coral = "#ff7f50";
const cornflower = "#6495ed";

window.onload = function() {
    initListeners();
    restoreLast();
}

function initListeners() {
    // setup each node to listen to a mouse-click
    let nodes = document.getElementsByClassName("node");
    for (let i=0; i<nodes.length; i++) {
        nodes[i].addEventListener('click', onNodeClick);
    }

    // setup each color-pen to listen to a mouse-click
    let pens = document.getElementsByClassName("pen");
    for (let i=0; i<pens.length; i++) {
        pens[i].addEventListener('click', onPenClick);
    }
}

function onNodeClick(event) {
    if (currPen == null) {
        return;
    }

    if (currPen.id == "coral-pen") {
        event.target.style.background = coral; 
        localStorage[event.target.id] = coral;       
    }
    else if (currPen.id == "cornflower-pen") {
        event.target.style.background = cornflower;
        localStorage[event.target.id] = cornflower;
    }
}

function onPenClick(event) {
    if (currPen != null) {
        // remove border from previously selected pen
        currPen.classList.remove("selected-pen");
    }

    // remember last selected pen
    currPen = event.target;

    // have a border around selected pen
    currPen.classList.add("selected-pen");
}

function restoreLast() {
    for (let key in localStorage) {
        let node = document.getElementById(key);
        if (node) {
            node.style.background = localStorage[key];
        }
    }
}