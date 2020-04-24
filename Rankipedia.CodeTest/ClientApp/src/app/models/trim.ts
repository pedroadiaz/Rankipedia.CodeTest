import { Model } from './model';
import { BaseEntity } from './base-entity';

export class Trim extends BaseEntity {
  modelId: number;

  model?: Model;

  fullName?: string;
}
