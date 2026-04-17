using System.Text.Json;

namespace baron_student2
{
    public partial class Main_Menu : Form
    {

        public static List<StudentObjects> students = new List<StudentObjects>();

        const string PathFile = @"C:\Users\Rhea Mae Baron\source\repos\baron-student2\baron-student2\Registration.json";

        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            LoadFromText();
        }

        public static void SaveToText()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(students, options);
            File.WriteAllText(PathFile, json);
        }

        public static void LoadFromText()
        {
            if (!File.Exists(PathFile)) return;

            string json = File.ReadAllText(PathFile);

            if (string.IsNullOrWhiteSpace(json)) return;

            students = JsonSerializer.Deserialize<List<StudentObjects>>(json)
                       ?? new List<StudentObjects>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Registration Registration = new Student_Registration();
            Registration.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_List List = new Student_List();
            List.ShowDialog();
        }
    }
}