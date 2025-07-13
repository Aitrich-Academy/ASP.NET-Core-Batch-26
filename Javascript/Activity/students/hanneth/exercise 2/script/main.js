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
function phonevalidate()
{
    const ph=/^[+]?[(]?[0-9]{3}[)]?[-\s.]?[0-9]{3}[-\s.]?[0-9]{4,9}$/; 
    return ph.test(phone);
}
  function validateMail()
    {
    const pattern=  /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
   if(!pattern.test(email))
   {
        document.getElementById("mailerr").innerHTML="Please enter valid mail"
        return false;
   }
    } 