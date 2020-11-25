import { TestBed } from '@angular/core/testing';

import { EducationalInfomationService } from './educational-infomation.service';

describe('EducationalInfomationService', () => {
  let service: EducationalInfomationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EducationalInfomationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
