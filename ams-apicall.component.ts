import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { AMSServiceService } from '../ams-service.service';
import { AssociatesMaster } from '../AssociatesMaster';

@Component({
  selector: 'app-ams-apicall',
  templateUrl: './ams-apicall.component.html',
  styleUrls: ['./ams-apicall.component.css']
})
