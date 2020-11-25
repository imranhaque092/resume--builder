import { TestBed } from '@angular/core/testing';

import { CareerInformationService } from './career-information.service';

describe('CareerInformationService', () => {
  let service: CareerInformationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CareerInformationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
