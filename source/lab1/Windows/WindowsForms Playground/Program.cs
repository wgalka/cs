using WindowsForms_Playground.kontrolki;
namespace WindowsForms_Playground {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize(); //Włączenie DPI awareness (lepsze skalowanie na ekranach 4K). Ustawienie domyślnej czcionki(np.Segoe UI zamiast klasycznej). Włączenie wizualnych stylów.

            Application.Run(new TableViewExample());
            Application.Run(new NotepadExample()); //Rozpoczyna główną pętlę aplikacji Windows Forms – czyli tzw. "message loop", która: Obsługuje kliknięcia, klawiaturę, rysowanie, zdarzenia itp. Utrzymuje aplikację przy życiu, dopóki główne okno nie zostanie zamknięte. Bez niej okno od razu znika i program kończy działanie.
        }
    }
}