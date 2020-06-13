using Atlas.Domain.Entities.I4Pro;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atlas.Application.Common.Interfaces
{
    public interface II4ProDbContext
    {
        DbSet<VApoliceCorrSegurado> VApoliceCorrSegurado { get; set; }
        DbSet<VSinistroCovidSusep> VSinistroCovidSusep { get; set; }
        [Obsolete]
        DbQuery<QProdutosAtivos> QProdutosAtivos { get; set; }
        [Obsolete]
        DbQuery<QPViagemPrecoCoberturaBasicaImportacao> QPViagemPrecoCoberturaBasicaImportacao { get; set; }
        [Obsolete]
        DbQuery<QPViagemPrecoCoberturaAdicionalImportacao> QPViagemPrecoCoberturaAdicionalImportacao { get; set; }
    }

}
