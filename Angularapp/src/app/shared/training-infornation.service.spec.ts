import { TestBed } from '@angular/core/testing';

import { TrainingInfornationService } from './training-infornation.service';

describe('TrainingInfornationService', () => {
  let service: TrainingInfornationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TrainingInfornationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
