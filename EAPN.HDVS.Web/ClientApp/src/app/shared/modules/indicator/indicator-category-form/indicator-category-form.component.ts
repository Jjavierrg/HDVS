import { Component, EventEmitter, Input, Output, OnInit } from '@angular/core';
import { CategoriaDto, IndicadorDto, IndicadorSeguimientoDto } from 'src/app/core/api/api.client';

interface IIndicatorItem {
  category: CategoriaDto;
  indicator: IndicadorSeguimientoDto;
}

@Component({
  selector: 'app-indicator-category-form',
  templateUrl: './indicator-category-form.component.html',
  styleUrls: ['./indicator-category-form.component.scss'],
})
export class IndicatorCategoryFormComponent implements OnInit {
  @Input() categories: CategoriaDto[];
  @Input() reviewId: number;
  @Input() selection: IndicadorSeguimientoDto[];
  @Input() enabled: boolean = true;
  @Output() selectionChange = new EventEmitter<IndicadorSeguimientoDto[]>();

  public internalItems: IIndicatorItem[];
  public showCloseAll: boolean = false;

  constructor() {}

  ngOnInit(): void {
    this.internalItems = this.categories.map((x) => <IIndicatorItem>{ category: x, indicator: this.getCategorySelection(x) });
  }

  public onChange(): void {
    const others = this.getOtherDimensionSelection();
    const values = (this.internalItems || []).filter((x) => !!x.indicator.indicadorId);
    values.forEach((x) => (x.indicator.seguimientoId ? x.indicator.seguimientoId : this.reviewId));

    let result = [...values.map((x) => x.indicator), ... others];
    result = result.filter((value, index, self) => self.indexOf(value) === index);

    this.selectionChange.emit(result);
  }

  private getCategorySelection(category: CategoriaDto): IndicadorSeguimientoDto {
    const catIndicators = (category.indicadores || []).map((x) => x.id);

    if (!(catIndicators || []).length) {
      return new IndicadorSeguimientoDto({ seguimientoId: this.reviewId, indicadorId: null, observaciones: null });
    }

    const selected: IndicadorSeguimientoDto = (this.selection || []).find((x) => catIndicators.some((c) => c === x.indicadorId));
    return selected ? selected : new IndicadorSeguimientoDto({ seguimientoId: this.reviewId, indicadorId: null, observaciones: null });
  }

  private getOtherDimensionSelection(): IndicadorSeguimientoDto[] {
    const dimensionIndicators: number[] = this.categories.reduce((prev, cat) => {
      prev.push((cat.indicadores || []).map((x) => x.id));
      return prev;
    }, []);

    return (this.selection || []).filter(x => !dimensionIndicators.some(dim => dim === x.indicadorId));
  }
}
