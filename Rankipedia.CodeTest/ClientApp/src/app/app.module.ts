import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatButtonModule } from '@angular/material/button'
import { MatInputModule } from '@angular/material/input'
import { MatAutocompleteModule } from '@angular/material/autocomplete';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { GetDataService } from './services/get-data.service';
import { SearchDataService } from './services/search-data.service';
import { FormInputComponent } from './form-input/form-input.component';
import { FormSubmissionComponent } from './form-submission/form-submission.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    FormInputComponent,
    FormSubmissionComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatAutocompleteModule,
    MatButtonModule,
    MatInputModule,
    RouterModule.forRoot([
      { path: '', component: FormInputComponent, pathMatch: 'full' },
      { path: 'form-input', component: FormInputComponent },
      { path: 'form-submission', component: FormSubmissionComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'counter', component: CounterComponent },
    ])
  ],
  providers: [GetDataService, SearchDataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
