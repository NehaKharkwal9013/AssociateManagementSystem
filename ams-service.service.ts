import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AssociatesMaster } from './AssociatesMaster';

@Injectable({
  providedIn: 'root'
})
export class AMSServiceService {

  url ='https://localhost:44321/api/AssociatesMaster/'
  constructor(private http:HttpClient) { }

  getAssociatesMasterList(): Observable<AssociatesMaster[]>{
    return this.http.get<AssociatesMaster[]>(this.url + 'List');
  }
  postAssociatesMaster(associatesMaster:AssociatesMaster): Observable<AssociatesMaster[]>{
  const httpHeaders ={headers:new HttpHeaders({'Content-Type':'application/json'})};
   return this.http.post<AssociatesMaster[]>(this.url + 'CreateRecord', associatesMaster,httpHeaders);
  }

  UpdateAssociatesMaster(associateMaster:AssociatesMaster): Observable<AssociatesMaster[]>{
    const httpHeaders ={headers:new HttpHeaders({'Content-Type':'application/json'})};
     return this.http.post<AssociatesMaster[]>(this.url + 'UpdateRecord ?id='+ associateMaster.associateId, associateMaster,httpHeaders);
    }
  
    getAssociatesMasterById(associateId: number): Observable<number>{
       return this.http.post<number>(this.url + 'DeleteRecord ?id='+ associateId,null);
      }

      getAssociatesMasterDetailsById(id: string): Observable<AssociatesMaster>{
        return this.http.get<AssociatesMaster>(this.url + 'Details ?id='+ id);
       }
}
