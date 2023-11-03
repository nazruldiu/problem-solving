namespace NotesStore
{
    public class NotesStore
    {
        public NotesStore() { }
        Dictionary<String, String> data = new Dictionary<String, String>();
        public void AddNote(String state, String name) {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name cannot be empty");
            if (state == "foo")
                throw new ArgumentNullException("Name cannot be empty");
            data.Add(name, state);
        }
        public List<String> GetNotes(String state) { 
            List<string> note = new List<string>();

            foreach(KeyValuePair<string, string> obj in data)
            {
                if(obj.Value == state)
                    note.Add(obj.Key);
            }
            return note;
        }

        //public static int simpleArraySum(List<int> ar)
        //{
        //    int result = 0;
        //    foreach (var item in ar)
        //    {
        //        result = result + item;
        //    }
        //}
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}