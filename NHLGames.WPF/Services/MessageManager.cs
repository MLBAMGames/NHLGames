using System.Threading.Tasks;
using MahApps.Metro.Controls.Dialogs;

namespace NHLGames.WPF.Services
{
    public class MessageManager
    {
        public static Task<MessageDialogResult> ShowMessageAsync(object context, string title, string message,
            MessageDialogStyle style = MessageDialogStyle.Affirmative, MetroDialogSettings settings = null)
        {
            var metroDialogSettings = new MetroDialogSettings {ColorScheme = MetroDialogColorScheme.Accented};

            if (settings != null)
            {
                metroDialogSettings.AffirmativeButtonText = settings.AffirmativeButtonText;
                metroDialogSettings.NegativeButtonText = settings.NegativeButtonText;
            }

            return  DialogCoordinator.Instance.ShowMessageAsync(context, title, message,style, metroDialogSettings);
        }
    }
}
