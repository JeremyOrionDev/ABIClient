﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABIenCouche
{
    public class DictionnaireCollaborateur
    {
        public static SortedDictionary<int, Collaborateur> listCollaborateur =new SortedDictionary<int, Collaborateur> ();


        /// <summary>
        /// Ajout du collaborateur unColab en collection
        /// </summary>
        /// <param name="unColab">le collaborateur a ajouter en collection</param>
        public static void Ajouter(Collaborateur unColab)
        {
            
            if (!listCollaborateur.ContainsKey(unColab.Matricule))
            {
                listCollaborateur.Add(unColab.Matricule, unColab);
                
            }
            else throw new Exception(" le collaborateur est déja dans la base");
        }
        /// <summary>
        /// fonction de suppression prenant en paramètre le collaborateur complet (objet)
        /// </summary>
        /// <param name="unColab">le collaborateur à supprimer</param>
        /// <returns></returns>
        public static String SupprimerCollab(Collaborateur unColab)
        {
            String nom = unColab.NomCollaborateur;
            String prenom = unColab.PrenomCollaborateur;
            Int32 matricul = unColab.Matricule;
            if (listCollaborateur.ContainsKey(unColab.Matricule))
            {
                listCollaborateur.Remove(unColab.Matricule);
                return "le collaborateur matricule: " + matricul + " Nom: " + nom + " prénom: " + prenom+"a bien été supprimé";
            }
            else return "le collaborateur selectionné n'existe pas dans la base, merci de vérifier votre saisie";
        }
        /// <summary>
        /// Fonction de suppresion d'un collaborateur à partir du matricule de celui-ci
        /// </summary>
        /// <param name="unMatricule">le matricule du collaborateur à supprimer</param>
        /// <returns></returns>
        public static String SupprimerCollab(Int32 unMatricule)
        {
            String nom = listCollaborateur[unMatricule].NomCollaborateur;
            String prenom = listCollaborateur[unMatricule].PrenomCollaborateur;
            Int32 matricul = unMatricule;
            if (listCollaborateur.ContainsKey(unMatricule))
            {
                listCollaborateur.Remove(unMatricule);
                return "le collaborateur de matricule: " + matricul + " Nom: " + nom + " prenom: " + prenom + " a bien été supprimé";
            }
            else return "le matricule selectionné ne correspond à aucun collaborateur, merci de vérifier votre saisie.";
        }
        /// <summary>
        /// Remplacement des données du collaborateur par des nouvelles
        /// </summary>
        /// <param name="leColab">le collaborateur à mettre à jour</param>
        public  static void RemplacerColab(Collaborateur leColab)
        {
            if (listCollaborateur.ContainsKey(leColab.Matricule))
            {
                listCollaborateur[leColab.Matricule] = leColab;
            }
            else throw new Exception("le collaborateur ne peut pas être remplacé car il n'existe pas, il faut le créer");
        }

        /// <summary>
        /// Fonction de récupération d'un collaborateur à partir de son matricule
        /// </summary>
        /// <param name="unMatricule">le numéro de matricule du collaborateur à retrouver</param>
        /// <returns></returns>
        public static Collaborateur retrouverCollaborateur(Int32 unMatricule)
        {
            if (listCollaborateur.ContainsKey(unMatricule))
            {
                return listCollaborateur[unMatricule];
            }
            else throw new Exception("le matricule renseigné ne correspond à aucun collaborateur, merci de vérifier votre saisie");
        }

        public static DataTable ListCollab()
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Civ", typeof(String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(String)));
            
            foreach (KeyValuePair<Int32, Collaborateur> colab in listCollaborateur)
            {
                DR = dt.NewRow();
                DR[0] = colab.Value.Matricule;
                DR[1] = colab.Value.Civilite;
                DR[2] = colab.Value.NomCollaborateur;
                DR[3] = colab.Value.PrenomCollaborateur;
                DR[4] = colab.Value.RueCollab+" "+colab.Value.CpCollab+" "+colab.Value.VilleCollab;
                DR[5] = colab.Value.Telephone;
                dt.Rows.Add(DR);

            }
            return dt;
        }
        public static DataTable ListNomCollab(String unNom)
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Civ", typeof(String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(String)));

            foreach (KeyValuePair<Int32, Collaborateur> colab in listCollaborateur)
            {
                if(colab.Value.NomCollaborateur==unNom)
                {
                    DR = dt.NewRow();
                    DR[0] = colab.Value.Matricule;
                    DR[1] = colab.Value.Civilite;
                    DR[2] = colab.Value.NomCollaborateur;
                    DR[3] = colab.Value.PrenomCollaborateur;
                    DR[4] = colab.Value.RueCollab + " " + colab.Value.CpCollab + " " + colab.Value.VilleCollab;
                    DR[5] = colab.Value.Telephone;
                    dt.Rows.Add(DR);
                }
                DR = dt.NewRow();
                DR[0] = colab.Value.Matricule;
                DR[1] = colab.Value.Civilite;
                DR[2] = colab.Value.NomCollaborateur;
                DR[3] = colab.Value.PrenomCollaborateur;
                DR[4] = colab.Value.RueCollab + " " + colab.Value.CpCollab + " " + colab.Value.VilleCollab;
                DR[5] = colab.Value.Telephone;
                dt.Rows.Add(DR);

            }
            return dt;
        }
    }
}

