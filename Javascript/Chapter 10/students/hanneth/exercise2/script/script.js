

function display() 
{
    const alen = { Image: "images/person2.jpg", Name: "Alen", Qualification: "MCA", Experience: "3 Year", Location: "Bangalore" };
    const Sarah = { Image: "images/girl.png", Name:"Sarah" , Qualification: "MSc", Experience: "2 Year", Location: "Chennai" };
    const Vivek = { Image: "images/person1.jpg", Name: "Vivek", Qualification: "BTech", Experience: "5 Year", Location: "Thiruvanathapuram" };
    const Deepak = { Image: "images/person4.jpg", Name: "Deepak Roy", Qualification: "BTech", Experience: "2 year", Location: "Calicut" };
    document.getElementById("short").innerText = "Short list";
   let img=document.createElement("img");
    img.src=alen.Image;
   document.body.appendChild(img);
   img.style.marginLeft="400px";
   img.style.height="130px";
   img.style.width="130px";
   let table=document.createElement("table");
    let newrow= table.insertRow();
    let cell1=newrow.insertCell();
    let cell2=newrow.insertCell();
    let newrow1=table.insertRow();
    let cell3=newrow1.insertCell();
    let cell4=newrow1.insertCell();
    let img1=document.createElement("img");
    img1.src=Sarah.Image;
   document.body.appendChild(img1);
   img1.style.marginLeft="400px";
   img1.style.height="130px";
   img1.style.width="130px";
    cell1.textContent= `${alen.Name}\nQualification: ${alen.Qualification}\nExperience: ${alen.Experience}\nLocation: ${alen.Location}`;
    cell2.textContent=`${Sarah.Name}\nQualification: ${Sarah.Qualification}\nExperience: ${Sarah.Experience}\nLocation: ${Sarah.Location}`;
    let img2=document.createElement("img");
    img2.src=Vivek.Image;
   document.body.appendChild(img2);
   img2.style.marginLeft="400px";
   img2.style.height="130px";
   img2.style.width="130px";

let img3=document.createElement("img");
    img3.src=Deepak.Image;
   document.body.appendChild(img3);
   img3.style.marginLeft="400px";
   img3.style.height="130px";
   img3.style.width="130px";
    cell3.textContent=`${Vivek.Name}\nQualification: ${Vivek.Qualification}\nExperience: ${Vivek.Experience}\nLocation: ${Vivek.Location}`;
    cell4.textContent=`${Deepak.Name}\nQualification: ${Deepak.Qualification}\nExperience: ${Deepak.Experience}\nLocation: ${Deepak.Location}`;
    table.style.marginLeft="400px";
        document.body.appendChild(table);
   
}

