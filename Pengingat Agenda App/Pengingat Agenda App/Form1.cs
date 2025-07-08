using System.Windows.Forms;

namespace Pengingat_Agenda_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                timer1.Interval = 3000; // Set timer untuk mengecek setiap 1 detik
                timer1.Start(); // Mulai timer
                timer1.Tick += timer1_Tick;
            }
        }

        // List untuk menyimpan jadwal Agenda
        private List<Jadwalagenda> jadwalAgenda = new List<Jadwalagenda>();


        private void button1_Click(object sender, EventArgs e)
        {
            string Namaagenda = textBox1.Text;
            DateTime Tanggalagenda = dateTimePicker1.Value;

            // Menambahkan jadwal agenda ke dalam list
            jadwalAgenda.Add(new Jadwalagenda { Namaagenda = Namaagenda, Tanggalagenda = Tanggalagenda });

            // Menampilkan jadwal agenda di ListBox
            listBox1.Items.Add($"{Namaagenda} - {Tanggalagenda.ToShortDateString()}");

            // Kosongkan TextBox setelah menambah
            textBox1.Clear();
        }

        // Timer Tick untuk cek agenda yang akan datang
        private void timer1_Tick(object sender, EventArgs e)
        {
            var hariIni = DateTime.Now.Date;

            foreach (var jadwal in jadwalAgenda)
            {
                var satuHariSebelum = jadwal.Tanggalagenda.Date.AddDays(-1);

                // Cek untuk peringatan H-1 (besok)
                if (satuHariSebelum == hariIni && !jadwal.besokagenda)
                {
                    MessageBox.Show($"Besok ada agenda: {jadwal.Namaagenda}!");
                    jadwal.besokagenda = true;
                }

                // Cek untuk peringatan hari-H (hari ini)
                if (jadwal.Tanggalagenda.Date == hariIni && !jadwal.hariini)
                {
                    MessageBox.Show($"Hari ini ada agenda: {jadwal.Namaagenda}!");
                    jadwal.hariini = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int Jadwaldipilih = listBox1.SelectedIndex;

                // Hapus dari List jadwalagenda
                jadwalAgenda.RemoveAt(Jadwaldipilih);

                // Hapus dari ListBox
                listBox1.Items.RemoveAt(Jadwaldipilih);
            }
            else
            {
                MessageBox.Show("Pilih jadwal yang ingin dihapus terlebih dahulu.");
            }
        }

        // Kelas untuk menyimpan informasi jadwal agenda
        public class Jadwalagenda
        {
            public string Namaagenda { get; set; }
            public DateTime Tanggalagenda { get; set; }
            public bool hariini { get; set; } = false;
            public bool besokagenda { get; set; } = false;
        }

    }

}
