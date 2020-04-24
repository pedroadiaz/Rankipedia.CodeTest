import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from "@angular/forms";
import { Make } from '../models/make';
import { Model } from '../models/model';
import { Trim } from '../models/trim';
import { GetDataService } from '../services/get-data.service';

import { map, startWith } from 'rxjs/operators';
import { Observable, Subscription, combineLatest } from 'rxjs';
import { BaseEntity } from '../models/base-entity';
import { Selection } from "../models/selection";
import { Router } from '@angular/router';
import { PlatformLocation } from '@angular/common';

@Component({
  selector: 'form-input',
  templateUrl: './form-input.component.html',
  styleUrls: ['./form-input.component.css']
})
export class FormInputComponent implements OnInit {
  form: FormGroup;
  makeList: Observable<Make[]>;
  modelList: Observable<Model[]>;
  trimList: Observable<Trim[]>;

  showModels: boolean = false;
  showTrims: boolean = false;
  backPressed: boolean = false;
  filteredMakes$: Observable<Make[]>;
  filteredModels$: Observable<Model[]>;
  filteredTrims$: Observable<Trim[]>;

  constructor(
    private fb: FormBuilder,
    private getDataService: GetDataService,
    private router: Router,
    private platform: PlatformLocation
  ) {
    this.form = this.fb.group({
      make: ['', Validators.required],
      model: ['', Validators.required],
      trim: ['', Validators.required],
    });

    this.platform.onPopState(() => {
      localStorage.setItem("backButton", "true")
    });
  }

  private _filter(name: string, blah: Array<BaseEntity>): BaseEntity[] {
    const filterValue = name.toLowerCase();
    return blah.filter(option => option.name.toLowerCase().indexOf(filterValue) === 0);
  }

  displayFn(base: BaseEntity): string {
    return base && base.name ? base.name : '';
  }

  ngOnDestroy(): void {
  }

  ngOnInit(): void {
    if (localStorage.getItem("backButton") == "true") {
      this.processBack();
      localStorage.removeItem("backButton");
    }

    this.makeList = this.getDataService.getMakesWeb();
    let filter$ = this.form.controls.make.valueChanges
      .pipe(
          startWith(''),
          map(value => typeof value === "string" ? value : value.name)
        );

    this.filteredMakes$ = combineLatest(this.makeList, filter$)
      .pipe(
        map(([makes, filter]) => filter ? this._filter(filter, makes) as Array<Make> : makes.slice()),
        map(make => {
          if (make.length == 1) {
            this.modelList = this.getDataService.getModelsByMakeWeb(make[0].id);
            this.showModels = true;
            this.selectMake();
          }
          else {
            this.showModels = this.backPressed ? true : false;
          }
          return make;
        })
      );
  }

  selectMake() {
    let filter$ = this.form.controls.model.valueChanges
      .pipe(
        startWith(''),
        map(value => typeof value === "string" ? value : value.name)
    );

    this.filteredModels$ = combineLatest(this.modelList, filter$)
      .pipe(
        map(([models, filter]) => filter ? this._filter(filter, models) as Array<Model> : models.slice()),
        map(model => {
          if (model.length >= 1) {
            this.trimList = this.getDataService.getTrimsByModelWeb(model[0].id);
            this.showTrims = (this.form.controls.model.value != "");
            this.selectModel();
          }
          else {
            this.showTrims = false;
          }
          return model;
        })
    );
  }

  selectModel() {
    let filter = this.form.controls.trim.valueChanges
      .pipe(
        startWith(''),
        map(value => typeof value === "string" ? value : value.name),
    );

    this.filteredTrims$ = combineLatest(this.trimList, filter)
      .pipe(
        map(([trims, filter]) => filter ? this._filter(filter, trims) as Array<Trim> : trims.slice()),
      );
  }

  SaveData() {
    if (this.form.valid) {
      let selection: Selection = new Selection();

      selection.make = (this.form.controls.make.value as Make);
      selection.model = (this.form.controls.model.value as Model);
      selection.trim = (this.form.controls.trim.value as Trim);

      localStorage.setItem("selection", JSON.stringify(selection))

      this.router.navigateByUrl("form-submission");
    }
  }

  processBack() {
    let selection: Selection = JSON.parse(localStorage.getItem("selection")) as Selection;

    if (selection.make) {
      this.form.controls.make.setValue(selection.make);
      this.form.controls.model.setValue(selection.model);
      this.form.controls.trim.setValue(selection.trim);

      this.showModels = true;
      this.showTrims = true;
      this.backPressed = true;
    }
  }

}
