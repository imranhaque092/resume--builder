import { Component, OnInit } from '@angular/core';
import { CandidateService } from 'src/app/shared/candidate.service';

@Component({
  selector: 'app-mycv',
  templateUrl: './mycv.component.html',
  styleUrls: ['./mycv.component.css']
})
export class MycvComponent implements OnInit {

  personData:CandidateService[];

  constructor(

    private personService:CandidateService
  ) { }

  ngOnInit() {
 
    this.loadPersonData();
  }


    loadPersonData(){
      this.personService.getPersontitleData().subscribe((data)=>{
        console.log("data",data)
        this.personData=data;
        
      })
    }
}



