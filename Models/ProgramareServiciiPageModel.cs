using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Partea2.Data;

namespace Partea2.Models
{
    public class ProgramareServiciiPageModel : PageModel
    {
        public List<AssignedServiciiData> AssignedServiciiDataList;
        
        public void PopulateAssignedServiciiData(Partea2Context context, Programare programare)
        {
            var allServicii = context.Serviciu;
            var programareServiciu = new HashSet<int>(
                programare.ProgramareServicii.Select(c => c.ServiciuId));
            AssignedServiciiDataList = new List<AssignedServiciiData>();
            foreach (var serv in allServicii)
            {
                AssignedServiciiDataList.Add(new AssignedServiciiData
                {
                    ServiciuID = serv.ID,
                    Nume = serv.Nume,
                    Assigned = programareServiciu.Contains(serv.ID)
                });   
            }
        }

        public void UpdateProgramareServicii (Partea2Context context, string[] selectedServicii, Programare appointmentToUpdate)
        {
            if(selectedServicii == null)
            {
                appointmentToUpdate.ProgramareServicii = new List<ProgramareServiciu>();
                return;
            }

            var selectedServiciiHS = new HashSet<string>(selectedServicii);
            var programareServicii = new HashSet<int>(appointmentToUpdate.ProgramareServicii.Select(c => c.Serviciu.ID));
            foreach(var serv in context.Serviciu)
            {
                if(selectedServiciiHS.Contains(serv.ID.ToString()))
                {
                    if (!programareServicii.Contains(serv.ID))
                    {
                        appointmentToUpdate.ProgramareServicii.Add(
                            new ProgramareServiciu
                            {
                                ProgramareId = appointmentToUpdate.ID,
                                ServiciuId = serv.ID
                            }) ;
                    }
                }
                else
                {
                    if(programareServicii.Contains(serv.ID))
                    {
                        ProgramareServiciu courseToRemove = appointmentToUpdate.ProgramareServicii.SingleOrDefault(i => i.ServiciuId == serv.ID);
                        context.Remove(courseToRemove);
                    }
                }
            }
        }
    }
}
