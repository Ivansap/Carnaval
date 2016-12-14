using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Suit
{
    
    class DataBase
    { 
        SqlConnection myConnection;
        public DataBase()
        {
            myConnection = new SqlConnection("user id=АНАСТАСИЯ; password=;server=АНАСТАСИЯ-ПК; Trusted_Connection=yes; database=Suit; connection timeout=30");
        }
    
        public DataTable getAllOrders()
        {
            string qu = "select o.id as [Номер], o.date_issue as [Дата выдачи], client.name as [Клиент], men.name as [Менеджер], Suit.name as [Костюм], Size.name as [Размер], body.count as [Количество], body.date_back_plan  as [Дата возврата(план)], body.date_back_fact  as [Дата возврата(факт)]" +
                "from Orders o "+
                "left join Clients client on client.id = o.client_FK "+
                "left join Menedger men on men.id = o.menedger_Fk "+
                "left join Body body on body.order_FK=o.id "+
                "left join suit_size ss on ss.id=body.suit_size_FK "+
                "left join Suit on Suit.id=ss.suit_id " +
                "left join Size on Size.id=ss.size_id order by 1";
            SqlDataAdapter da = new SqlDataAdapter(qu, myConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            DataTable dt = ds.Tables["t"];
            return dt;
        }

        public DataTable getClientsToCombo(string s)
        {
            string qu = "select top 10 client.id, client.name as [Клиент]" +
               "from Clients client where client.name like '"+s+"%'" +
               "order by 2";
            SqlDataAdapter da = new SqlDataAdapter(qu, myConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            DataTable dt = ds.Tables["t"];
            return dt;
        }
        public DataTable fillClientCombo()
        {
            string qu = "select top 10 client.id, client.name as [Клиент]" +
               "from Clients client " +
               "order by 2";
            SqlDataAdapter da = new SqlDataAdapter(qu, myConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "t");
            DataTable dt = ds.Tables["t"];
            return dt;
        }

    }
}
