import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Make } from '../models/make';
import { Observable } from 'rxjs';

import { environment } from "../../environments/environment";
import { Model } from '../models/model';
import { Trim } from '../models/trim';


@Injectable({
  providedIn: 'root'
})
export class GetDataService {
  constructor(private http: HttpClient) { }

  getMakesWeb(): Observable<Array<Make>> {
    return this.http.get<Make[]>(`${environment.BaseUrl}api/Make`);
  }

  getModelsWeb(): Observable<Array<Model>> {
    return this.http.get<Model[]>(`${environment.BaseUrl}api/Model`);
  }

  getTrimsWeb(): Observable<Array<Trim>> {
    return this.http.get<Trim[]>(`${environment.BaseUrl}api/Trim`);
  }

  getModelsByMakeWeb(makeId: number): Observable<Array<Model>> {
    return this.http.get<Model[]>(`${environment.BaseUrl}api/Model/GetByKey?id=${makeId}`);
  }

  getTrimsByModelWeb(modelId: number): Observable<Array<Trim>> {
    return this.http.get<Trim[]>(`${environment.BaseUrl}api/Trim/GetByKey?id=${modelId}`);
  }
}
