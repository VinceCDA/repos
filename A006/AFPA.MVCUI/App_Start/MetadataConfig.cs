using AFPA.BOL;
using AFPA.MVCUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AFPA.MVCUI.App_Start
{
    public static class MetadataConfig
    {
        /// <summary>
        /// Association des métadonnées complémentaires définies au niveau de la couche MVC
        /// </summary>
        public static void EtendreTypes()
        {
            AssociatedMetadataTypeTypeDescriptionProvider typeDescriptionProvider;

            typeDescriptionProvider = new AssociatedMetadataTypeTypeDescriptionProvider(
                typeof(OffreFormation),
                typeof(OffreFormationMetaDataEX));

            TypeDescriptor.AddProviderTransparent(typeDescriptionProvider, typeof(OffreFormation));

            typeDescriptionProvider = new AssociatedMetadataTypeTypeDescriptionProvider(
               typeof(Entreprise),
               typeof(EntrepriseMetaDataEX));

            TypeDescriptor.AddProviderTransparent(typeDescriptionProvider, typeof(Entreprise));
        }
    }
}