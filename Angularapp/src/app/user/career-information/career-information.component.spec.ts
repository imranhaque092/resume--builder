import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CareerInformationComponent } from './career-information.component';

describe('CareerInformationComponent', () => {
  let component: CareerInformationComponent;
  let fixture: ComponentFixture<CareerInformationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CareerInformationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CareerInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
