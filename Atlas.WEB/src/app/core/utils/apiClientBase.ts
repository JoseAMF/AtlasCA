import { environment } from 'src/environments/environment';

export class ApiClientBase {
  baseApiUrl: string = environment.backend.baseURL;

  protected transformOptions(options: RequestInit) {
    return Promise.resolve(options);
  }

  protected transformResult(url: string, response: Response, processor: (response: Response) => any) {
    return processor(response);
  }

  protected getBaseUrl(defaultUrl: string, baseUrl?: string) {
    return this.baseApiUrl;
  }
}
