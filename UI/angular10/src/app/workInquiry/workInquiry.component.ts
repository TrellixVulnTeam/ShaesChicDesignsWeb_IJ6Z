  
import { formatCurrency } from '@angular/common';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { WorkInquiry } from '../workInquiry';

@Component({
  selector: 'app-workInquiry',
  templateUrl: './workInquiry.component.html',
  styleUrls: ['./workInquiry.component.css']
})
export class WorkInquiryComponent implements OnInit {

  constructor(private service:SharedService) { }

  submitted = false;
  mobNumberPattern = "^((\\+91-?)|0)?[0-9]{10}$";  
  model = new WorkInquiry('','','','','');
  newWorkInquiry() {
    this.model = new WorkInquiry('','','','','');
  }

  ngOnInit(): void {

  }
 onSubmit(form: any) { 
    this.submitted = true;
    var val = {
      FirstName:form.controls.FirstName.value,
      LastName:form.controls.LastName.value,
      Email:form.controls.Email.value,
      PhoneNumber:form.controls.PhoneNumber.value,
      Description: form.controls.Description.value
      };

    this.service.addWorkInquiry(val).subscribe(res=>{
      alert(res.toString());
    });
  }
}