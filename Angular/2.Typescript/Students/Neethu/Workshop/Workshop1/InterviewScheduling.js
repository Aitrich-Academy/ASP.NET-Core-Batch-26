"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var running = true;
var interviewlist = [];
var localstorage = "";
var Jobprovider = /** @class */ (function () {
    function Jobprovider() {
    }
    ;
    Jobprovider.prototype.Showmenu = function () {
        var _this = this;
        if (!running) {
            rl.close();
            return;
        }
        console.log("****************************************** Welcome To Job Portal*********************************");
        console.log('1. Show Applicant List');
        console.log('2. Schedule Interview');
        console.log('3. Show Scheduled InterviewList');
        console.log('0. Exit');
        rl.question("Enter Your Choice", function (choice) {
            switch (choice) {
                case "1":
                    _this.ShowApplicantList();
                    break;
                case "2":
                    _this.ScheduleInterview();
                    break;
                case "3":
                    _this.ScheduledInterviewList();
                    break;
                case "0":
                    console.log("Exiting the program....");
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
    Jobprovider.prototype.ShowApplicantList = function () {
        var applicantlist = [
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
        ];
        console.log("\n-------------------------------------------------------ApplicantList--------------------------------------------------------\n");
        applicantlist.forEach(function (list) {
            console.log("Name: " + list.Name + "JobTitle: " + list.JobTitle + "Qualification: " + list.Qualfication + "Experience: " + list.Experience);
        });
        console.log("\n------------------------------------------------------------------------------------------------------------\n");
        this.Showmenu();
    };
    Jobprovider.prototype.ScheduleInterview = function () {
        var _this = this;
        var result = this.auth();
        if (result) {
            console.log("-------------------------Interview Schedule------------------");
            rl.question("Enter the JobTitle:", function (jobtitle) {
                rl.question("Enter interview date(yyyy-mm-dd):", function (interviewdate) {
                    var dateofinterview = new Date(interviewdate);
                    rl.question("Enter interview time: ", function (interviewtime) {
                        rl.question("Enter interview mode:", function (modeofinterview) {
                            var interviewdata = {
                                JobTitle: jobtitle,
                                Dateofinterview: dateofinterview,
                                time: interviewtime,
                                ModeofInterview: modeofinterview
                            };
                            interviewlist.push(interviewdata);
                            _this.Showmenu();
                        });
                    });
                });
            });
        }
    };
    Jobprovider.prototype.auth = function () {
        if (localstorage) {
            return true;
        }
        else {
            return this.login();
        }
    };
    Jobprovider.prototype.login = function () {
        var _this = this;
        console.log("Please Login");
        rl.question("Enter the Username:", function (username) {
            rl.question("Enter the password:", function (password) {
                if (username == 'admin' && password == 'admin123') {
                    localstorage = 'admin';
                    console.log("Logged Successfully");
                    _this.ScheduleInterview();
                    return true;
                }
                else {
                    console.log("Login Failed!!!!!!!Invalid Username or Password");
                    _this.login();
                }
            });
        });
    };
    Jobprovider.prototype.ScheduledInterviewList = function () {
        console.log("---------------Interviewlist-----------------");
        interviewlist.forEach(function (job) {
            console.log("Job Title: ".concat(job.JobTitle));
            console.log("dateOfInterview: ".concat(job.Dateofinterview));
            console.log("time: ".concat(job.time));
            console.log(" modeOfInterview: ".concat(job.ModeofInterview));
        });
        this.Showmenu();
    };
    return Jobprovider;
}());
var jobproviderref = new Jobprovider();
jobproviderref.Showmenu();
