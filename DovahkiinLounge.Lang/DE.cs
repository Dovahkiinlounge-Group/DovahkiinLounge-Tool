using System.Resources;

namespace DovahkiinLounge.Lang
{
    public class DE
    {
        public static ResourceManager ResourceManager { get; } = new ResourceManager(typeof(DE));
        public static string DovahmemDLL => "Gefunden: DovahkiinLounge.Memory.dll, Cheats Aktiviert,Timer Gestoppt";
        public static string Infos_More => "Mehr";
        public static string WelcomeConsole => "Willkommen bei xCheats";
        public static string GFWLDwn => "Games For Windows Live wurde von Microsoft deaktiviert. Hier können Sie das Offline-Setup herunterladen";
        public static string FourGBPatchTxt => "Dies ist ein Patcher für 32Bit alte Spiele um die 4GB für 64Bit zu patchen";
        public static string RemoveBtn => "Deinstallieren";
        public static string OpenBtn => "Starten";
        public static string DwnBtn => "Herunterladen";
        public static string DwnExtractSuc => "Download und Extraktion erfolgreich abgeschlossen.";
        public static string InitConsole => "Deaktivieren der Funktion zum Ausblenden der Konsole nach dem Initialisieren";
        public static string AddStart => "Auto Start erfolgreich Erstellt";
        public static string RmStart => "Auto Start erfolgreich Entfernt";
        public static string DovahmemDLLF => "Nicht-Gefunden: DovahkiinLounge.Memory.dll, CheatsDeaktiviert.";
        public static string BUT_OK = "Öffnen";
        public static string BUT_CANCEL = "Ignorieren";
        public static string BUT_ABORT = "Stoppen";
        public static string BUT_RETRY = "Fortfahren";
        public static string BUT_IGNORE = "Ignorieren";
        public static string BUT_YES = "Ja";
        public static string BUT_NO = "Nein";
    }
}
