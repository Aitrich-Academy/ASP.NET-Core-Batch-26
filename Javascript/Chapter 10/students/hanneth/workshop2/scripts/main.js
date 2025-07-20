function showForm(buttonVal)
{
    var id=document.getElementById('myTextBox');
    
    var skillButton=document.getElementById('myButton');


    if(buttonVal=="myButton1")
    {
    id.style.display='block';
    skillButton.style.display='block';
    }

    else if(buttonVal=="myButton2")
    {

        var id=document.getElementById('eduTextBox');
        var eduButton=document.getElementById('eduButton');
        id.style.display='block';
        eduButton.style.display='block';
    }
else if(buttonVal=="myButton3")
{
    var id=document.getElementById("aboutTextBox");
    var aboutButton = document.getElementById('aboutButton');
    id.style.display='block';
    aboutButton.style.display='block';
}
else if(buttonVal=="myButton4")
{
    var id=document.getElementById("experienceTextBox");
    var experienceButton = document.getElementById('experienceButton');
    id.style.display='block';
    experienceButton.style.display='block';
}
    
}

function add(text)
{
    if(text=="skill")
    {
    var data=document.getElementById('myTextBox').value;
    var textBox=document.getElementById('myTextBox');
    var listId=document.getElementById('skillList');
    var skills=[]
    skills.push(data);
    console.log(skills);
    for(i=0;i<skills.length;i++)
    {
        // Create a new list item
        var li = document.createElement('li');

         // Set the text content of the list item
            li.textContent = skills[i];

             // Append the list item to the list element
             listId.appendChild(li);
             textBox.value='';

    }
}

else if(text=="edu")
 {

     var data=document.getElementById('eduTextBox').value;
     var textBox=document.getElementById('eduTextBox');
     var listId=document.getElementById('eduList');
     var edu=[]
     edu.push(data);
     console.log(edu);
     for(i=0;i<edu.length;i++)
     {
         // Create a new list item
         var li = document.createElement('li');

          // Set the text content of the list item
             li.textContent = edu[i];

              // Append the list item to the list element
              listId.appendChild(li);
              textBox.value='';

     }
 }
 else if(text=="aboutme")
 {
    var data=document.getElementById('aboutTextBox').value;
    var textBox=document.getElementById('aboutTextBox');
    var aboutPId=document.getElementById('aboutP');
    var about=[];
    about.push(data);
    console.log(about);
    for(i=0;i<about.length;i++)
    {
        var pi=document.createElement('p');
        pi.textContent=about[i];
         aboutPId.appendChild(pi);
        textBox.value='';
    }
 }
 else if(text=="experience")
 {
   var data=document.getElementById('experienceTextBox').value;
    var textBox=document.getElementById('experienceTextBox');
    var experienceid=document.getElementById('experienceList');
    var experience=[];
    experience.push(data);
    console.log(experience);
    for(i=0;i<experience.length;i++)
    {
        var experienceli=document.createElement('li');
        experienceli.textContent=experience[i];
         experienceid.appendChild(experienceli);
        textBox.value='';
    }

 }

}