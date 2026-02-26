import * as readline from 'readline';
import { Applicants } from './Applicants';
import { Interview } from './Interview';

const rl=readline.createInterface({
    input:process.stdin,
    output:process.stdout
});

let running=true;
let interviewlist:Interview[]=[];
let localstorage:string="";
class Jobprovider{
    constructor(){};
     Showmenu() {
        if(!running)
        {
            rl.close();
            return;
        }
        console.log("****************************************** Welcome To Job Portal*********************************");
        console.log('1. Show Applicant List');
        console.log('2. Schedule Interview');
        console.log('3. Show Scheduled InterviewList');
        console.log('0. Exit');
        rl.question("Enter Your Choice",(choice)=>{
            switch(choice)
            {
                case "1":
                    this.ShowApplicantList();
                    break;
                case "2":
                    this.ScheduleInterview();
                    break;
                case "3":
                    this.ScheduledInterviewList();
                    break;
                case "0":
                    console.log("Exiting the program....");
                    running=false;
                    this.Showmenu();
                    break;
                default:
                    console.log("Invalid Choice");
                    this.Showmenu();
                    break;
            }
        });
        
    }
    ShowApplicantList(){
        var applicantlist: Applicants[]=[
            {
                Name: "Akash .A. ",
                JobTitle: "Java Developer",
                Qualfication: "Bca",
                Experience: "2 Year"
            },
            {
                Name: "Pakash P Babu",
                JobTitle: "Asp .Net Developer",
                Qualfication: "Mca",
                Experience: "4 Year"
            },
            {
                Name: "Baviya C Menon",
                JobTitle: "Asp .Net Developer",
                Qualfication: "Mca",
                Experience: "1 Year",
            },
            {
                Name: "Hrishika P Harish",
                JobTitle: "Front End Developer Angular",
                Qualfication: "Btech",
                Experience: "3 Year"
            }
        ]
        console.log("\n-------------------------------------------------------ApplicantList--------------------------------------------------------\n");
        applicantlist.forEach(list=>{
            console.log("Name: "+list.Name+  "JobTitle: "+list.JobTitle+  "Qualification: "+list.Qualfication+  "Experience: "+list.Experience);
        });
        console.log("\n------------------------------------------------------------------------------------------------------------\n")

        this.Showmenu();

    }

    ScheduleInterview(){
        var result:any=this.auth();
        if(result)
        {
             console.log("-------------------------Interview Schedule------------------");
             rl.question("Enter the JobTitle:",(jobtitle)=>{
                rl.question("Enter interview date(yyyy-mm-dd):",(interviewdate)=>{
                    const dateofinterview:Date=new Date(interviewdate);
                    rl.question("Enter interview time: ",(interviewtime)=>{
                        rl.question("Enter interview mode:",(modeofinterview)=>{

                            const interviewdata:Interview={
                                JobTitle: jobtitle,
                                Dateofinterview: dateofinterview,
                                time: interviewtime,
                                ModeofInterview: modeofinterview



                            };
                            interviewlist.push(interviewdata);
                            this.Showmenu();
                           
                            
                        });
                    });
                });
             });
        }

    }
    auth():any
    {
        if(localstorage)
        {
            return true;
        }
        else
        {
            return this.login();
        }
    }
    login():any
    {
        console.log("Please Login");
        rl.question("Enter the Username:",(username)=>{
            rl.question("Enter the password:",(password)=>{
                if(username=='admin'&&password=='admin123')
                {
                    localstorage='admin';
                    console.log("Logged Successfully");
                    this.ScheduleInterview();
                    return true;
                }
                else{
                    console.log("Login Failed!!!!!!!Invalid Username or Password");
                    this.login();

                }
            });
        });



    }
    ScheduledInterviewList(){
        console.log("---------------Interviewlist-----------------");
        interviewlist.forEach(job=>{
            console.log(`Job Title: ${job.JobTitle}`);
            console.log(`dateOfInterview: ${job.Dateofinterview}`);
            console.log(`time: ${job.time}`);
            console.log(` modeOfInterview: ${job. ModeofInterview}`);
        });
        this.Showmenu();

}
   
    

}


var jobproviderref=new Jobprovider();
jobproviderref.Showmenu();
