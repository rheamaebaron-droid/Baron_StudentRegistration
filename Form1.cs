using System.Text.Json;

namespace Baron_Project1
{
    public partial class Form1 : Form
    {
        public static List<StudentObjects> students = new List<StudentObjects>();

        const string PathFile = @"C:\Users\Rhea Mae Baron\source\repos\Baron_Project1\Baron_Project1\data.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        public static void LoadFromText()
        {
            if (!File.Exists(PathFile)) return;

            string existingJson = File.ReadAllText(PathFile);
            if (string.IsNullOrWhiteSpace(existingJson)) return;

            students = JsonSerializer.Deserialize<List<StudentObjects>>(existingJson)
                       ?? new List<StudentObjects>();
        }

        public static void SaveToText()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(students, options);

            File.WriteAllText(PathFile, jsonString);
        }
    }
}