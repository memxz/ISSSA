
function validateForm() {
  let x = document.forms["information"]["myName"].value;
  let y = document.forms["information"]["age"].value;
  if (x == "") {
    document.getElementById("error").innerHTML="Name should not be blank";
    alert("Name should not be blank.");
    return false;
  }
  if(x.length>15){
    document.getElementById("error").innerHTML="Name should be no more than 15 letters long";
    alert("Name should be no more than 15 letters long.");
    return false;
  }
  pr();
  return false;
}

function pr() {
  document.getElementById("output").innerHTML = "";
 var ele = document.getElementsByName('genderRB');
 var hob = document.getElementsByName('statusRB');
 for(i = 0; i < ele.length; i++) {
     if(ele[i].checked)
     document.getElementById("output").innerHTML
             += "Gender: "+ele[i].value+" ";
 }
 for(i = 0; i < hob.length; i++) {
  if(hob[i].checked)
  document.getElementById("output").innerHTML
          +="hobies: "+ hob[i].value+" ";
}
document.getElementById("output").innerHTML ="Name: " + document.getElementById('myName').value + " " +"Age: "+ document.getElementById('age').value+" "+document.getElementById("output").innerHTML;

}