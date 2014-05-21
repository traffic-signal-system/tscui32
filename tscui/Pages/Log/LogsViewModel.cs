namespace tscui.Pages.Log
{
    /// <summary>
    /// The ThePagesViewModel ViewModel class.
    /// </summary>
    public class LogsViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThePagesViewModel"/> class.
        /// </summary>
        public LogsViewModel()
        {
            Title = (string)App.Current.Resources.MergedDictionaries[3]["tsc_menu_log"];
        }
    }
}
