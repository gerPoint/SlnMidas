﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlnMidas.Relatorio
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class midasEntities : DbContext
    {
        public midasEntities()
            : base("name=midasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<uspConsultarRomaneioNOVO_Result> uspConsultarRomaneioNOVO(Nullable<int> iNIntIDRomaneio, Nullable<System.DateTime> iNDataRomaneioInicio, Nullable<System.DateTime> iNDataRomaneioFim)
        {
            var iNIntIDRomaneioParameter = iNIntIDRomaneio.HasValue ?
                new ObjectParameter("INIntIDRomaneio", iNIntIDRomaneio) :
                new ObjectParameter("INIntIDRomaneio", typeof(int));
    
            var iNDataRomaneioInicioParameter = iNDataRomaneioInicio.HasValue ?
                new ObjectParameter("INDataRomaneioInicio", iNDataRomaneioInicio) :
                new ObjectParameter("INDataRomaneioInicio", typeof(System.DateTime));
    
            var iNDataRomaneioFimParameter = iNDataRomaneioFim.HasValue ?
                new ObjectParameter("INDataRomaneioFim", iNDataRomaneioFim) :
                new ObjectParameter("INDataRomaneioFim", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspConsultarRomaneioNOVO_Result>("uspConsultarRomaneioNOVO", iNIntIDRomaneioParameter, iNDataRomaneioInicioParameter, iNDataRomaneioFimParameter);
        }
    }
}
