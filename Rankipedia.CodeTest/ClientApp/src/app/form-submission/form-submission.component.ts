import { Component, OnInit } from '@angular/core';
import { Selection } from '../models/selection';

@Component({
  selector: 'app-form-submission',
  templateUrl: './form-submission.component.html',
  styleUrls: ['./form-submission.component.css']
})
export class FormSubmissionComponent implements OnInit {
  selection: Selection;

  constructor() { }

  ngOnInit(): void {
    if (!this.selection) {
      this.selection = JSON.parse(localStorage.getItem("selection")) as Selection;
    }
    
  }
}
