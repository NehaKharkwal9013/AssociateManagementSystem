import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AmsApicallComponent } from './ams-apicall.component';

describe('AmsApicallComponent', () => {
  let component: AmsApicallComponent;
  let fixture: ComponentFixture<AmsApicallComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AmsApicallComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AmsApicallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
