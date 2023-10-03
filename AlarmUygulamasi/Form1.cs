using System.Media;

namespace AlarmUygulamasi
{
    public partial class Form1 : Form
    {
        bool alarmKuruluMu = false;
        DateTime kuruluZaman;

        public Form1()
        {
            InitializeComponent();
            dtpZaman.Value = DateTime.Now.AddSeconds(10);
        }

        private void btnKur_Click(object sender, EventArgs e)
        {
            DateTime hedef = dtpZaman.Value;

            if (hedef < DateTime.Now)
            {
                MessageBox.Show("Ge�mi� bir zaman se�tiniz.");
            }
            else if (btnKur.Text == "Alarm Kur")
            {
                kuruluZaman = hedef;
                alarmKuruluMu = true;
                lblDurum.Text = $"{kuruluZaman} tarihine alarm kuruldu.";
                dtpZaman.Enabled = false;
                btnKur.Text = "�ptal Et";
            }
            else
            {
                IptalEt();
            }
        }

        void IptalEt()
        {
            kuruluZaman = DateTime.MinValue;
            alarmKuruluMu = false;
            lblDurum.Text = "Alarm kurulu de�il.";
            dtpZaman.Enabled = true;
            btnKur.Text = "Alarm Kur";
        }

        SoundPlayer soundPlayer = new SoundPlayer("alarm.wav");

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (alarmKuruluMu && kuruluZaman <= DateTime.Now)
            {
                IptalEt();
                soundPlayer.Play();
                MessageBox.Show("Alarm� Sustur");
                soundPlayer.Stop();
            }
        }
    }
}