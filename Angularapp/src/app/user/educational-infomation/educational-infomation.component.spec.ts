import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EducationalInfomationComponent } from './educational-infomation.component';

describe('EducationalInfomationComponent', () => {
  let component: EducationalInfomationComponent;
  let fixture: ComponentFixture<EducationalInfomationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EducationalInfomationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EducationalInfomationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
