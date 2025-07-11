function validateForm()
{
    var emailId=document.myForm.email.value.trim();
    var password=document.myForm.password.value.trim();
    document.getElementById("emailerror").textContent="";
    document.getElementById("passworderror").textContent="";
    document.getElementById("emailerror1").textContent="";
    

    if(emailId===null||emailId=="")
    {
        document.getElementById("emailerror").textContent="********Email Cannot be Empty*********";
        return false;
    }
    if(!password)
    {
       document.getElementById("passworderror").textContent="********Password Cannot be Empty*********";
        return false;
    } 
    return validateFormat()   ;
}
function validateFormat()
{
    var emailId=document.myForm.email.value.trim();
    const emailpattern=/^[^ ]+@[^ ]+\.[a-z]{2,3}$/;
    if(!emailpattern.test(emailId))
    {
        document.getElementById("emailerror").textContent="";
         document.getElementById("emailerror1").textContent="";

       document.getElementById("emailerror1").textContent="********Not a valid Email ID*********";
        return false; 
    }


}