import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { AppModule } from '../app.module';

import { FormSubmissionComponent } from './form-submission.component';
import { MAKES } from '../utils/make-data';
import { MODELS } from '../utils/model-data';
import { TRIMS } from '../utils/trim-data';
import { Selection } from '../models/selection';


describe('FormSubmissionComponent', () => {
  let component: FormSubmissionComponent;
  let fixture: ComponentFixture<FormSubmissionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [AppModule],
    })
    .compileComponents()
    .then(() => {
      fixture = TestBed.createComponent(FormSubmissionComponent);
      component = fixture.componentInstance;
      const make = MAKES[0];
      const model = MODELS[0];
      const trim = TRIMS[0];
      const s: Selection = { make: make, model: model, trim: trim, makeId: make.id, modelId: model.id, trimId: trim.id };

      component.selection = s;
      console.log(component.selection);
      fixture.detectChanges();
    });
  }));

  beforeEach(() => {
  });

  it('should create', () => {

    expect(component).toBeTruthy();

  });
});
