var stage, label, shape, circle;
var diameter = 10;
var added = 0;
var i = 0;
var array = new Array();

window.onload = init();

function init() {
   
    stage = new createjs.Stage("placeDots");
    stage.enableDOMEvents(true);

    shape = new createjs.Shape();
    stage.addChild(shape);

    circle = new createjs.Shape();
    circle.graphics.beginFill("blue").drawCircle(0, 0, diameter);


    stage.addEventListener("stagemousedown", function (event) {
        
            
        if (added == 1) {

            stage.update();
        }
        else {
            

            circle.x = event.stageX - (diameter / 2);
            circle.y = event.stageY - (diameter / 2);

            document.getElementById('dotX').value = parseInt(circle.x);
            document.getElementById('dotY').value = parseInt(circle.y);

            // circle.style.cursor = "pointer";
            circle.onmouseover = changeMouse();

            circle.addEventListener("mousedown", pressHandler);
            //  circle.addEventListener("mousedown", loadComment);
            stage.addChild(circle);
            added = 1;
        }


        //Update stage will render next frame
        stage.update();


    })

    stage.addEventListener("stagemousemove", function (evt) {

     /*   document.getElementById("xPos").innerHTML = evt.stageX;
        document.getElementById("yPos").innerHTML = evt.stageY;*/
    })

    stage.update();
}

function pressHandler(e) {

    e.onMouseMove = function (ev) {
        e.target.x = ev.stageX;
        e.target.y = ev.stageY;

        document.getElementById('dotX').value = parseInt(circle.x);
        document.getElementById('dotY').value = parseInt(circle.y);

        stage.update();
    }
}
function changeMouse() {
    this.cursor = "pointer";
}

function loadComment() {
    alert('click ma nigga');
}

function placeOne(x, y) {

    
    //i++;

    //alert("boe" +x+" "+y);
    dot = new createjs.Shape();
    dot.graphics.beginFill("red").drawCircle(0, 0, diameter);
 

    dot.x = x;
    dot.y = y;
    //array[i] = circle;
    
    dot.addEventListener("mousedown", alert);

    //stage.addChild(array[i]);
    stage.addChild(dot);

    stage.update();
}