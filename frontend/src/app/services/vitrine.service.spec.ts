import { TestBed } from '@angular/core/testing';

import { VitrineService } from './vitrine.service';

describe('VitrineService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: VitrineService = TestBed.get(VitrineService);
    expect(service).toBeTruthy();
  });
});
