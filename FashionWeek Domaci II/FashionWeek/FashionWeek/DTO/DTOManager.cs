using FashionWeek.Entiteti;
using NHibernate;
using NHibernate.Exceptions;
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
        public static async Task<Maneken> VratiManekena(string mbr)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    Maneken maneken = await session.GetAsync<Maneken>(mbr);
                    return maneken;
                }
                throw new Exception("Greska pri vraćanju manekena!"); 
            }
            finally
            {
                session?.Close();
            }
        }
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

        public static async Task<bool> DodajManekena(Maneken maneken)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.SaveAsync(maneken);
                    await session.FlushAsync();
                    return true;
                }
                else
                {
                    throw new Exception("Greška pri povezivanju sa bazom!");
                }
            }
            finally
            {
                session?.Close();
            }
        }

        public static async Task<bool> AzurirajManekena(Maneken maneken)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.UpdateAsync(maneken);
                    await session.FlushAsync();
                    return true;
                }
                else
                {
                    throw new Exception("Greška pri povezivanju sa bazom!");
                }
            }
            finally
            {
                session?.Close();
            }
        }

        public static async void ObrisiManekena(Maneken maneken)
        {
            ISession? session = null;
            try
            {
                session = DataLayer.GetSession();
                if (session != null)
                {
                    await session.DeleteAsync(maneken);
                    await session.FlushAsync();
                }
                else
                {
                    throw new Exception("Greška pri povezivanju sa bazom!");
                }
            }
            finally
            {
                session?.Close();
            }
        }
        #endregion
    }
}
