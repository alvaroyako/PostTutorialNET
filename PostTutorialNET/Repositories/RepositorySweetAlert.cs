using PostTutorialNET.Data;
using PostTutorialNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostTutorialNET.Repositories
{
    public class RepositorySweetAlert
    {
        private SweetAlertContext context;

        public RepositorySweetAlert(SweetAlertContext context)
        {
            this.context = context;
        }


        public List<Juego> GetJuegos()
        {
            var consulta = from datos in this.context.Juegos
                           select datos;
            return consulta.ToList();
        }

        public Juego FindJuego(int idjuego)
        {
            return this.context.Juegos.SingleOrDefault(z => z.IdJuego == idjuego);
        }

        public void DeleteJuego(int idjuego)
        {
            Juego juego = this.FindJuego(idjuego);
            this.context.Juegos.Remove(juego);
            this.context.SaveChanges();
        }
    }
}
