var stage, label, shape, circle;
var diameter = 10;
var added = 0;

window.onload = init();

function init() {
   
    stage = new createjs.Stage("placeDots");
    stage.enableDOMEvents(true);

    shape = new createjs.Shape();
    stage.addChild(shape);


    stage.addEventListener("stagemousedown", function (event) {
        
            
        if (added == 1) {

            stage.update();
        }
        else {
            circle = new createjs.Shape();
            circle.graphics.beginFill("red").drawCircle(0, 0, diameter);

            circle.x = event.stageX - (diameter / 2);
            circle.y = event.stageY - (diameter / 2);

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

        stage.update();
    }
}
function changeMouse() {
    this.cursor = "pointer";
}

function loadComment() {
    alert('click ma nigga');
}

function removeDots() {
    //  alert(stage);
    stage.removeChild(circle);
    stage.update();
    added = 0;
}