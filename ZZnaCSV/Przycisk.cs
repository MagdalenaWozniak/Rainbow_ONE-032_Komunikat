using Hydra;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.IO;

[assembly: CallbackAssemblyDescription(Name: "ONE-032 Komunikat",
                                           Description: "Komunikat o zapisach do powiązania",
                                           Author: "OneSupport",
                                           Version: "1.0",
                                           SystemVersion: "2022.0.2",
                                           Created: "02-10-2023")]
namespace Komunikat
{
    [SubscribeProcedure(Procedures.KAZLista, "Komunikat")]
    public class DodajFakture : Callback
    {
        private ClaWindow zakladkaTabWewnetrzne;
        private ClaWindow listaPoz;
        long sValue;
        // private Dane dane;
        public override void Init()
        {
            AddSubscription(true, 0, Events.CloseWindow, new TakeEventDelegate(OnCloseWindow));
            AddSubscription(false, 0, Events.ResizeWindow, new TakeEventDelegate(Resize));
        }



        private bool OnCloseWindow(Procedures ProcId, int ControlId, Events Event)
        {
            ClaWindow Parent = GetWindow();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Rectangle WndBnd = GetWindow().Bounds;
            zakladkaTabWewnetrzne = GetWindow().AllChildren["?RaportTab"];
            listaPoz = zakladkaTabWewnetrzne.AllChildren["?List"];
            Runtime.WindowController.PostEvent(listaPoz.Id, Events.NewSelection);
            sValue = Zapisy.KAZ_KRPNumer;
            //zakladkaTabWewnetrzne = GetWindow().AllChildren["?TabFS"];

            try
            {



                string connectionString = "";
                if (Runtime.ConfigurationDictionary.Baza.ToString().Substring(0, 25) == "ERPXL_RainbowTours_TESTRT")
                    connectionString = @"Data Source = XL2; Initial Catalog = ERPXL_RainbowTours_TESTRT; User ID = onesupport; Password=g54q@8w#v$Y.Df_8f4hg";
                else if (Runtime.ConfigurationDictionary.Baza.ToString().Substring(0, 18) == "ERPXL_RainbowTours")
                    connectionString = @"Data Source = XL2; Initial Catalog = ERPXL_RainbowTours; User ID = onesupport; Password=g54q@8w#v$Y.Df_8f4hg";
                else if (Runtime.ConfigurationDictionary.Baza.ToString().Substring(0, 13) == "ERPXL_RT_Test")
                    connectionString = @"Data Source = XL2; Initial Catalog = ERPXL_RT_Test; User ID = onesupport; Password=g54q@8w#v$Y.Df_8f4hg";

                //MessageBox.Show(connectionString);

                string czyPRZ = "if exists(SELECT * FROM cdn.Zapisy WHERE KAZ_KRPNumer = " + sValue + " and KAZ_NumerDokumentu = 'PRZ' and KAZ_Anulowany=0)SELECT 'TAK' else SELECT 'NIE'";

                if (ConnectToSQL(connectionString, czyPRZ) == "TAK")
                {
                    bool bylo = false;
                    List<Zapis> zapisyPRZ = SelectListRowColumn("SELECT * FROM cdn.Zapisy WHERE KAZ_KRPNumer = " + sValue + " and KAZ_NumerDokumentu = 'PRZ' and KAZ_Anulowany=0", "cdn.Zapisy", connectionString);

                    foreach (Zapis zapisPRZ in zapisyPRZ)
                    {
                        string dataQuery = "SELECT DateAdd(day, " + zapisPRZ.KAZ_DataZapisu + " - 4, '1801-01-01')";
                        DateTime data = Convert.ToDateTime(ConnectToSQL(connectionString, dataQuery));
                        int data2 = 0;
                        if (data.DayOfWeek == DayOfWeek.Monday)
                            data2 = zapisPRZ.KAZ_DataZapisu - 3;
                        else
                            data2 = zapisPRZ.KAZ_DataZapisu - 1;

                        string nrRachunkuQuery = "SELECT KAR_NrRachunku from cdn.Raporty join cdn.Rejestry on KRP_Seria = KAR_Seria WHERE KRP_GIDNumer = " + zapisPRZ.KAZ_KRPNumer;
                        string nrRachunku = ConnectToSQL(connectionString, nrRachunkuQuery);



                        //string tresc = znajdzTresc(zapisPRZ.KAZ_Tresc);

                        string zapisROZQuery = "SELECT [KAZ_GIDTyp] ,[KAZ_GIDFirma] ,[KAZ_GIDNumer] ,[KAZ_GIDLp] ,[KAZ_KRPTyp],[KAZ_KRPFirma],[KAZ_KRPNumer],[KAZ_KRPLp],[KAZ_Rok],[KAZ_Seria] "
                                                + "  ,[KAZ_NumerKwitu] ,[KAZ_NumerDokumentu] ,[KAZ_KAOTyp] ,[KAZ_KAOFirma] ,[KAZ_KAONumer] ,[KAZ_KAOLp] ,[KAZ_KNTTyp] ,[KAZ_KNTFirma] ,[KAZ_KNTNumer] "
                                                + " ,[KAZ_KNTLp],[KAZ_KontoPrzec],[KAZ_KontoPrzecR] ,[KAZ_DataZapisu] ,[KAZ_DataDokumentu] ,[KAZ_RP] ,[KAZ_Znak] ,[KAZ_Kwota] ,[KAZ_Pozostaje] "
                                                + " ,[KAZ_Waluta] ,[KAZ_NrKursu] ,[KAZ_KursL] ,[KAZ_KursM] ,[KAZ_Rozliczony] ,[KAZ_Tresc] ,[KAZ_TStamp] ,[KAZ_OpeTypR] ,[KAZ_OpeFirmaR],[KAZ_OpeNumerR] "
                                                + ",[KAZ_OpeLpR],[KAZ_OpeTypB],[KAZ_OpeFirmaB],[KAZ_OpeNumerB],[KAZ_OpeLpB],[KAZ_CiagNumeracji],[KAZ_Zaksiegowano],[KAZ_Aktywny] ,[KAZ_ICVTStamp] "
                                                + "  ,[KAZ_ICVStatus]  ,[KAZ_ICVNumer]  ,[KAZ_WalutaRoz]  ,[KAZ_KwotaRoz]  ,[KAZ_PozostajeRoz]  ,[KAZ_KwotaSys] ,[KAZ_PozostajeSys] ,[KAZ_PozostajeWycena] "
                                                + "  ,[KAZ_PozostajeWycenaSys] ,[KAZ_WycenaRK] ,[KAZ_WycenaRKStan] ,[KAZ_DokID] ,[KAZ_KNDTyp] ,[KAZ_KNDFirma] ,[KAZ_KNDNumer] ,[KAZ_KNDLp] ,[KAZ_CechaOpis] "
                                                + " ,[KAZ_Zaliczka] ,[KAZ_Anulowany],[KAZ_StRIdW] ,[KAZ_Opis] ,[KAZ_OPETypRm] ,[KAZ_OPEFirmaRm] ,[KAZ_OPENumerRm] ,[KAZ_OPELpRm] ,[KAZ_OPETypBm] "
                                                + " ,[KAZ_OPEFirmaBm] ,[KAZ_OPENumerBm] ,[KAZ_OPELpBm] ,[KAZ_TStampM] ,[KAZ_StanRealizacji] ,[KAZ_CzasZapisu] ,[KAZ_Miesiac] ,[KAZ_OkrId] ,[KAZ_Wyceniony] "
                                                + " ,[KAZ_WycenaKolejnosc]  ,[KAZ_KursWgWyceny]  ,[KAZ_Wynagrodzenie]  ,[KAZ_ZapisZerujacy]  ,[KAZ_RaportBO]  ,[KAZ_ZewnetrznyId]  ,[KAZ_ZewnetrznySys] "
                                                + " ,[KAZ_ZewnetrznyTyp],[KAZ_Lokata],[KAZ_LokataTermin],[KAZ_LokataTypId] ,[KAZ_LokataOtwNumer] ,[KAZ_LokataNrRachunku] ,[KAZ_LokataNRB] ,[KAZ_ZWyciagu] "
                                                + " ,[KAZ_CDC] ,[KAZ_TrescCDC] ,[KAZ_WirtualnyEQ] ,[KAZ_NrRachunku] ,[KAZ_SplitPNumer] ,[KAZ_BankKodOperacji] ,[KAZ_GUID] ,[KAZ_OperatorPOS] ,[KAZ_KontrahentCDC] "
                                                + " ,[KAZ_DoWyjasnienia] ,[KAZ_EndToEndId] ,[KAZ_AutoRozliczenie] ,[KAZ_BbonId] ,[KAZ_WTrakciePrzetwarzania] FROM cdn.Zapisy "
                                                + " join cdn.Rejestry on KAZ_Seria=KAR_Seria where KAZ_RP=1 and KAZ_Kwota=" + zapisPRZ.KAZ_Kwota.ToString().Replace(",", ".") + " and "
                                                + "KAZ_DataZapisu IN (" + zapisPRZ.KAZ_DataZapisu + ", " + data2 + ") and "
                                                + " KAR_NrRachunku like '%" + zapisPRZ.KAZ_NrRachunku.Substring(12) + "%' and KAZ_NumerDokumentu not like '%PRZ%'"; 
                        /*TextWriter tw2 = new StreamWriter(@"C:\test.txt", append: false);
                        tw2.Write(zapisROZQuery);
                        tw2.Close();*/
                        List<Zapis> zapisyROZ = SelectListRowColumn(zapisROZQuery, "cdn.Zapisy", connectionString);
                        if (zapisyROZ.Count > 0)
                        {
                            MessageBox.Show("W tym raporcie są zapisy do powiązania. Proszę użyć dodatku '" +
                                "PO'", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch(Exception e)
            {

                MessageBox.Show("Błąd komunikatu: " + e.ToString(), "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }


                            //listID = GetWindow().AllChildren["?Handlowe"].Id;      //tu sprawdzic

                            //pobrane z pola w zakładce Raporty
                            return true;
        }

        public bool Resize(Procedures ProcId, int ControlId, Events Event)
        {
            
            return true;
        }

        public bool OnSave(Procedures ProcId, int ControlId, Events Event)
        {
           
            //MessageBox.Show("Email");
            return true;
        }

        public string ConnectToSQL(string connection_string, string query)
        {
            string str = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Query");
                    if (dataSet.Tables.Count == 0)
                    {
                        return "";
                    }
                    foreach (DataRow row in (InternalDataCollectionBase)dataSet.Tables[0].Rows)
                    {
                        str = row[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                str = str + "Bład SQL:" + ex.ToString() + "\n";
            }
            return str;
        }

        private bool BtnOnMouseDown(Procedures ProcId, int ControlId, Events Event)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Runtime.ConfigurationDictionary.Baza.ToString().Substring(0, 9) == "ERPXL_E_P")
            {
               // MessageBox.Show("Po wybraniu pliku nastąpi dodawanie danych do bazy ERPXL_E_P", "Komunikat",
                // MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("C:\\OneSupport\\ImportDekretow\\Test\\ImportDekretow.exe");
            }
            else if (Runtime.ConfigurationDictionary.Baza.ToString().Substring(0, 7) == "ERPXL_E")
            {
                //MessageBox.Show("Po wybraniu pliku nastąpi dodawanie danych do bazy ERPXL_E", "Komunikat",
                 //MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("C:\\OneSupport\\ImportDekretow\\Produkcja\\ImportDekretow.exe");
            }
            

            return true;
        }

        string znajdzTresc(string tresc)
        {

            string[] nazwy = tresc.Split(' ');

            for (int i = 0; i < nazwy.Length; i++)
            {
                try
                {
                    if (nazwy[i].Contains("F") && Convert.ToDouble(nazwy[i].Trim().Substring(1)) != 0)

                        return nazwy[i];
                }
                catch
                {
                    //MessageBox.Show(nazwy[i].Trim().Substring(1));
                }
            }
            return tresc;


        }

        public string Update(string sql, string connection_string)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    connection.Open();
                    adapter.UpdateCommand = new SqlCommand(sql, connection);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    //MessageBox.Show("Row updated !! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sql;
        }


        public static List<Zapis> SelectListRowColumn(string query, string srcTableName, string connection_string)
        {
            List<string> str = new List<string>();
            List<Zapis> myList = new List<Zapis>();
            string sttr = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, srcTableName);
                    foreach (DataRow row in (InternalDataCollectionBase)dataSet.Tables[0].Rows)
                    {
                        foreach (DataColumn column in (InternalDataCollectionBase)dataSet.Tables[0].Columns)
                        {
                            str.Add(row[column].ToString());

                            //MessageBox.Show(column + ": " + row[column].ToString());
                        }
                        myList.Add(new Zapis(str[0], str[1], str[2], str[3], str[4], str[5], str[6], str[7], str[8], str[9], str[10], str[11], str[12], str[13], str[14], str[15], str[16],
                                                str[17], str[18], str[19], str[20], str[21], str[22], str[23], str[24], str[25], str[26], str[27], str[28], str[29], str[30], str[31], str[32],
                                                str[33], str[34], str[35], str[36], str[37], str[38], str[39], str[40], str[41], str[42], str[43], str[44], str[45], str[46], str[47], str[48],
                                                str[49], str[50], str[51], str[52], str[53], str[54], str[55], str[56], str[57], str[58], str[59], str[60], str[61], str[62], str[63], str[64],
                                                str[65], str[66], str[67], str[68], str[69], str[70], str[71], str[72], str[73], str[74], str[75], str[76], str[77], str[78], str[79], str[80],
                                                str[81], str[82], str[83], str[84], str[85], str[86], str[87], str[88], str[89], str[90], str[91], str[92], str[93], str[94], str[95], str[96],
                                                str[97], str[98], str[99], str[100], str[101], str[102], str[103], str[104], str[105], str[106], str[107], str[108], str[109], str[110]));
                        str.Clear();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(sttr = sttr + "Bład SQL:" + ex.ToString() + "\n");
            }
            return myList;
        }
        #region
        public override void Cleanup()
        {
        }
    }
}

#endregion