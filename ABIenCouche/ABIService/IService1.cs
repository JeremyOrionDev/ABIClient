﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ABIenCouche;
using ClassesDAO;

namespace ABIService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Collaborateur GetCollaborateur(int numColab);

        [OperationContract]
        string AddCollaborateur(Collaborateurs leCollaborateur);

        [OperationContract]
        Contrat GetContrat(Collaborateur leCollaborateur, Contrat leContrat);

    }


   
}
