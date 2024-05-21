using FashionWeek.Entiteti;
using NHibernate;
using NHibernate.Stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.DTO
{
    public class DTOManager
    {
        #region Maneken
        public static async Task<IList<ManekenPregled>> VratiManekene()
        {
            ISession? session = null;
            List<ManekenPregled> listaManekena = new List<ManekenPregled>();           
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    ISQLQuery query = session.CreateSQLQuery("SELECT * FROM MANEKEN");
                    query.AddEntity(typeof(Maneken));
                    IList<Maneken> manekeni = await query.ListAsync<Maneken>();
                   
                    foreach(var maneken in manekeni)
                    {
                        listaManekena.Add(new ManekenPregled(maneken));
                    }
                }
                return listaManekena;
            }
            catch(Exception)
            {
                return listaManekena;
            }
            finally
            {
                session?.Close();
            }
        }

        //public static async Task<bool> DodajManekena(Maneken maneken)
        //{
        //    ISession? session = null;
        //    try
        //    {
        //        session = DataLayer.GetSession();
        //        if (session != null)
        //        {
        //            Maneken m = await session.GetAsync<Maneken>(maneken.MBR);
        //            if (m == null)
        //            {
        //                await session.SaveAsync(m);
        //                await session.FlushAsync();
        //                return true;
        //            }
        //            else
        //            {
        //                throw new ArgumentException($"Maneken sa maticnim brojem {maneken.MBR} vec postoji!");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        session?.Close();
        //    }
        //}
        #endregion
    }
}
