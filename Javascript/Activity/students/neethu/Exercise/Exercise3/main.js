function validateCharacter1(inputChar) {
  const regex = /^[a-zA-Z]+$/;
  const errorEl = document.getElementById("fnameerror");
  errorEl.textContent = "";

  if (!regex.test(inputChar)) {
    errorEl.textContent = "**Allowed only Alphabets";
    return false;
  }
  return true;
}

function validateCharacter2(inputChar){
    const regex= /^[a-zA-Z0-9]+$/;
    const errorEl = document.getElementById("unameerror");
  errorEl.textContent = "";
    if(!regex.test(inputChar))
    {
        errorEl.textContent="**Allowed only Alphabets and numbers";
        return false;
        
    }
    return true;
}
function validateEmail(){
    

    var email=document.myForm.email.value.trim();
    const emailpattern=/^[^ ]+@[^ ]+\.[a-z]{2,3}$/;
    const errorEl = document.getElementById("emailerror");
    errorEl.textContent="";

    if(!emailpattern.test(email))
    {
        errorEl.textContent="**Wrong email format";
        return false;
    }
return true;
}
function validatePhone(){
   const inputChar = document.getElementById("phone").value.trim();
  const errorEl = document.getElementById("phoneerror");
  errorEl.textContent = "";

  const regex = /^\d{10}$/;
  if (!regex.test(inputChar)) {
    errorEl.textContent = "**Allowed only 10 digits";
    return false;
  }
  return true;

}
/*function validateForm()
{
    var fname=document.myForm.fname.value.trim();
    var uname=document.myForm.uname.value.trim();
    var email=document.myForm.email.value.trim();
    var phone=document.myForm.phone.value.trim();
    document.getElementById("fnameerror1").textContent="";
    document.getElementById("unameerror1").textContent="";
    document.getElementById("emailerror1").textContent="";
    document.getElementById("phoneerror1").textContent="";
    
     if(fname===null||fname=="")
     {
        document.getElementById("fnameerror1").textContent="Full name cannot be empty";
        return false;
        
     }
     if(uname===null||uname=="")
     {
        document.getElementById("unameerror1").textContent="Username cannot be empty";
        return false;
     }
     if(email===null||email=="")
     {
        document.getElementById("emailerror1").textContent="Email cannot be empty";
        return false;
     }
     if(phone===null||phone=="")
     {
        document.getElementById("phoneerror1").textContent="Phone number cannot be empty";
        return false;
     }

'''''''''''''''''''''''''''''''''''''''''''''     
}*/
function displayDetails(){
    if (!validateForm()) return;

    const fname = document.myForm.fname.value.trim();
    const uname = document.myForm.uname.value.trim();
    const email = document.myForm.email.value.trim();
    const phone = document.myForm.phone.value.trim();

    const popup = document.querySelector(".display");

    if (popup) {
        popup.style.display = "block";
        popup.innerHTML = `
            <h3>Entered Details are:</h3>
            <p><strong>Full Name:</strong> ${fname}</p>
            <p><strong>Username:</strong> ${uname}</p>
            <p><strong>Email:</strong> ${email}</p>
            <p><strong>Phone:</strong> ${phone}</p>
        `;
    }

}