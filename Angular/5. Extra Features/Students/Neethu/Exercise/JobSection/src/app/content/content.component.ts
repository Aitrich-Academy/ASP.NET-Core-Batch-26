import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  showListjobs=true;
  savedJobs:any[]=[];
  jobposts=[{
  icon:"assets/images/Rectangle14.png",
  jobtitle:"UI/UX Designer",
  company:"Shopee",
  location:"Indonasia",
  content:"We are looking for aUI/UX Designer to turn our software into easy-to-use products for our clients",
  jobtype:"FullTime",
  salary:"$3000-$5000",
  jobmode:"Onsite"

  
 },
 {
  icon:"assets/images/Rectangle14_1.png",
  jobtitle:"Product Designer",
  company:"Amazon",
  location:"Indonasia",
  content:"Product Designer responsibilities include defining product specifications,creating digital or prime drawing fully-functional products",
  jobtype:"FullTime",
  salary:"$80,000-$100,000",
  jobmode:"Onsite"

  
 },
 {
  icon:"assets/images/Rectangle14_2.png",
  jobtitle:"UX Designer",
  company:"Ebay",
  location:"San Francisco",
  content:"We are looking for aUI/UX Designer to turn our software into easy-to-use products for our clients",
  jobtype:"FullTime",
  salary:"$80,000-$100,000",
  jobmode:"Onsite"

  
 },
 {
  icon:"assets/images/Rectangle14.png",
  jobtitle:"Customer Service Representative",
  company:"ServiceFirst Corporation",
  location:"Chicago",
  content:"We are looking for aUI/UX Designer to turn our software into easy-to-use products for our clients",
  jobtype:"FullTime",
  salary:"$3000-$5000",
  jobmode:"Onsite"

  
 },
 {
  icon:"assets/images/Rectangle14_1.png",
  jobtitle:"Sales Associate",
  company:"Amazon",
  location:"Los Angels",
  content:"Product Designer responsibilities include defining product specifications,creating digital or prime drawing fully-functional products",
  jobtype:"FullTime",
  salary:"$50,000-$60,000",
  jobmode:"Onsite"

  
 },
 {
  icon:"assets/images/Rectangle14_2.png",
  jobtitle:"Software Engineer",
  company:"Technical Solution",
  location:"San Francisco",
  content:"We are looking for aUI/UX Designer to turn our software into easy-to-use products for our clients",
  jobtype:"FullTime",
  salary:"$80,000-$100,000",
  jobmode:"Onsite"

  
 }
];
filteredjobs=this.jobposts;
filterjobs(event:Event){
  const searchterm=(event.target as HTMLInputElement).value;
  this.filteredjobs=this.jobposts.filter(j=>j.jobtitle.toLowerCase().includes(searchterm));
}
showAlljobs()
{
  this.showListjobs=true;
}
showSavedjobs()
{
  this.showListjobs=false;
}
saveJob(job:any)
{
  this.savedJobs.push(job);
}

}
