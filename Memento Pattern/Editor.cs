using System;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }

    }
}
