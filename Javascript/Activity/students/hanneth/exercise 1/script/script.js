function validateForm()
{
   
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    
    if(email=="" ||email==null)
    {
        document.getElementById("mailp").innerHTML="******email cannot be empty*****";
        return false;
    }
    if(password==""||password==null)
    {
        document.getElementById("passwordp").innerHTML="*****Password cannot be empty********";
        return false;
    }
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
 