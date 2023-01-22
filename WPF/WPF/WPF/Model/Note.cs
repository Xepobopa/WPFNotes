using WPF.Model.Labels;

namespace WPF.Model
{
    public class Note
    {
        public int Id { get; private set; }
        public string? Title { get; private set; }
        public string? Text { get; private set; }
        public Label? Label { get; set; }
    }
}
