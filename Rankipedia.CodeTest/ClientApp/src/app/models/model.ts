import { Make } from './make';
import { BaseEntity } from './base-entity';

export class Model extends BaseEntity {
  makeId: number;

  make?: Make;
}
