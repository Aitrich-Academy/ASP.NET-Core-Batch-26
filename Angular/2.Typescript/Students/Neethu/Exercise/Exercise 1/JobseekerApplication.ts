import * as readline from 'readline';
import { Job } from './Job';
import { Application } from './Application';

const rl=readline.createInterface({
    input:process.stdin,
    output:process.stdout
});

let running=true;
let joblist:Job[]=[];
let Applicationlist:Application[]=[];
let localstorage:string;

class JobSeeker
{
    constructor(){}
    Login(){
        console.log("\n=================Welcome To JobPortal=================\n");
        console.log("\nPlease Login.....");
        rl.question("Enter the Username:",(username)=>{
            rl.question("Enter the Password:",(password)=>{
                if(username=='neethu'&&password=='neethu123')
                {
                    localstorage='jobseeker';
                    return this.Showmenu();
                }
                else
                {
                    console.log("Login Failed!!!Invalid username or password");
                    return this.Login();
                }
            });
        });

    }
    Showmenu()
    {
        if(!running)
        {
            rl.close();
            return;
        }
        console.log(`=======Welcome, ${localstorage}`);
        console.log("1. All Jobs");
        console.log("2. My Applications");
        console.log("3. Logout");
        console.log("4.Exit");
        rl.question("Enter Your Choice",(choice)=>{
            switch(choice)
            {
                case "1":
                    this.FetchJoblist();
                    break;
                case "2":
                    this.FetchApplicationlist();
                    break;
                case "3":
                    this.logout();
                    break;
                case "4":
                    console.log("Exiting the program............");
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
    FetchJoblist(){
        joblist=[
            {
                JobTitle:"Java Developer",
                JobSummary:"Fresher",
                Location:"Kochi",
                Company:'UstGlobal',
                PostedDate:new Date("2026-01-01")

            },
            {
                JobTitle:".Net Developer",
                JobSummary:"Experienced",
                Location:"Banglore",
                Company:'Wipro',
                PostedDate:new Date("2026-01-20")

            },
            {
                JobTitle:"Accountant",
                JobSummary:"Fresher",
                Location:"Thiruvananthapuram",
                Company:'InfoTech',
                PostedDate:new Date("2026-02-01")

            },
            {
                JobTitle:"Automation Tester",
                JobSummary:"Experienced",
                Location:"Kochi",
                Company:'CTS',
                PostedDate:new Date("2026-01-23")

            }

        ]
        console.log("\n ********************Current JobVacancies******************\n");
        joblist.forEach((jobs)=>{
            console.log(`\nJobTitle: ${jobs.JobTitle}  JobSummary: ${jobs.JobSummary}  Location: ${jobs.Location}  Company: ${jobs.Company}  PostedDate: ${jobs.PostedDate}\n\n`);
        });
        this.Showmenu();
        
    }
    FetchApplicationlist(){
        Applicationlist=[
            {
                JobTitle:"Java Developer",
                Company:"UstGlobal",
                Location:"Kochi",
                AppliedDate:new Date('2026-02-01'),
                Status:"Submitted"
            },
            {
                JobTitle:".Net Developer",
                Company:"Wipro",
                Location:"Banglore",
                AppliedDate:new Date('2026-02-01'),
                Status:"Submitted"
            }
        ]
        console.log("\n ********************My Applications******************\n");
        Applicationlist.forEach((applications)=>{
            console.log(`\n JobTitle: ${applications.JobTitle}  Company: ${applications.Company}  Location: ${applications.Location}  AppliedDate: ${applications.AppliedDate}  Status: ${applications.Status}\n\n`);
        }); 
        this.Showmenu();
    }
    logout(){
        if(localstorage)
        {
            localstorage="";
            console.log("Logged out Successfully....");
            return this.Login();
        }
        else
        {
            return this.Login();
        }
    }
}
var newseeker=new JobSeeker();
newseeker.Login();