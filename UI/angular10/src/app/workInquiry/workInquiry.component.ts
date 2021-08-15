  
import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-workInquiry',
  templateUrl: './workInquiry.component.html',
  styleUrls: ['./workInquiry.component.css']
})
export class WorkInquiryComponent implements OnInit {

  constructor(private service:SharedService) { }

  FirstName:string ="";
  LastName:string ="";
  Email:string ="";
  PhoneNumber:string ="";
  Description:string ="";



  ngOnInit(): void {

  }


  addEmployee(){
    var val = {FirstName:this.FirstName,
                LastName:this.LastName,
                Email:this.Email,
              PhoneNumber:this.PhoneNumber,
            Description:this.Description};

    this.service.addEmployee(val).subscribe(res=>{
      alert(res.toString());
    });
  }
}