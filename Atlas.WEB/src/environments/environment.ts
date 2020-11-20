// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  backend: {
    baseURL: 'http://localhost:5000',
    // tslint:disable-next-line: max-line-length
    OCR: 'https://prod-57.westus.logic.azure.com:443/workflows/51d6045944f845ef9b300276073fd71a/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=9TLpN2SbReVp9TSztuyhKV5kUN986ny14Mw64v3pKq0',
    // tslint:disable-next-line: max-line-length
    Exemplo: 'https://prod-44.westus.logic.azure.com:443/workflows/60935f5fde624f43aed7142a79b104dd/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=y-fcoxEQsjK9wTqkgGgAUU3EXNr4w-FcwSFHfI7Y3t0',
    // tslint:disable-next-line: max-line-length
    ExemploPDF: 'https://prod-44.westus.logic.azure.com:443/workflows/60935f5fde624f43aed7142a79b104dd/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=y-fcoxEQsjK9wTqkgGgAUU3EXNr4w-FcwSFHfI7Y3t0',
    // tslint:disable-next-line: max-line-length
    SBC: 'https://prod-03.westus.logic.azure.com:443/workflows/29bfadf0bf0549068cdf3a068ac237cb/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=cPOeUwXTNBQTj0tZiB-yDVNz9f3uwC1ba_jXeP1b0jU'
  },
  O4D: {
    Endpoint_FLT: 'https://flt-sas-hml.omintseguros.com.br/api/SASData/Get_V2',
    Endpoint_O4D: 'http://srvseg-homolog.omintseguroviagem.com.br:9600/api/SASData/Get_V2',
    Usuario: 'carol.martins@flytour.com.br',
    Senha: '3846310081',
    PDF: 'http://p1.omintseguroviagem.com.br:7220/',
    PDFFT: 'https://flt-btr.omintseguros.com.br//'
  }
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
