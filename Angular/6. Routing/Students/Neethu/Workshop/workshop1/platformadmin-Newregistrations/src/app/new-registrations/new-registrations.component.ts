import { Component } from '@angular/core';
import { UserRegister } from '../UserRegister';

@Component({
  selector: 'app-new-registrations',
  templateUrl: './new-registrations.component.html',
  styleUrls: ['./new-registrations.component.css']
})
export class NewRegistrationsComponent {

  
  Registeredusers:UserRegister[];
  filteredusers:UserRegister[];
  constructor(){
    this.Registeredusers=[
      {
        Id:"#APL-0003",
        AppliedDate:"June 1,2020,08:22 AM",
        Company:"Mosciski Inc",
        Company2:"Creative DesignAgency",
        Type:"FREELANCE",
        Position:"Intern UI Designer",
        Status:"Pending"
      },
      {
        Id:"#APL-0003",
        AppliedDate:"June 1,2020,08:22 AM",
        Company:"Mosciski Inc ",
        Company2:"Creative DesignAgency",
        Type:"FREELANCE",
        Position:"Intern UI Designer",
        Status:"On-Hold"
      },
      {
        Id:"#APL-0003",
        AppliedDate:"June 1,2020,08:22 AM",
        Company:"Mosciski Inc ",
        Company2:"Creative DesignAgency",
        Type:"FREELANCE",
        Position:"Intern UI Designer",
        Status:"Pending"
      },
      {
        Id:"#APL-0003",
        AppliedDate:"June 1,2020,08:22 AM",
        Company:"Mosciski Inc ",
        Company2:"Creative DesignAgency",
        Type:"FREELANCE",
        Position:"Intern UI Designer",
        Status:"Candidate"
      },
      {
        Id:"#APL-0003",
        AppliedDate:"June 1,2020,08:22 AM",
        Company:"Mosciski Inc",
        Company2:"Creative DesignAgency",
        Type:"FREELANCE",
        Position:"Intern UI Designer",
        Status:"On-Hold"
      },
      {
        Id:"#APL-0003",
        AppliedDate:"June 1,2020,08:22 AM",
        Company:"Mosciski Inc ",
        Company2:"Creative DesignAgency",
        Type:"FREELANCE",
        Position:"Intern UI Designer",
        Status:"Candidate"
      }
    ];
    this.filteredusers=this.Registeredusers;
    

  }
  isHovered:boolean=false;
  companylogo="assets/images/companyLogo.png";
  contact="assets/images/contact.png";
  email="assets/images/email.png";
  frame2="assets/images/Frame 2.png";
  toggleAll(event:any){
    const checked=event.target.Checked;
    this.filteredusers.forEach(a=>a.selected=checked);
  }
  selectUsers(event:any){
    const status=event.target.innerText.trim();
    if(status=='All')
      this.filteredusers=this.Registeredusers;
    else if(status=='On-Hold')
      this.filteredusers=this.Registeredusers.filter(u=>u.Status==status);
    else if(status=='Candidate')
      this.filteredusers=this.Registeredusers.filter(u=>u.Status==status);
     else if(status=='Pending')
      this.filteredusers=this.Registeredusers.filter(u=>u.Status==status);
  }

}
