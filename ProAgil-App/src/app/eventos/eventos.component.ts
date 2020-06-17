import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any;

  constructor(private http: HttpClient) { }

  // vai ser executado antes da interface do html ficar pronto
  ngOnInit() {
    this.getEventos(); // chamada do método abaixo.
  }

  getEventos() {
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.eventos = response;
      console.log(response);
    }, error => {
      console.error(error);
    });
  }

}
