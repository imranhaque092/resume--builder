import { CandidateService } from './../../shared/candidate.service';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, Validators, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.css']
})
export class CandidateComponent implements OnInit {
  candidateForms: FormArray = this.fb.array([]);
  
  notification = null;

  constructor(private fb: FormBuilder,
   
    private service: CandidateService) { }

  ngOnInit() {
    

     this.service.getCandidateList().subscribe(
      res => {
        if (res == [])
          this.addCandidateForm();
        else {
         
          (res as []).forEach((candidate: any) => {
            this.candidateForms.push(this.fb.group({
              candidateID: [candidate.candidateID],
              firstName: [candidate.firstName, Validators.required],
              lastName: [candidate.lastName, Validators.required],
              fatherName: [candidate.fatherName, Validators.required],
              motherName: [candidate.motherName, Validators.required],
              dateOfBirth: [candidate.dateOfBirth, Validators.required],
              gender: [candidate.gender, Validators.required],
              maritalStatus: [candidate.maritalStatus, Validators.required],
              permanentAddress: [candidate.permanentAddress, Validators.required],
              presentAddress: [candidate.presentAddress, Validators.required],
              lavelOfEducation: [candidate.lavelOfEducation, Validators.required],
              examName: [candidate.examName, Validators.required],
              majorSubject: [candidate.majorSubject, Validators.required],
              instituteName: [candidate.instituteName, Validators.required],
              result: [candidate.result, Validators.required],
              yearOfPassing: [candidate.yearOfPassing, Validators.required],
              duration: [candidate.duration, Validators.required],
              companyName: [candidate.companyName, Validators.required],
              companyBusiness: [candidate.companyBusiness, Validators.required],
              designation: [candidate.designation, Validators.required],
              department: [candidate.department, Validators.required],
              startdate: [candidate.startdate, Validators.required],
              endDate: [candidate.endDate, Validators.required]
            }));
          });
        }
      }
    ); 
  }

  addCandidateForm() {
    this.candidateForms.push(this.fb.group({
      candidateID: [0],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      fatherName: ['', Validators.required],
      motherName: ['', Validators.required],
      dateOfBirth: ['', Validators.required],
      gender: ['', Validators.required],
      maritalStatus: ['', Validators.required],
      permanentAddress: ['', Validators.required],
      presentAddress: ['', Validators.required],
      lavelOfEducation: ['', Validators.required],
      examName: ['', Validators.required],
      majorSubject: ['', Validators.required],
      instituteName: ['', Validators.required],
      result: ['', Validators.required],
      yearOfPassing: ['', Validators.required],
      duration: ['', Validators.required],
      companyName: ['', Validators.required],
      companyBusiness: ['', Validators.required],
      designation: ['', Validators.required],
      department: ['', Validators.required],
      startdate: ['', Validators.required],
      endDate: ['', Validators.required]
    }));
  }

  recordSubmit(fg: FormGroup) {
    if (fg.value.candidateID == 0)
      this.service.postCandidate(fg.value).subscribe(
        (res: any) => {
          fg.patchValue({ candidateID: res.candidateID });
          this.candidateForms=null;
          this.showNotification('insert');
        });
    else
      this.service.putCandidate(fg.value).subscribe(
        (res: any) => {
          this.showNotification('update');
        });
  }

  onDelete(candidateID, i) {
    if (candidateID == 0)
      this.candidateForms.removeAt(i);
    else if (confirm('Are you sure to delete this record ?'))
      this.service.deleteCandidate(candidateID).subscribe(
        res => {
          this.candidateForms.removeAt(i);
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
