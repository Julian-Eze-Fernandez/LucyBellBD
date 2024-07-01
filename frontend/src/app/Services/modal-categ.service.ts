import { Injectable, inject } from '@angular/core';
import { MatDialog } from "@angular/material/dialog";
import { ComponentType } from "@angular/cdk/portal";
import { Categoria } from "../Models/Categoria";

@Injectable({
  providedIn: 'root'
})
export class ModalCategService {

  constructor() { }

    private readonly _dialog = inject(MatDialog);

    openModal<CT, T = Categoria >(componentRef: ComponentType<CT>, data?: T, isEditing = false ): void {
        const config = {data, isEditing};

        this._dialog.open(componentRef, {
            data: config,
            width: '600px'
        } );
    }

    closeModal(): void{
        this._dialog.closeAll();
    }
}


