using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Steps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackgroundColor = Color.LightBlue;
        }
        private void Count(object senser, EventArgs e)
        {
            float steps = Convert.ToSingle(this.steps.Text);
            float step_size = Convert.ToSingle(this.step_size.Text);
            float distance = (Convert.ToSingle(steps) * Convert.ToSingle(step_size)) / 1000;
            this.distance.Text = distance.ToString() + "km";
        }
    }
}
