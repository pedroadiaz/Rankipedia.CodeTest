import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { MatButtonModule } from '@angular/material/button'
import { MatInputModule } from '@angular/material/input'
import { MatAutocompleteModule } from '@angular/material/autocomplete';

import { FormInputComponent } from '../form-input/form-input.component';
import { FormSubmissionComponent } from '../form-submission/form-submission.component';
import { GetDataService } from '../services/get-data.service';


@NgModule({
  declarations: [
    FormInputComponent,
    FormSubmissionComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    MatAutocompleteModule,
    MatButtonModule,
    MatInputModule,
    RouterModule.forRoot([
      { path: '', component: FormInputComponent, pathMatch: 'full' },
      { path: 'form-input', component: FormInputComponent },
      { path: 'form-submission', component: FormSubmissionComponent },
    ])
  ],
  providers: [GetDataService],

})
export class ComponentModule { }
