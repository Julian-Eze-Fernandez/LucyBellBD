import { Component } from '@angular/core';
import { MatDialogContent } from '@angular/material/dialog';
import { MatFormField, MatLabel } from '@angular/material/form-field';
import { MatInput } from '@angular/material/input';

@Component({
  selector: 'app-modal-categ',
  standalone: true,
  imports: [MatLabel,MatFormField,MatInput,MatDialogContent],
  templateUrl: './modal-categ.component.html',
  styleUrl: './modal-categ.component.css'
})
export class ModalCategComponent {

}
