import { NgModule } from '@angular/core';

import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { FloatLabelModule } from 'primeng/floatlabel';

@NgModule({
  exports: [
    ButtonModule,
    InputTextModule,
    TableModule,
    DialogModule,
    FloatLabelModule
  ]
})
export class PrimeNgModule {}
