using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_34
{
    public partial class TimerForm : Form
    {
        private int _seconds;
        private int _minutes;
        private string _secondsString;
        private string _minutesString;
        public TimerForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_seconds >= 60) {
                _minutes++; 
                _seconds = 0;
            }
            _seconds++;

            if (_minutes < 10) _minutesString = $"0{_minutes}";
            else _minutesString = _minutes.ToString();
            
            if(_seconds < 10) _secondsString = $"0{_seconds}";
            else _secondsString = _seconds.ToString();

            TimerLabel.Text = $"{_minutesString}:{_secondsString}";
        }
    }
}
