import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Make } from '../models/make';
import { Observable } from 'rxjs';

import { MAKES } from '../utils/make-data';
import { MODELS } from '../utils/model-data';
import { TRIMS } from '../utils/trim-data';
import { Model } from '../models/model';
import { Trim } from '../models/trim';


@Injectable({
  providedIn: 'root'
})
export class GetDataService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getMakesWeb(): Observable<Array<Make>> {
    return this.http.get<Make[]>(`${this.baseUrl}api/Make`);
  }

  getModelsWeb(): Observable<Array<Model>> {
    return this.http.get<Model[]>(`${this.baseUrl}api/Model`);
  }

  getTrimsWeb(): Observable<Array<Trim>> {
    return this.http.get<Trim[]>(`${this.baseUrl}api/Trim`);
  }

  getModelsByMakeWeb(makeId: number): Observable<Array<Model>> {
    return this.http.get<Model[]>(`${this.baseUrl}api/Model/GetByKey?id=${makeId}`);
  }

  getTrimsByModelWeb(modelId: number): Observable<Array<Trim>> {
    return this.http.get<Trim[]>(`${this.baseUrl}api/Trim/GetByKey?id=${modelId}`);
  }
}
