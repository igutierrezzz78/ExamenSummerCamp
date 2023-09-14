import { Component, OnDestroy, OnInit } from '@angular/core';
import { IUsuarioRegistro } from './registro';
import { IUsuario } from './usuarios';
import { Subscription } from 'rxjs';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ExamenService } from './examen.servicios';

@Component({
  selector: 'app-examen',
  templateUrl: './examen.component.html',
  styleUrls: ['./examen.component.css']
})
export class ExamenComponent implements OnInit, OnDestroy{
  sub!: Subscription;
  resultRegistro: IUsuario | undefined; 
  userName: string="";
  password: string="";
  confirmarPassword: string="";
  nombre: string="";
  apellido: string ="";
  fechaNacimiento: string ="";
  telefono: string ="";
  usuarios: IUsuario[] = [];
  myForm: FormGroup;

  constructor(private examenService : ExamenService, 
    public formulario: FormBuilder) 
    {
    this.myForm = this.formulario.group({
      userName: ['',[Validators.required]],
      password: ['',[Validators.required,Validators.minLength(9)]],
      confirmarPassword: ['',[Validators.required]],
      apellido: ['',[Validators.required]],
      nombre: ['', [Validators.required,Validators.maxLength(50)]],
      telefono: ['', [Validators.maxLength(25)]],
      fechaNacimiento: ['', [Validators.required,Validators.max(new Date(new Date().getFullYear() - 16).getTime())]],     
    });
  }

  registro(myForm : FormGroup): void {
    const registroDTO: IUsuarioRegistro = {
      userName : myForm.value.userName,
      password : '123456789',
      confirmarPassword : '123456789',
      nombre: myForm.value.nombre,
      apellido: myForm.value.apellido,
      telefono: myForm.value.telefono,
      fechaNacimiento: myForm.value.fechaNacimiento,
    };
    this.postRegistro(registroDTO);
  }

  postRegistro(registroDTO: IUsuarioRegistro): void {
    this.examenService.postRegistro(registroDTO).subscribe({
      next:(registro) => {
        this.resultRegistro = registro;
        this.cargarLista()
      }
    });  
   }
  
  cargarLista(){
    this.sub = this.examenService.getUsuarios().subscribe({
      next: usuarios => {
        this.usuarios = usuarios;
      },
    });
  }

  ngOnInit(): void {
    this.sub = this.examenService.getUsuarios().subscribe({
      next: usuarios => {
        this.usuarios = usuarios;
      },
    });
  }

  ngOnDestroy(): void {
    this.sub!.unsubscribe;
  }
}
