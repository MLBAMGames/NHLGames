using System;
using System.IO;
using System.Text;
using System.Windows.Documents;
using System.Windows.Media;
using MahApps.Metro.Controls;
using NHLGames.WPF.Properties;
using RichTextBox = System.Windows.Controls.RichTextBox;

namespace NHLGames.WPF.Utilities
{
    public class ConsoleRedirectStreamWriterWpf : TextWriter
    {
        public override Encoding Encoding => Encoding.UTF8;

        private readonly RichTextBox _output;
        private readonly Brush _outputForegroundBrush;

        public ConsoleRedirectStreamWriterWpf(RichTextBox output)
        {
            _output = output;
            _outputForegroundBrush = _output.Foreground;
        }

        public override void WriteLine(string value)
        {
            string lastError = null;
            base.WriteLine(value);

            _output.BeginInvoke(() =>
            {
                int startIndex = 0;
                int length = 0;

                string start = null;
                string end = null;

                OutputType type = OutputType.Normal;
                string timestamp = string.Format(Resources.msgDateTimeNow, DateTime.Now.ToString("HH:mm:ss"));
                
                if (value.ToLower().IndexOf(Resources.errorDetection, StringComparison.Ordinal) == 0 || value.ToLower().IndexOf(Resources.errorExceptionDetection, StringComparison.Ordinal) == 0)
                {
                    type = OutputType.Error;
                    length = value.IndexOf(Resources.errorDoubleDot, StringComparison.Ordinal);
                }
                else if (value.IndexOf(Resources.errorCliStreamlink, StringComparison.Ordinal) == 0)
                {
                    type = OutputType.Cli;
                    length = 6;
                }
                else if (value.IndexOf(":", StringComparison.Ordinal) > -1)
                {
                    type = OutputType.Status;
                    length = value.IndexOf(Resources.errorDoubleDot, StringComparison.Ordinal);
                }

                if (type == OutputType.Error)
                {
                    lastError = value;
                }
                
                _output.AppendText(timestamp);

                start = value.Substring(startIndex, length);
                end = value.Substring(length, value.Length - length);

                if (startIndex > -1)
                {
                    if (type == OutputType.Error)
                    {
                        AppendText(_output, start, Colors.Red);
                    }
                    else if (type == OutputType.Status)
                    {
                        AppendText(_output, start, Colors.Green);
                    }
                    else if (type == OutputType.Cli)
                    {
                        AppendText(_output, start, Colors.SkyBlue);
                    }

                    AppendText(_output, end, _outputForegroundBrush);
                    _output.AppendText(Environment.NewLine);
                }

                if (lastError != null)
                {
                    Console.WriteLine(Resources.msgErrorGeneralText, Environment.NewLine, lastError);
                }

                _output.ScrollToEnd();
            });
        }

        private static void AppendText(RichTextBox box, string text, Brush brush)
        {
            try
            {
                TextRange textRange = new TextRange(box.Document.ContentEnd, box.Document.ContentEnd) { Text = text };
                textRange.ApplyPropertyValue(TextElement.ForegroundProperty, brush);
            }
            catch (FormatException)
            {

            }
        }

        private static void AppendText(RichTextBox box, string text, Color color)
        {
            AppendText(box, text, new SolidColorBrush(color));
        }
    }
}

