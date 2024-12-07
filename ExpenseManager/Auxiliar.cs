using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager
{
    enum WaysToLog
    {
        BY_PASS,
        BY_LOGIN
    }
    class Auxiliar
    {
        public static int id_logged;
        public static int id_note;
        public static int id_note_to_delete;
        public static string LoggUserName;
        //public static Form form1;
        public static Form login;
        public static Form admin;
        public static Form main;
        public static Dictionary<int, string> dic = new Dictionary<int, string>();
        internal static int messageId;
        public static bool DataBaseUpdated { get; set; }

        public static string getAppName()
        {
            return "Expense Manager -";
        }

        public static string getTextCorrective()
        {
            return "*/ Este texto se crea automáticamente cada vez que usted realiza un depósito o una extracción en modo correctivo mediante el código < $correctivo > /*";
        }

        public static decimal? GetSaldoAccount(EXPENSE_MANAGERDataSetTableAdapters.movimientosTableAdapter movi, int id_account)
        {
            decimal? total = 0;
            if (movi.SumMontoScalarQuery("dep", id_account, Auxiliar.id_logged) != null)
            {
                total += movi.SumMontoScalarQuery("dep", id_account, Auxiliar.id_logged);
            }

            if (movi.SumMontoScalarQuery("rec", id_account, Auxiliar.id_logged) != null)
            {
                total += movi.SumMontoScalarQuery("rec", id_account, Auxiliar.id_logged);
            }

            if (movi.SumMontoScalarQuery("tra", id_account, Auxiliar.id_logged) != null)
            {
                total -= movi.SumMontoScalarQuery("tra", id_account, Auxiliar.id_logged);
            }

            if (movi.SumMontoScalarQuery("ext", id_account, Auxiliar.id_logged) != null)
            {
                total -= movi.SumMontoScalarQuery("ext", id_account, Auxiliar.id_logged);
            }

            return total;
        }
    }
}
