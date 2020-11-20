using MediatR;
using System.Threading.Tasks;
using System.Threading;
using Atlas.Application.Common.Interfaces;
using AutoMapper;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Atlas.Application.eCommerce.Bilhete.Queries.GetBilhete
{
    public class GetBilheteQuery : IRequest<BilheteDTO>
    {
        public GetBilheteQuery(string nrBilhete)
        {
            NrBilhete = nrBilhete;
        }

        public string NrBilhete { get; }
    }

    public class GetBilheteQueryHandler : IRequestHandler<GetBilheteQuery, BilheteDTO>
    {
        private readonly IeCommerceDbContextService contextService;
        private readonly IMapper mapper;

        public GetBilheteQueryHandler(IeCommerceDbContextService contextService, IMapper mapper)
        {
            this.contextService = contextService;
            this.mapper = mapper;
        }
        public async Task<BilheteDTO> Handle(GetBilheteQuery request, CancellationToken cancellationToken)
        {
            var context = contextService.GetContextVoucher(request.NrBilhete);

            string proposta = request.NrBilhete.Substring(0, request.NrBilhete.Length - 2);

            int passageiro = int.Parse(request.NrBilhete.Substring(request.NrBilhete.Length - 2));

            var poliza = await context.PoPolizas.Where(x => x.NumeroPoliza == proposta)
            .Include(x => x.PoBeneficiariosPoliza)
            .Include(x => x.PoDetalleFormasPago)
            .FirstOrDefaultAsync();

            var poBeneficiariosPoliza = context.PoBeneficiariosPoliza.Where(x => x.IdPoliza == poliza.IdPoliza && x.Secuencia == passageiro).FirstOrDefault();

            var pePersonaFisica = context.PePersonaFisica.Where(x => x.IdPersona == poBeneficiariosPoliza.IdPersona).Include(x => x.PeDocumentosPersonaFisica).Include(x => x.PeCanalesPersona).FirstOrDefault();

            var coAgencia = context.CoAgencias.Where(x => x.IdAgencia == poliza.IdAgencia).FirstOrDefault();

            var pePersonaJuridica = context.PePersonaJuridica.Where(x => x.IdPersonaJuridica == coAgencia.IdPersonaJuridica).FirstOrDefault();

            var bilhete = new BilheteDTO();

            bilhete.NrVoucher = request.NrBilhete;
            bilhete.Inicio = poliza.FechaDesde;
            bilhete.Termino = poliza.FechaHasta;
            bilhete.Emissao = poliza.FechaEmision;
            bilhete.DtCancelamento = poliza.FechaAnulacion;

            bilhete.ContatoEmergencia = poliza.NombreContactoEmergencia + " " + poliza.ApellidoContactoEmergencia;
            bilhete.ContatoEmergenciaTelefone = poliza.TelefonoContactoEmergencia;

            bilhete.Nome = pePersonaFisica.Nombre + " " + pePersonaFisica.Apellido;
            bilhete.sexo = pePersonaFisica.Sexo;
            bilhete.DtNascimento = pePersonaFisica.FechaNacimiento;
            bilhete.CPF = pePersonaFisica.PeDocumentosPersonaFisica.Where(x => x.IdTipoDocumento == 9).Select(x => x.Numero).FirstOrDefault();
            bilhete.Telefone = pePersonaFisica.PeCanalesPersona.Where(x => x.IdTipoCanal == 2).Select(x => x.DetalleCanal).FirstOrDefault();
            bilhete.Celular = pePersonaFisica.PeCanalesPersona.Where(x => x.IdTipoCanal == 3).Select(x => x.DetalleCanal).FirstOrDefault();
            bilhete.Email = pePersonaFisica.PeCanalesPersona.Where(x => x.IdTipoCanal == 1).Select(x => x.DetalleCanal).FirstOrDefault();

            bilhete.FormaPgto = context.BsFormasPago
            .Where(x => x.IdFormaPagoBs == poliza.PoDetalleFormasPago.FirstOrDefault().IdFormaPago)
            .Select(x => x.DescripcionFormaPagoBs)
            .FirstOrDefault();
            bilhete.Valor = poBeneficiariosPoliza.Importe;
            bilhete.ValorDolar = context.BsMonedasCotizaciones.Where(x => x.FechaCotizacion.CompareTo(bilhete.Emissao.Date) == 0).Select(x => x.Importe).FirstOrDefault();
            bilhete.Agencia = pePersonaJuridica.RazonSocial;
            bilhete.Cupom = poliza.CodigoCupon;
            bilhete.Produto = context.PrProducto.Where(x => x.IdProducto == poliza.IdProducto).Select(x => x.DenominacionProducto).FirstOrDefault();
            bilhete.Destino = context.BsPaises.Where(x => x.IdPais == poliza.IdDestino).Select(x => x.DenominacionPais).FirstOrDefault();

            return bilhete;
        }
    }
}
