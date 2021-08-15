  
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-workInquiry',
  templateUrl: './workInquiry.component.html',
  styleUrls: ['./workInquiry.component.css']
})
export class WorkInquiryComponent implements OnInit {

  constructor(private service:SharedService) { }

  //WorkInquiryId:number=10;
  Description:string ="";
  FirstName:string ="";
  LastName:string ="";
  Email:string ="";
  PhoneNumber:string ="";

  ngOnInit(): void {

  }

  addWorkInquiry(){
    var val = {
      //WorkInquiryId:this.WorkInquiryId,
      Description:this.Description,
      FirstName:this.FirstName,
      LastName:this.LastName,
      Email:this.Email,
      PhoneNumber:this.PhoneNumber
      };

    this.service.addWorkInquiry(val).subscribe(res=>{
      alert(res.toString());
    });
  }
}