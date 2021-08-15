import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkInquiryComponent } from './workInquiry.component';

describe('WorkInquiryComponent', () => {
  let component: WorkInquiryComponent;
  let fixture: ComponentFixture<WorkInquiryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkInquiryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WorkInquiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
