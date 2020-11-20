export abstract class BaseResourceModel {
  id?: number;

  static FromJson(Data: any) {
    return Object.assign(this, Data);
  }
}
