import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { IRecord } from './record';
import { Observable, throwError } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class RecordService {

  private XMLDocument = "/api/xml/GetXElements";
  //private XMLDocument = "Default.aspx/TestXMLReader";
  //private XMLDocument = "/POCXml/api/xml/GetXElements";

  constructor(private http: HttpClient) { }

  getRecordsXML(): Observable<IRecord[]> {

    return this.http.get<IRecord[]>(this.XMLDocument).pipe(
      tap(data => console.log()),
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse) {
    let errorMessage = '';
    errorMessage = err.message;

    console.log(errorMessage);
    return throwError(errorMessage) 
  }
}
