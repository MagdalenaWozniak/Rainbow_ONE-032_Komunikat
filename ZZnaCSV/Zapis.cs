using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunikat
{
    public class Zapis
    {

        public int KAZ_GIDTyp { get; set; }
        public int KAZ_GIDFirma { get; set; }
        public int KAZ_GIDNumer { get; set; }
        public int KAZ_GIDLp { get; set; }
        public int KAZ_KRPTyp { get; set; }
        public int KAZ_KRPFirma { get; set; }
        public int KAZ_KRPNumer { get; set; }
        public int KAZ_KRPLp { get; set; }
        public string KAZ_Rok { get; set; }
        public string KAZ_Seria { get; set; }
        public string KAZ_NumerKwitu { get; set; }
        public string KAZ_NumerDokumentu { get; set; }
        public int KAZ_KAOTyp { get; set; }
        public int KAZ_KAOFirma { get; set; }
        public int KAZ_KAONumer { get; set; }
        public int KAZ_KAOLp { get; set; }
        public int KAZ_KNTTyp { get; set; }
        public int KAZ_KNTFirma { get; set; }
        public int KAZ_KNTNumer { get; set; }
        public int KAZ_KNTLp { get; set; }
        public string KAZ_KontoPrzec { get; set; }
        public string KAZ_KontoPrzecR { get; set; }
        public int KAZ_DataZapisu { get; set; }
        public int KAZ_DataDokumentu { get; set; }
        public int KAZ_RP { get; set; }
        public string KAZ_Znak { get; set; }
        public double KAZ_Kwota { get; set; }
        public double KAZ_Pozostaje { get; set; }
        public string KAZ_Waluta { get; set; }
        public string KAZ_NrKursu { get; set; }
        public double KAZ_KursL { get; set; }
        public double KAZ_KursM { get; set; }
        public string KAZ_Rozliczony { get; set; }
        public string KAZ_Tresc { get; set; }
        public int KAZ_TStamp { get; set; }
        public int KAZ_OpeTypR { get; set; }
        public int KAZ_OpeFirmaR { get; set; }
        public int KAZ_OpeNumerR { get; set; }
        public int KAZ_OpeLpR { get; set; }
        public int KAZ_OpeTypB { get; set; }
        public int KAZ_OpeFirmaB { get; set; }
        public int KAZ_OpeNumerB { get; set; }
        public int KAZ_OpeLpB { get; set; }
        public string KAZ_CiagNumeracji { get; set; }
        public string KAZ_Zaksiegowano { get; set; }
        public int KAZ_Aktywny { get; set; }
        public int KAZ_ICVTStamp { get; set; }
        public string KAZ_ICVStatus { get; set; }
        public string KAZ_ICVNumer { get; set; }
        public string KAZ_WalutaRoz { get; set; }
        public double KAZ_KwotaRoz { get; set; }
        public double KAZ_PozostajeRoz { get; set; }
        public double KAZ_KwotaSys { get; set; }
        public double KAZ_PozostajeSys { get; set; }
        public double KAZ_PozostajeWycena { get; set; }
        public double KAZ_PozostajeWycenaSys { get; set; }
        public double KAZ_WycenaRK { get; set; }
        public double KAZ_WycenaRKStan { get; set; }
        public string KAZ_DokID { get; set; }
        public int KAZ_KNDTyp { get; set; }
        public int KAZ_KNDFirma { get; set; }
        public int KAZ_KNDNumer { get; set; }
        public int KAZ_KNDLp { get; set; }
        public string KAZ_CechaOpis { get; set; }
        public string KAZ_Zaliczka { get; set; }
        public string KAZ_Anulowany { get; set; }
        public string KAZ_StRIdW { get; set; }
        public string KAZ_Opis { get; set; }
        public string KAZ_OPETypRm { get; set; }
        public string KAZ_OPEFirmaRm { get; set; }
        public string KAZ_OPENumerRm { get; set; }
        public string KAZ_OPELpRm { get; set; }
        public string KAZ_OPETypBm { get; set; }
        public string KAZ_OPEFirmaBm { get; set; }
        public string KAZ_OPENumerBm { get; set; }
        public string KAZ_OPELpBm { get; set; }
        public string KAZ_TStampM { get; set; }
        public string KAZ_StanRealizacji { get; set; }
        public string KAZ_CzasZapisu { get; set; }
        public string KAZ_Miesiac { get; set; }
        public string KAZ_OkrId { get; set; }
        public string KAZ_Wyceniony { get; set; }
        public string KAZ_WycenaKolejnosc { get; set; }
        public string KAZ_KursWgWyceny { get; set; }
        public string KAZ_Wynagrodzenie { get; set; }
        public string KAZ_ZapisZerujacy { get; set; }
        public string KAZ_RaportBO { get; set; }
        public string KAZ_ZewnetrznyId { get; set; }
        public string KAZ_ZewnetrznySys { get; set; }
        public string KAZ_ZewnetrznyTyp { get; set; }
        public string KAZ_Lokata { get; set; }
        public string KAZ_LokataTermin { get; set; }
        public string KAZ_LokataTypId { get; set; }
        public string KAZ_LokataOtwNumer { get; set; }
        public string KAZ_LokataNrRachunku { get; set; }
        public string KAZ_LokataNRB { get; set; }
        public string KAZ_ZWyciagu { get; set; }
        public string KAZ_CDC { get; set; }
        public string KAZ_TrescCDC { get; set; }
        public string KAZ_WirtualnyEQ { get; set; }
        public string KAZ_NrRachunku { get; set; }
        public string KAZ_SplitPNumer { get; set; }
        public string KAZ_BankKodOperacji { get; set; }
        public string KAZ_GUID { get; set; }
        public string KAZ_OperatorPOS { get; set; }
        public string KAZ_KontrahentCDC { get; set; }
        public string KAZ_DoWyjasnienia { get; set; }
        public string KAZ_EndToEndId { get; set; }
        public string KAZ_AutoRozliczenie { get; set; }
        public string KAZ_BbonId { get; set; }
        public string KAZ_WTrakciePrzetwarzania { get; set; }



        public Zapis(string KAZ_GIDTyp, string KAZ_GIDFirma, string KAZ_GIDNumer, string KAZ_GIDLp, string KAZ_KRPTyp, string KAZ_KRPFirma, string KAZ_KRPNumer, string KAZ_KRPLp, string KAZ_Rok, string KAZ_Seria,
                    string KAZ_NumerKwitu, string KAZ_NumerDokumentu, string KAZ_KAOTyp, string KAZ_KAOFirma, string KAZ_KAONumer, string KAZ_KAOLp, string KAZ_KNTTyp, string KAZ_KNTFirma, string KAZ_KNTNumer,
                    string KAZ_KNTLp, string KAZ_KontoPrzec, string KAZ_KontoPrzecR, string KAZ_DataZapisu, string KAZ_DataDokumentu, string KAZ_RP, string KAZ_Znak, string KAZ_Kwota, string KAZ_Pozostaje,
                    string KAZ_Waluta, string KAZ_NrKursu, string KAZ_KursL, string KAZ_KursM, string KAZ_Rozliczony, string KAZ_Tresc, string KAZ_TStamp, string KAZ_OpeTypR, string KAZ_OpeFirmaR,
                    string KAZ_OpeNumerR, string KAZ_OpeLpR, string KAZ_OpeTypB, string KAZ_OpeFirmaB, string KAZ_OpeNumerB, string KAZ_OpeLpB, string KAZ_CiagNumeracji, string KAZ_Zaksiegowano,
                    string KAZ_Aktywny, string KAZ_ICVTStamp, string KAZ_ICVStatus, string KAZ_ICVNumer, string KAZ_WalutaRoz, string KAZ_KwotaRoz, string KAZ_PozostajeRoz, string KAZ_KwotaSys,
                    string KAZ_PozostajeSys, string KAZ_PozostajeWycena, string KAZ_PozostajeWycenaSys, string KAZ_WycenaRK, string KAZ_WycenaRKStan, string KAZ_DokID, string KAZ_KNDTyp, string KAZ_KNDFirma,
                    string KAZ_KNDNumer, string KAZ_KNDLp, string KAZ_CechaOpis, string KAZ_Zaliczka, string KAZ_Anulowany, string KAZ_StRIdW, string KAZ_Opis, string KAZ_OPETypRm, string KAZ_OPEFirmaRm,
                    string KAZ_OPENumerRm, string KAZ_OPELpRm, string KAZ_OPETypBm, string KAZ_OPEFirmaBm, string KAZ_OPENumerBm, string KAZ_OPELpBm, string KAZ_TStampM, string KAZ_StanRealizacji,
                    string KAZ_CzasZapisu, string KAZ_Miesiac, string KAZ_OkrId, string KAZ_Wyceniony, string KAZ_WycenaKolejnosc, string KAZ_KursWgWyceny, string KAZ_Wynagrodzenie, string KAZ_ZapisZerujacy,
                    string KAZ_RaportBO, string KAZ_ZewnetrznyId, string KAZ_ZewnetrznySys, string KAZ_ZewnetrznyTyp, string KAZ_Lokata, string KAZ_LokataTermin, string KAZ_LokataTypId, string KAZ_LokataOtwNumer,
                    string KAZ_LokataNrRachunku, string KAZ_LokataNRB, string KAZ_ZWyciagu, string KAZ_CDC, string KAZ_TrescCDC, string KAZ_WirtualnyEQ, string KAZ_NrRachunku, string KAZ_SplitPNumer,
                    string KAZ_BankKodOperacji, string KAZ_GUID, string KAZ_OperatorPOS, string KAZ_KontrahentCDC, string KAZ_DoWyjasnienia, string KAZ_EndToEndId, string KAZ_AutoRozliczenie, string KAZ_BbonId,
                    string KAZ_WTrakciePrzetwarzania)
        {
            this.KAZ_GIDTyp = Convert.ToInt32(KAZ_GIDTyp);
            this.KAZ_GIDFirma = Convert.ToInt32(KAZ_GIDFirma);
            this.KAZ_GIDNumer = Convert.ToInt32(KAZ_GIDNumer);
            this.KAZ_GIDLp = Convert.ToInt32(KAZ_GIDLp);
            this.KAZ_KRPTyp = Convert.ToInt32(KAZ_KRPTyp);
            this.KAZ_KRPFirma = Convert.ToInt32(KAZ_KRPFirma);
            this.KAZ_KRPNumer = Convert.ToInt32(KAZ_KRPNumer);
            this.KAZ_KRPLp = Convert.ToInt32(KAZ_KRPLp);
            this.KAZ_Rok = KAZ_Rok;
            this.KAZ_Seria = KAZ_Seria;
            this.KAZ_NumerKwitu = KAZ_NumerKwitu;
            this.KAZ_NumerDokumentu = KAZ_NumerDokumentu;
            this.KAZ_KAOTyp = Convert.ToInt32(KAZ_KAOTyp);
            this.KAZ_KAOFirma = Convert.ToInt32(KAZ_KAOFirma);
            this.KAZ_KAONumer = Convert.ToInt32(KAZ_KAONumer);
            this.KAZ_KAOLp = Convert.ToInt32(KAZ_KAOLp);
            this.KAZ_KNTTyp = Convert.ToInt32(KAZ_KNTTyp);
            this.KAZ_KNTFirma = Convert.ToInt32(KAZ_KNTFirma);
            this.KAZ_KNTNumer = Convert.ToInt32(KAZ_KNTNumer);
            this.KAZ_KNTLp = Convert.ToInt32(KAZ_KNTLp);
            this.KAZ_KontoPrzec = KAZ_KontoPrzec;
            this.KAZ_KontoPrzecR = KAZ_KontoPrzecR;
            this.KAZ_DataZapisu = Convert.ToInt32(KAZ_DataZapisu);
            this.KAZ_DataDokumentu = Convert.ToInt32(KAZ_DataZapisu);
            this.KAZ_RP = Convert.ToInt32(KAZ_RP);
            this.KAZ_Znak = KAZ_Znak;
            this.KAZ_Kwota = Convert.ToDouble(KAZ_Kwota);
            this.KAZ_Pozostaje = Convert.ToDouble(KAZ_Pozostaje);
            this.KAZ_Waluta = KAZ_Waluta;
            this.KAZ_NrKursu = KAZ_NrKursu;
            this.KAZ_KursL = Convert.ToDouble(KAZ_KursL);
            this.KAZ_KursM = Convert.ToDouble(KAZ_KursM);
            this.KAZ_Rozliczony = KAZ_Rozliczony;
            this.KAZ_Tresc = KAZ_Tresc;
            this.KAZ_TStamp = Convert.ToInt32(KAZ_TStamp);
            this.KAZ_OpeTypR = Convert.ToInt32(KAZ_OpeTypR);
            this.KAZ_OpeFirmaR = Convert.ToInt32(KAZ_OpeFirmaR);
            this.KAZ_OpeNumerR = Convert.ToInt32(KAZ_OpeNumerR);
            this.KAZ_OpeLpR = Convert.ToInt32(KAZ_OpeLpR);
            this.KAZ_OpeTypB = Convert.ToInt32(KAZ_OpeTypB);
            this.KAZ_OpeFirmaB = Convert.ToInt32(KAZ_OpeFirmaB);
            this.KAZ_OpeNumerB = Convert.ToInt32(KAZ_OpeNumerB);
            this.KAZ_OpeLpB = Convert.ToInt32(KAZ_OpeLpB);
            this.KAZ_CiagNumeracji = KAZ_CiagNumeracji;
            this.KAZ_Zaksiegowano = KAZ_Zaksiegowano;
            this.KAZ_Aktywny = Convert.ToInt32(KAZ_Aktywny);
            this.KAZ_ICVTStamp = Convert.ToInt32(KAZ_ICVTStamp);
            this.KAZ_ICVStatus = KAZ_ICVStatus;
            this.KAZ_ICVNumer = KAZ_ICVNumer;
            this.KAZ_WalutaRoz = KAZ_WalutaRoz;
            this.KAZ_KwotaRoz = Convert.ToDouble(KAZ_KwotaRoz);
            this.KAZ_PozostajeRoz = Convert.ToDouble(KAZ_PozostajeRoz);
            this.KAZ_KwotaSys = Convert.ToDouble(KAZ_KwotaSys);
            this.KAZ_PozostajeSys = Convert.ToDouble(KAZ_PozostajeSys);
            this.KAZ_PozostajeWycena = Convert.ToDouble(KAZ_PozostajeWycena);
            this.KAZ_PozostajeWycenaSys = Convert.ToDouble(KAZ_PozostajeWycenaSys);
            this.KAZ_WycenaRK = Convert.ToDouble(KAZ_WycenaRK);
            this.KAZ_WycenaRKStan = Convert.ToDouble(KAZ_WycenaRKStan);
            this.KAZ_DokID = KAZ_DokID;
            this.KAZ_KNDTyp = Convert.ToInt32(KAZ_KNDTyp);
            this.KAZ_KNDFirma = Convert.ToInt32(KAZ_KNDFirma);
            this.KAZ_KNDNumer = Convert.ToInt32(KAZ_KNDNumer);
            this.KAZ_KNDLp = Convert.ToInt32(KAZ_KNDLp);
            this.KAZ_CechaOpis = KAZ_CechaOpis;
            this.KAZ_Zaliczka = KAZ_Zaliczka;
            this.KAZ_Anulowany = KAZ_Anulowany;
            this.KAZ_StRIdW = KAZ_StRIdW;
            this.KAZ_Opis = KAZ_Opis;
            this.KAZ_OPETypRm = KAZ_OPETypRm;
            this.KAZ_OPEFirmaRm = KAZ_OPEFirmaRm;
            this.KAZ_OPENumerRm = KAZ_OPENumerRm;
            this.KAZ_OPELpRm = KAZ_OPELpRm;
            this.KAZ_OPETypBm = KAZ_OPETypBm;
            this.KAZ_OPEFirmaBm = KAZ_OPEFirmaBm;
            this.KAZ_OPENumerBm = KAZ_OPENumerBm;
            this.KAZ_OPELpBm = KAZ_OPELpBm;
            this.KAZ_TStampM = KAZ_TStampM;
            this.KAZ_StanRealizacji = KAZ_StanRealizacji;
            this.KAZ_CzasZapisu = KAZ_CzasZapisu;
            this.KAZ_Miesiac = KAZ_Miesiac;
            this.KAZ_OkrId = KAZ_OkrId;
            this.KAZ_Wyceniony = KAZ_Wyceniony;
            this.KAZ_WycenaKolejnosc = KAZ_WycenaKolejnosc;
            this.KAZ_KursWgWyceny = KAZ_KursWgWyceny;
            this.KAZ_Wynagrodzenie = KAZ_Wynagrodzenie;
            this.KAZ_ZapisZerujacy = KAZ_ZapisZerujacy;
            this.KAZ_RaportBO = KAZ_RaportBO;
            this.KAZ_ZewnetrznyId = KAZ_ZewnetrznyId;
            this.KAZ_ZewnetrznySys = KAZ_ZewnetrznySys;
            this.KAZ_ZewnetrznyTyp = KAZ_ZewnetrznyTyp;
            this.KAZ_Lokata = KAZ_Lokata;
            this.KAZ_LokataTermin = KAZ_LokataTermin;
            this.KAZ_LokataTypId = KAZ_LokataTypId;
            this.KAZ_LokataOtwNumer = KAZ_LokataOtwNumer;
            this.KAZ_LokataNrRachunku = KAZ_LokataNrRachunku;
            this.KAZ_LokataNRB = KAZ_LokataNRB;
            this.KAZ_ZWyciagu = KAZ_ZWyciagu;
            this.KAZ_CDC = KAZ_CDC;
            this.KAZ_TrescCDC = KAZ_TrescCDC;
            this.KAZ_WirtualnyEQ = KAZ_WirtualnyEQ;
            this.KAZ_NrRachunku = KAZ_NrRachunku;
            this.KAZ_SplitPNumer = KAZ_SplitPNumer;
            this.KAZ_BankKodOperacji = KAZ_BankKodOperacji;
            this.KAZ_GUID = KAZ_GUID;
            this.KAZ_OperatorPOS = KAZ_OperatorPOS;
            this.KAZ_KontrahentCDC = KAZ_KontrahentCDC;
            this.KAZ_DoWyjasnienia = KAZ_DoWyjasnienia;
            this.KAZ_EndToEndId = KAZ_EndToEndId;
            this.KAZ_AutoRozliczenie = KAZ_AutoRozliczenie;
            this.KAZ_BbonId = KAZ_BbonId;
            this.KAZ_WTrakciePrzetwarzania = KAZ_WTrakciePrzetwarzania;
            //this.GIDNumer = GidNumer;
            //this.GIDFirma = GidFirma;
            // this.GIDLp = GidLp;
            // this.GIDTyp = GidTyp;
        }
    }
}
