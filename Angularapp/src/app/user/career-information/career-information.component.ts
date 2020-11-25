import { CareerInformationService } from './../../shared/career-information.service';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-career-information',
  templateUrl: './career-information.component.html',
  styleUrls: ['./career-information.component.css']
})
export class CareerInformationComponent implements OnInit {

  careerInformationForms: FormArray = this.fb.array([]);
  
  notification = null;

  constructor(private fb: FormBuilder,
   
    private service: CareerInformationService) { }

  ngOnInit() {
    

    /* this.service.getCareerInformationList().subscribe(
      res => {
        if (res == [])
          this.addCareerInformationForm();
        else {
         
          (res as []).forEach((careerInformation: any) => {
            this.careerInformationForms.push(this.fb.group({
              careerInformationID: [careerInformation.careerInformationID],
              companyName: [careerInformation.companyName, Validators.required],
              companyBusiness: [careerInformation.companyBusiness, Validators.required],
              designation: [careerInformation.designation, Validators.required],
              department: [careerInformation.department, Validators.required],
              startdate: [careerInformation.startdate, Validators.required],
              
              endDate: [careerInformation.endDate, Validators.required]
            }));
          });
        }
      }
    ); */
  }

  addCareerInformationForm() {
    this.careerInformationForms.push(this.fb.group({
      careerInformationID: [0],
      companyName: ['', Validators.required],
      companyBusiness: ['', Validators.required],
      designation: ['', Validators.required],
      department: ['', Validators.required],
      startdate: ['', Validators.required],
      endDate: ['', Validators.required]
    }));
  }

  recordSubmit(fg: FormGroup) {
    if (fg.value.careerInformationID == 0)
      this.service.postCareerInformation(fg.value).subscribe(
        (res: any) => {
          fg.patchValue({ careerInformationID: res.careerInformationID });
          this.careerInformationForms=null;
          this.showNotification('insert');
        });
    else
      this.service.putCareerInformation(fg.value).subscribe(
        (res: any) => {
          this.showNotification('update');
        });
  }

  onDelete(careerInformationID, i) {
    if (careerInformationID == 0)
      this.careerInformationForms.removeAt(i);
    else if (confirm('Are you sure to delete this record ?'))
      this.service.deleteCareerInformation(careerInformationID).subscribe(
        res => {
          this.careerInformationForms.removeAt(i);
          this.showNotification('delete');
        });
  }

  showNotification(category) {
    switch (category) {
      case 'insert':
        this.notification = { class: 'text-success', message: 'saved!' };
        break;
      case 'update':
        this.notification = { class: 'text-primary', message: 'updated!' };
        break;
      case 'delete':
        this.notification = { class: 'text-danger', message: 'deleted!' };
        break;

      default:
        break;
    }
    setTimeout(() => {
      this.notification = null;
    }, 3000);
  }

}
