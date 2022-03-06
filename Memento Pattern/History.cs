using System.Collections.Generic;
using System.Linq;

namespace Memento_Pattern
{
    public class History
    {
        public List<EditorState> States { get; private set; }

        public History()
        {
            States = new List<EditorState>();
        }

        public void Push(EditorState state)
        {
            States.Add(state);
        }

        public EditorState Pop()
        {
            var state = States.Last();
            States.RemoveAt(States.Count - 1);

            return state;
        }
    }
}
