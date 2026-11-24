import type { Estudio } from '../models/Estudio';
import { EstudioService } from '../services/EstudioService';
import { CrudController } from './CrudController';

export class EstudioController extends CrudController<Estudio> {
  private static instancia: EstudioController;
  private constructor() { super(new EstudioService()); }
  static getInstance(): EstudioController {
    EstudioController.instancia ??= new EstudioController();
    return EstudioController.instancia;
  }
}
