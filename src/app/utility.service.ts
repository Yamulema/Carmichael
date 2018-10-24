import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class UtilityService {

  localStorageSet: boolean = false;

  checkLocalStorage() {
    localStorage.getItem("records") === null ? this.localStorageSet = false : this.localStorageSet = true;
  }

  saveLocalStorage(records) {
    localStorage.setItem("records", JSON.stringify(records));
  }

  getLocalStorage() {
    let records = JSON.parse(localStorage.getItem("records"));
    return records;
  }

  deleteLocalStorage() {
    localStorage.removeItem("records");
  }
  
}
