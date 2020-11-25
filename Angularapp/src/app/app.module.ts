import { UserComponent } from './user/user.component';
import { AuthInterceptor } from './auth/auth.interceptor';
import { UserService } from './shared/user.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './user/login/login.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { HomeComponent } from './home/home.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NavbarComponent } from './dashboard/navbar/navbar.component';
import { SidebarComponent } from './dashboard/sidebar/sidebar.component';
import { AppointmentComponent } from './user/appointment/appointment.component';
import { BankAccountComponent } from './user/bank-account/bank-account.component';
import { DoctorComponent } from './user/doctor/doctor.component';
import { PatientComponent } from './user/patient/patient.component';
import { ProductComponent } from './user/product/product.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { CandidateComponent } from './user/candidate/candidate.component';
import { CareerInformationComponent } from './user/career-information/career-information.component';
import { EducationalInfomationComponent } from './user/educational-infomation/educational-infomation.component';
import { PersonalInformationComponent } from './user/personal-information/personal-information.component';
import { RefereeInformationComponent } from './user/referee-information/referee-information.component';
import { TrainingInfornationComponent } from './user/training-infornation/training-infornation.component';
import { PreviewComponent } from './user/preview/preview.component';
import { MycvComponent } from './user/mycv/mycv.component';



@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    RegistrationComponent,
    LoginComponent,
    HomeComponent,
    BankAccountComponent,
/*     PaymentDetailsComponent,
    PaymentDetailComponent,
    PaymentDetailListComponent, */
    ProductComponent,
    DashboardComponent,
    NavbarComponent,
    SidebarComponent,
    DoctorComponent,
    PatientComponent,
    AppointmentComponent,
    CandidateComponent,
    CareerInformationComponent,
    EducationalInfomationComponent,
    PersonalInformationComponent,
    RefereeInformationComponent,
    TrainingInfornationComponent,
    PreviewComponent,
    MycvComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      progressBar: true
    }),
    FormsModule
  ],
  providers: [UserService, {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }