import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RefereeInformationComponent } from './referee-information.component';

describe('RefereeInformationComponent', () => {
  let component: RefereeInformationComponent;
  let fixture: ComponentFixture<RefereeInformationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RefereeInformationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RefereeInformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
