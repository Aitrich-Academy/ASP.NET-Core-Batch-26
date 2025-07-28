function validatename()
{
    inputCharacter=document.getElementById("fullname").value;
    const regex=/^[a-zA-z]+$/;
    if(!regex.test(inputCharacter))
    {
        alert("please enter a valid name!!!!!!!!!");
        return false;

    }
    return true;
}
function validateusername()
{
    username=document.getElementById("usernmae").value;
    const regex=/^[a-zA-Z]+$/;
    if(!regex.test(username))
    {
        alert("please enter a valid name!!!!!!!!!");
        return false;

    }
    return true;
}

function phonevalidate()
{
    phone=document.getElementById("phone").value;
    const ph=/^(?:\+91[\-\s]?|0)?[6-9]\d{9}$/;
    if(!ph.test(phone)) 
    {
        alert("not a valid phone number!!!!!!!!!!!!!");
        return false;
    }
    return true;
}


  function validateMail()
    {
    const pattern=  /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    email=document.getElementById("email").value;
   if(!pattern.test(email))
   {
        document.getElementById("mailp").innerHTML="Please enter valid mail"
        return false;
   }
   return true;
    }
function validateForm()
{

var fullname=document.getElementById("fullname").value;
var username=document.getElementById("username").value;
var email=document.getElementById("email").value;
var phone =document.getElementById("phone").value;
if(fullname==""||fullname==null)
{
document.getElementById("fn").innerHTML="Please type your name";
return false;
}
if(username==""||username==null)
{
    document.getElementById("un").innerHTML="Please enter your username";
    return false;
}
if(email==""||email==null)
{
    document.getElementById("mailp").innerHTML="Please enter your email";
    return false;
}
if(phone==""||phone==null)
{
    document.getElementById("print").innerHTML="Please enter your phone number";
    return false;
}

alert("Entered Details are\n"  +fullname +"\n"
    +"user Name:"+username+"\n"
    +"Email:"+email+"\n"
    +"Phone:"+phone+"\n"
);
return false;
}

