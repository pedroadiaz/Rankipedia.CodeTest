import { Injectable } from '@angular/core';
import { Make } from '../models/make';

import { MAKES } from '../utils/make-data';
import { MODELS } from '../utils/model-data';
import { TRIMS } from '../utils/trim-data';
import { Model } from '../models/model';
import { Trim } from '../models/trim';
import { Selection } from '../models/selection';

@Injectable({
  providedIn: 'root'
})
export class SearchDataService {

  constructor() {
    this.mapModels();
    this.mapTrims();
  }

  searchMakes(search: string): Array<Make> {
    return MAKES.filter(make => make.name.toLowerCase().includes(search));
  }

  searchModels(search: string): Array<Model> {
    return MODELS.filter(model => model.name.toLowerCase().includes(search));
  }

  searchTrims(search: string): Array<Trim> {
    return TRIMS.filter(trim => trim.name.toLowerCase().includes(search));
  }

  private mapModels(): void {
    MODELS.forEach(model => {
      model.make = MAKES.find(make => make.id == model.makeId);
    });
  }

  private mapTrims(): void {
    TRIMS.forEach(trim => {
      trim.model = MODELS.find(model => model.id == trim.modelId);
      if (trim.model) {
        trim.fullName = `${trim.model.make.name} ${trim.model.name} ${trim.name}`;
      }
    });
  }
}
