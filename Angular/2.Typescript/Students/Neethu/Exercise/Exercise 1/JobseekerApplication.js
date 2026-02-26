"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var running = true;
var joblist = [];
var Applicationlist = [];
var localstorage;
var JobSeeker = /** @class */ (function () {
    function JobSeeker() {
    }
    JobSeeker.prototype.Login = function () {
        var _this = this;
        console.log("\n=================Welcome To JobPortal=================\n");
        console.log("\nPlease Login.....");
        rl.question("Enter the Username:", function (username) {
            rl.question("Enter the Password:", function (password) {
                if (username == 'neethu' && password == 'neethu123') {
                    localstorage = 'jobseeker';
                    return _this.Showmenu();
                }
                else {
                    console.log("Login Failed!!!Invalid username or password");
                    return _this.Login();
                }
            });
        });
    };
    JobSeeker.prototype.Showmenu = function () {
        var _this = this;
        if (!running) {
            rl.close();
            return;
        }
        console.log("=======Welcome, ".concat(localstorage));
        console.log("1. All Jobs");
        console.log("2. My Applications");
        console.log("3. Logout");
        console.log("4.Exit");
        rl.question("Enter Your Choice", function (choice) {
            switch (choice) {
                case "1":
                    _this.FetchJoblist();
                    break;
                case "2":
                    _this.FetchApplicationlist();
                    break;
                case "3":
                    _this.logout();
                    break;
                case "4":
                    console.log("Exiting the program............");
                    running = false;
                    _this.Showmenu();
                    break;
                default:
                    console.log("Invalid Choice");
                    _this.Showmenu();
                    break;
            }
        });
    };
    JobSeeker.prototype.FetchJoblist = function () {
        joblist = [
            {
                JobTitle: "Java Developer",
                JobSummary: "Fresher",
                Location: "Kochi",
                Company: 'UstGlobal',
                PostedDate: new Date("2026-01-01")
            },
            {
                JobTitle: ".Net Developer",
                JobSummary: "Experienced",
                Location: "Banglore",
                Company: 'Wipro',
                PostedDate: new Date("2026-01-20")
            },
            {
                JobTitle: "Accountant",
                JobSummary: "Fresher",
                Location: "Thiruvananthapuram",
                Company: 'InfoTech',
                PostedDate: new Date("2026-02-01")
            },
            {
                JobTitle: "Automation Tester",
                JobSummary: "Experienced",
                Location: "Kochi",
                Company: 'CTS',
                PostedDate: new Date("2026-01-23")
            }
        ];
        console.log("\n ********************Current JobVacancies******************\n");
        joblist.forEach(function (jobs) {
            console.log("\nJobTitle: ".concat(jobs.JobTitle, "  JobSummary: ").concat(jobs.JobSummary, "  Location: ").concat(jobs.Location, "  Company: ").concat(jobs.Company, "  PostedDate: ").concat(jobs.PostedDate, "\n\n"));
        });
        this.Showmenu();
    };
    JobSeeker.prototype.FetchApplicationlist = function () {
        Applicationlist = [
            {
                JobTitle: "Java Developer",
                Company: "UstGlobal",
                Location: "Kochi",
                AppliedDate: new Date('2026-02-01'),
                Status: "Submitted"
            },
            {
                JobTitle: ".Net Developer",
                Company: "Wipro",
                Location: "Banglore",
                AppliedDate: new Date('2026-02-01'),
                Status: "Submitted"
            }
        ];
        console.log("\n ********************My Applications******************\n");
        Applicationlist.forEach(function (applications) {
            console.log("\n JobTitle: ".concat(applications.JobTitle, "  Company: ").concat(applications.Company, "  Location: ").concat(applications.Location, "  AppliedDate: ").concat(applications.AppliedDate, "  Status: ").concat(applications.Status, "\n\n"));
        });
        this.Showmenu();
    };
    JobSeeker.prototype.logout = function () {
        if (localstorage) {
            localstorage = "";
            console.log("Logged out Successfully....");
            return this.Login();
        }
        else {
            return this.Login();
        }
    };
    return JobSeeker;
}());
var newseeker = new JobSeeker();
newseeker.Login();
