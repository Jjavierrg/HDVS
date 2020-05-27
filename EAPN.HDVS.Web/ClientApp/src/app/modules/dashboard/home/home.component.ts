import { Component, OnInit } from '@angular/core';
import { FileUpload, UploadType } from 'src/app/core/http/file-upload';
import { UploadService } from 'src/app/core/services/upload.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  public files: FileUpload[] = [];

  constructor(private uploadService: UploadService) {
  }

  async ngOnInit() {
  }

  public onUpload(files: FileUpload[]) {
    files.forEach(x => this.uploadService.addToQueue(x));
  }

  public onFileAdded(files: File[]) {
    const uploads = files.map(x => new FileUpload(x, { TipoId: UploadType.Imagenes, FichaId: 1, OrganizacionId: 1 }));
    this.files.push(...uploads);
    this.onUpload(uploads);
  }

  public onFileCancel(file: FileUpload) {
    this.files = this.files.filter((x) => x !== file);
  }
}
