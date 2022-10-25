namespace Hotel_price
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent();}
        private void label1_Click(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e)
        {
            try{var stays = double.Parse(this.numberOfStays.Text);var month = string.Format(monthStay.Text);
                if (stays > 14)
                {
                    double result1 = stays * ApartmentPerNight(month); double total1 = result1 - (result1 * ApartmentDiscount(month));
                    double result2 = stays * StudioPerNight(month); double total2 = result2 - (result2 * StudioDiscount(month));
                    OutputApartment.Text = result1.ToString() + " lv. ";
                    OutputStudio.Text = total2.ToString() + " lv. ";
                }
                else if (stays > 7 && stays <= 14)
                {
                    double result1 = stays * ApartmentPerNight(month); 
                    double result2 = stays * StudioPerNight(month); double total2 = result2 - (result2 * MayAndOctSeven(month));
                    OutputApartment.Text = result1.ToString() + " lv. ";
                    OutputStudio.Text = total2.ToString() + " lv. ";
                }
                else
                {
                    double result1 = stays * ApartmentPerNight(month);
                    double result2 = stays * StudioPerNight(month);
                    OutputApartment.Text = result1.ToString() + " lv.";
                    OutputStudio.Text = result2.ToString() + " lv. ";
                }
            }
            catch { OutputApartment.Text = "error"; OutputStudio.Text = "error"; }
            double MayAndOctSeven(string month) => month switch { "may" => 0.05, "june" => 0, "july" => 0, "august" => 0, "september" => 0, "october" => 0.05, _ => throw new ArgumentException("Unknown unit type.") };
            double ApartmentDiscount(string month) => month switch { "may" => 0.1, "june" => 0.1, "july" => 0.1, "august" => 0.1, "september" => 0.1, "october" => 0.1, _ => throw new ArgumentException("Unknown unit type.") };
            double StudioDiscount(string month) => month switch { "may" => 0.3, "june" => 0.20, "july" => 0, "august" => 0, "september" => 0.20, "october" => 0.30, _ => throw new ArgumentException("Unknown unit type.") };
            double StudioPerNight(string month) => month switch { "may" => 50, "june" => 75.20, "july" => 76, "august" => 76, "september" => 75.20, "october" => 50, _ => throw new ArgumentException("Unknown unit type.") };
            double ApartmentPerNight(string unit) => unit switch { "may" => 65, "june" => 68.70, "july" => 77, "august" => 77, "september" => 68.70, "october" => 65, _ => throw new ArgumentException("Unknown unit type.") };

        }

        private object StudioPerNight(Action<object, EventArgs> month){ throw new NotImplementedException();}
        private void OutputStudio_TextChanged(object sender, EventArgs e){}
        private void OutputApaartment_TextChanged(object sender, EventArgs e){}
        private void monthStay_TextChanged(object sender, EventArgs e){}
        private void numberOfStays_TextChanged(object sender, EventArgs e){}
    }
}