using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PDesp
{
    class Despesa
    {
        public int IdDespesa { get; set; }
        public int TipoDespesaId { get; set; }
        public int MembroId { get; set; }
        public DateTime DataDespesa { get; set; }
        public double ValorDespesa { get; set; }
        public string ObsDespesa { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daDespesa;

            DataTable dtDespesa = new DataTable();

            try
            {
                daDespesa = new SqlDataAdapter("SELECT * FROM DESPESA", frmPrincipal.conexao);
                daDespesa.Fill(dtDespesa);
                daDespesa.FillSchema(dtDespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtDespesa;
        }


        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO DESPESA VALUES " + 
                    "( @tipodespesa_id_tipodespesa, @membro_id_membro, @data_despesa, @valor_despesa, @obs_despesa)", 
                    frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@tipodespesa_id_tipodespesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@membro_id_membro", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@data_despesa", SqlDbType.Date));
                mycommand.Parameters.Add(new SqlParameter("@valor_despesa", SqlDbType.Decimal));
                mycommand.Parameters.Add(new SqlParameter("@obs_despesa", SqlDbType.VarChar));
                

                mycommand.Parameters["@id_despesa"].Value = IdDespesa;
                mycommand.Parameters["@tipodespesa_id_tipodespesa"].Value = TipoDespesaId;
                mycommand.Parameters["@membro_id_membro"].Value = MembroId;
                mycommand.Parameters["@data_despesa"].Value = DataDespesa;
                mycommand.Parameters["@valor_despesa"].Value = ValorDespesa;
                mycommand.Parameters["@obs_despesa"].Value = ObsDespesa;
                

                nReg = mycommand.ExecuteNonQuery();

                retorno = nReg > 0 ? nReg : 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        
        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("UPDATE DESPESA SET " +
                    " tipodespesa_id_tipodespesa = @tipodespesa_id_tipodespesa, membro_id_membro = @membro_id_membro, " +
                    "data_despesa = @data_despesa, valor_despesa = @valor_despesa, obs_despesa = @obs_despesa " +
                    "WHERE id_despesa = @id_despesa",
                    frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@tipodespesa_id_tipodespesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@membro_id_membro", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@data_despesa", SqlDbType.Date));
                mycommand.Parameters.Add(new SqlParameter("@valor_despesa", SqlDbType.Decimal));
                mycommand.Parameters.Add(new SqlParameter("@obs_despesa", SqlDbType.VarChar));


                mycommand.Parameters["@id_despesa"].Value = IdDespesa;
                mycommand.Parameters["@tipodespesa_id_tipodespesa"].Value = TipoDespesaId;
                mycommand.Parameters["@membro_id_membro"].Value = MembroId;
                mycommand.Parameters["@data_despesa"].Value = DataDespesa;
                mycommand.Parameters["@valor_despesa"].Value = ValorDespesa;
                mycommand.Parameters["@obs_despesa"].Value = ObsDespesa;


                nReg = mycommand.ExecuteNonQuery();

                retorno = nReg > 0 ? nReg : 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        
        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM DESPESA " +
                                           "WHERE id_despesa = @id_despesa", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));

                mycommand.Parameters["@id_despesa"].Value = IdDespesa;

                nReg = mycommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nReg;
        }

    }
}
