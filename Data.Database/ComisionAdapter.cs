using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System;


namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            using (AcademiaContext context = new AcademiaContext())
            {
                return context.Comision.Include(c => c.Plan).ToList();
            }
        }

        public Comision GetOne(int id)
        {
            using (var context = new AcademiaContext())
            {
                return context.Comision.Include(c => c.Plan).FirstOrDefault(c => c.ID == id);
            }
        }

        protected void Insert(Comision comision)
        {
            using (var context = new AcademiaContext())
            {
                context.Plan.Attach(comision.Plan);
                context.Comision.Add(comision);
                context.SaveChanges();
            }
        }

        protected void Update(Comision comision)
        {
            using (var context = new AcademiaContext())
            {
                context.Entry(comision).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Comision comision)
        {
            using (var context = new AcademiaContext())
            {
                context.Comision.Remove(context.Comision.Find(comision.ID));
                context.SaveChanges();
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.New)
            {
                Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                Update(comision);
            }
            else if (comision.State == BusinessEntity.States.Deleted)
            {
                Delete(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
        public List<Comision> GetComisionPlanes(int idPlan)
        {

          
            List<Comision> comisiones = new List<Comision>();

            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from comisiones where PlanId = @id", SqlConn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idPlan;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Comision com = new Comision();
                    com.ID = (int)reader["id_comision"];
                    com.Descripcion = (string)reader["desc_comision"];
                    com.AnioEspecialidad = (int)reader["anio_especialidad"];
                    com.PlanId = (int)reader["planId"];
                    comisiones.Add(com);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos de la comision", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }
    }
}
