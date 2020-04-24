import { TestBed } from '@angular/core/testing';
import { InjectionToken, Injector } from '@angular/core';
import { HttpClientTestingModule, HttpTestingController } from "@angular/common/http/testing";

import { environment } from "../../environments/environment"
import { GetDataService } from './get-data.service';
import { MAKES } from '../utils/make-data';
import { MODELS } from '../utils/model-data';
import { Trim } from '../models/trim';
import { TRIMS } from '../utils/trim-data';

describe('GetDataService', () => {
  let service: GetDataService;
  let httpTestingController: HttpTestingController;
  let baseUrl: string = "https://localhost:44379/";
  let BASE_URL = environment.BaseUrl;

  beforeEach(() => {
    TestBed.configureTestingModule({

      imports: [HttpClientTestingModule],
      providers: [GetDataService]
      });
    service = TestBed.get(GetDataService);

    httpTestingController = TestBed.get(HttpTestingController);
  });

  it("getMakesWeb() should retrieve all makes", () => {
    service.getMakesWeb()
      .subscribe(makes => {
        expect(makes).toBeTruthy("No makes returned");

        expect(makes.length).toBe(3, "incorrect number of makes");

        const make = makes.find(m => m.id == 3);
        console.log(make);
        expect(make.name).toBe("Toyota");
      });

    const req = httpTestingController.expectOne(`${environment.BaseUrl}api/Make`);

    expect(req.request.method).toEqual("GET");

    req.flush(Object.values(MAKES));
  });



  it("getModelsWeb() should retrieve all models", () => {
    service.getModelsWeb()
      .subscribe(models => {
        expect(models).toBeTruthy("No makes returned");

        expect(models.length).toBe(9, "incorrect number of models");

        const make = models.find(m => m.id == 1);

        expect(make.name).toBe("M340");
      });

    const req = httpTestingController.expectOne(`${environment.BaseUrl}api/Model`);

    expect(req.request.method).toEqual("GET");

    req.flush(Object.values(MODELS));
  });

  it("getTrimsWeb() should retrieve all trims", () => {
    service.getTrimsWeb()
      .subscribe(trims => {
        expect(trims).toBeTruthy("No trims returned");

        expect(trims.length).toBe(23, "incorrect number of trims");

        const trim = trims.find(m => m.id == 18);
        console.log(trim);
        expect(trim.name).toBe("Launch Edition");
      });

    const req = httpTestingController.expectOne(`${environment.BaseUrl}api/Trim`);

    expect(req.request.method).toEqual("GET");

    req.flush(Object.values(TRIMS));
  });

  it("getModelsByMakeWeb should retrieve some models", () => {
    let id = 1;

    service.getModelsByMakeWeb(id)
      .subscribe(models => {
        expect(models).toBeTruthy("No trims returned");

        expect(models.length).toBe(5, "incorrect number of models");

        const make = models.find(m => m.id == 18);

        expect(make.name).toBe("Launch Edition");
      });

    const req = httpTestingController.expectOne(`${environment.BaseUrl}api/Model/GetByKey?id=${id}`);

    expect(req.request.method).toEqual("GET");

    req.flush(Object.values(MODELS.filter(m => m.makeId == 1)));
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
