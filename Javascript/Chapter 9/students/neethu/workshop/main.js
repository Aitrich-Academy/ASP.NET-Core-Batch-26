function validateForm()
{
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var role=document.getElementById("role").value;
    var location=document.getElementById("location").value; 
    var website=document.getElementById("website").value;
     if(name==null  || name=="")
    {
        alert("Please Enter Name");
        return false;
    }
  
    if(email==null || email=="")
    {
        alert("Please Enter Email");
        return false;
    }
    if(phone==null  || phone=="")
    {
        alert("Please Enter Phone Number");
        return false;
    }
    if(role=="" || role==null)
    {
        alert("Please Enter Role");
        return false;
    }
    if(location==null || location=="")
    {
        alert("Please Enter Location");
        return false;
    }
    if(website==null || website=="")
    {
        alert("Please Enter Website");
        return false;
   
    }
    return true;
} 

function validateMail()

{
    const pattern= /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
    var email=document.getElementById("email").value;
   if(!pattern.test(email))
   {
        alert("Please enter valid mail");
        return false;
   }
   return true;
}
function validatePhone(){
    const pattern=/^(?:\+91[\-\s]?|0)?[6-9]\d{9}$/;
    var phone=document.getElementById("phone").value;
    if(!pattern.test(phone))
    {
        alert("Phone number format mismatch");
        return false;
    }
    return true;
}
function validateFname(inputCharacter){
    const regex=/^[a-zA-z]+$/;
    if(!regex.test(inputCharacter))
    {
        alert("Only alphabets allowed");
        return false;

    }
    return true;
}
function validateLocation(){
    const regex=/^[a-zA-Z0-9]+$/;
    var loc=document.getElementById("location").value;
    if(!regex.test(loc))
    {
        alert("only alphabets and numbers allowed");
        return false;
    }
    return true;
}
function validateWebsite()
{
    const pattern=/^[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/;
    var website=document.getElementById("website").value; 
    if(!pattern.test(website))
    {
        alert("Please enter a valid website URL");
        return false;
    }
    return true;
}


