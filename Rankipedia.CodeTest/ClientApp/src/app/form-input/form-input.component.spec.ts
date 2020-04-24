import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormInputComponent } from './form-input.component';
import { AppModule } from '../app.module';

describe('FormInputComponent', () => {
  let component: FormInputComponent;
  let fixture: ComponentFixture<FormInputComponent>;
  let getDataService: any;

  beforeEach(async(() => {
    const getDataServicesSpy = jasmine.createSpyObj("getDataService", ["getMakesWeb"])

    TestBed.configureTestingModule({
      imports: [AppModule],
      providers: [
        { provide: getDataService, useValue: getDataServicesSpy}
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormInputComponent);
    getDataService = TestBed.get(getDataService);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
