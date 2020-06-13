using Atlas.Api.ServiceReference.MotorRegras;
using Atlas.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using Microsoft.Extensions.Configuration;

namespace Atlas.Api.Services
{
    public class RuleEngineService : IRuleEngineService
    {

        public RuleEngineService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public async Task<string> ValidateAgencyComission(string CNPJ, string Discount)
        {
            try
            {
                EndpointAddress endpoint = new EndpointAddress(Configuration["Endpoints:MotorRegras"]);
                var MRClient = new MotorRegrasServiceClient();

                ListarCamposRegrasRequest request = new ListarCamposRegrasRequest();

                request.GrupoRegra = "CUPOMVIAGEM";
                request.User = "I4PROREGRAS";
                request.Password = "I4PWD$%1Q9%$&XPYZ";

                var responseCampos = await MRClient.ListarCamposRegraAsync(request);

                if (responseCampos.BusinessErrors.Count() > 0)
                {
                    return responseCampos.BusinessErrors.First();
                }

                foreach (var campo in responseCampos.CamposRegra)
                {
                    if (campo.NomeCampo.Equals("CNPJEmpresa"))
                    {
                        campo.ValorCampo = CNPJ;
                    }
                    if (campo.NomeCampo.Equals("PercentualDesconto"))
                    {
                        campo.ValorCampo = Discount;
                    }
                }

                var requestVR = new ValidarRegistroRequest();
                requestVR.CamposValidacao = responseCampos.CamposRegra;
                requestVR.NomeGrupo = "CUPOMVIAGEM";
                requestVR.User = "I4PROREGRAS";
                requestVR.Password = "I4PWD$%1Q9%$&XPYZ";
                var responseVR = await MRClient.ValidarRegistroAsync(requestVR);

                if (responseVR.BusinessErrors.Count() > 0)
                {

                    if (responseVR.ListaCamposValidacao != null)
                    {
                        if (responseVR.ListaCamposValidacao.Count() > 0)
                        {
                            return responseVR.ListaCamposValidacao.First().RetornoValidacao;
                        }
                    }
                    else return responseVR.BusinessErrors.First();
                }
                // Verifica se alguma regra foi ativada
                if (responseVR.ListaRegrasValidacao.Count() > 0)
                {
                    return responseVR.ListaRegrasValidacao.First().DescricaoRegra;
                }
            }
            catch
            {
                return "Erro ao consultar a permissão para criar cupom com o percentual informado!";
            }

            return "";
        }
    }
}
