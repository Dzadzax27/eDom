import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {MyConfig} from "../my-config";

@Injectable({
    providedIn: 'root'
})
export class FileService {


    constructor(private http: HttpClient) {}


}
