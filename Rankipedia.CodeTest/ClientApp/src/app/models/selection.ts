import { Make } from '../models/make';
import { Model } from '../models/model';
import { Trim } from '../models/trim';

export class Selection {
  make: Make;
  model?: Model;
  trim?: Trim;

  makeId: number;
  modelId?: number;
  trimId?: number;
}
