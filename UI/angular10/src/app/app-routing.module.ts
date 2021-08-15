import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {EmployeeComponent} from './employee/employee.component';
import {DepartmentComponent} from './department/department.component';
import {WorkInquiryComponent} from './workInquiry/workInquiry.component';
import {ShopComponent} from './shop/shop.component';
import {HomeComponent} from './home/home.component';

const routes: Routes = [
{path:'employee',component:EmployeeComponent},
{path:'department',component:DepartmentComponent},
{path:'workInquiry',component:WorkInquiryComponent},
{path:'shop',component:ShopComponent},
{path: '',     component: HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }