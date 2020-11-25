import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TrainingInfornationComponent } from './training-infornation.component';

describe('TrainingInfornationComponent', () => {
  let component: TrainingInfornationComponent;
  let fixture: ComponentFixture<TrainingInfornationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrainingInfornationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrainingInfornationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
