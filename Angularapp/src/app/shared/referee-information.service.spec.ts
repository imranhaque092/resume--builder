import { TestBed } from '@angular/core/testing';

import { RefereeInformationService } from './referee-information.service';

describe('RefereeInformationService', () => {
  let service: RefereeInformationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RefereeInformationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
