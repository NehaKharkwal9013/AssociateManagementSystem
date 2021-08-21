import { TestBed } from '@angular/core/testing';

import { AMSServiceService } from './ams-service.service';

describe('AMSServiceService', () => {
  let service: AMSServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AMSServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
