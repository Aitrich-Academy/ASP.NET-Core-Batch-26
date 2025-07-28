var jobList=[
    {jobTitle:"Social Media Assistant", loc:"online",date:"16-06-23",time:"10 a.m"},
    {jobTitle:"Brand Designer", loc:"offline",date:"19-06-23",time:"12 p.m"},
    {jobTitle:"Customer Manager", loc:"online",date:"20-06-23",time:"12 p.m"}
];
function loadData(){
    var jobTitle1=document.getElementById("jobTitle1");
    var jobTitle2=document.getElementById("jobTitle2");
    var jobTitle3=document.getElementById("jobTitle3");

    var location1=document.getElementById("location1");
    var location2=document.getElementById("location2");
    var location3=document.getElementById("location3");

    var date1=document.getElementById("date1");
    var date2=document.getElementById("date2");
    var date3=document.getElementById("date3");

    var time1=document.getElementById("time1");
    var time2=document.getElementById("time2");
    var time3=document.getElementById("time3");

    jobTitle1.innerHTML=jobList[0].jobTitle;
    location1.innerHTML="Location:"+jobList[0].loc;
    date1.innerHTML="Date:"+jobList[0].date;
    time1.innerHTML="Time:"+jobList[0].time;

    jobTitle2.innerHTML=jobList[1].jobTitle;
    location2.innerHTML="Location:"+jobList[1].loc;
    date2.innerHTML="Date:"+jobList[1].date;
    time2.innerHTML="Time:"+jobList[1].time;

    jobTitle3.innerHTML=jobList[2].jobTitle;
    location3.innerHTML="Location:"+jobList[2].loc;
    date3.innerHTML="Date:"+jobList[2].date;
    time3.innerHTML="Time:"+jobList[2].time;
    
}