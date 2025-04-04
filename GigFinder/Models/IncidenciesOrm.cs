﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigFinder.Models
{
    public class IncidenciesOrm
    {
        public static List<Incidences> SelectGlobal()
        {
            List<Incidences> _incidences = (
                from incidence in Orm.bd.Incidences
                select incidence).ToList();

            return _incidences;
        }

        public static List<Incidences> SelectIncidenceByAdmin(int adminId)
        {
            List<Incidences> _incidences = (
                from incidence in Orm.bd.Incidences
                where incidence.admin_id == adminId
                select incidence).ToList();

            return _incidences;
        }

        public static void UpdateIncidence(int incidenceId, string status, string adminNote, int adminId)
        {
            var incidenceToUpdate = Orm.bd.Incidences.FirstOrDefault(i => i.id == incidenceId);

            if (incidenceToUpdate != null)
            {
                incidenceToUpdate.status = status;
                incidenceToUpdate.admin_note = adminNote;
                incidenceToUpdate.admin_id = adminId;

                Orm.bd.SaveChanges();
            }
        }

        public static void UpdateIncidenceAdmin(int adminId)
        {
            var incidenceToUpdate = Orm.bd.Incidences.FirstOrDefault(i => i.id == adminId);

            if (incidenceToUpdate != null)
            {
                incidenceToUpdate.admin_id = null;

                Orm.bd.SaveChanges();
            }
        }
    }
}
