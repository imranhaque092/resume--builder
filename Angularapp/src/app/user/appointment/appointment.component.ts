import { PatientService } from './../../shared/patient.service';
import { AppointmentService } from './../../shared/appointment.service';
import { DoctorService } from './../../shared/doctor.service';
import { SpecialistService } from './../../shared/specialist.service';


import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormArray, Validators, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-appointment',
  templateUrl: './appointment.component.html',
  styleUrls: ['./appointment.component.css']
})
export class AppointmentComponent implements OnInit {


  appointmentForms: FormArray = this.fb.array([]);
    doctorList = [];
    patientList = [];
    specialistList = [];
    notification = null;
    
  
    constructor(private fb: FormBuilder,
      private doctorService: DoctorService,
      private patientService: PatientService,
      private specialistService: SpecialistService,
      private service: AppointmentService) { }
  
      ngOnInit() {
        this.doctorService.getDoctorList()
          .subscribe(res => this.doctorList = res as []);
          this.patientService.getPatientList()
          .subscribe(res => this.patientList = res as []);
        this.specialistService.getSpecialistList()
          .subscribe(res => this.specialistList = res as []);
      
        this.service.getAppointmentList().subscribe(
          res => {
            if (res == [])
              this.addAppointmentForm();
            else {
              
              (res as []).forEach((appointment: any) => {
                this.appointmentForms.push(this.fb.group({
                  appointmentID: [appointment.appointmentID],
                  doctorID: [appointment.doctorID, Validators.min(1)],
                  patientID: [appointment.patientID, Validators.min(1)],
                  specialistID: [appointment.specialistID, Validators.min(1)],
                  appointmentTime: [appointment.appointmentTime, Validators.required],
                  amount: [appointment.amount, Validators.required]
                }));
              });
            }
          }
        );
      }
    
      addAppointmentForm() {
        this.appointmentForms.push(this.fb.group({
          appointmentID: [0],
          doctorID: [0, Validators.min(1)],
          patientID: [0, Validators.min(1)],
          specialistID: [0, Validators.min(1)],
          appointmentTime: ['', Validators.required],
          amount: ['', Validators.required]
        }));
      }
    
      recordSubmit(fg: FormGroup) {
        if (fg.value.appointmentID == 0)
          this.service.postAppointment(fg.value).subscribe(
            (res: any) => {
              fg.patchValue({ appointmentID: res.appointmentID });
              this.showNotification('insert');
            });
        else
          this.service.putAppointment(fg.value).subscribe(
            (res: any) => {
              this.showNotification('update');
            });
      }
    
      onDelete(appointmentID, i) {
        if (appointmentID == 0)
          this.appointmentForms.removeAt(i);
        else if (confirm('Are you sure to delete this record ?'))
          this.service.deleteAppointment(appointmentID).subscribe(
            res => {
              this.appointmentForms.removeAt(i);
              this.showNotification('delete');
            });
      }
    
      showNotification(category) {
        switch (category) {
          case 'insert':
            this.notification = { class: 'text-success', message: 'Data saved!' };
            break;
          case 'update':
            this.notification = { class: 'text-primary', message: 'Data updated!' };
            break;
          case 'delete':
            this.notification = { class: 'text-danger', message: 'Data deleted!' };
            break;
    
          default:
            break;
        }
        setTimeout(() => {
          this.notification = null;
        }, 3000);
      }
  
  }
  
