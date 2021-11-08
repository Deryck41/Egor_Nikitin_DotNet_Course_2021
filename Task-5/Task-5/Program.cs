using System;
using System.Collections.Generic;


namespace Task_5
{
    
    class Program
    {

        static void NoteMenu(int index, ref List<Note> notes)
        {
            bool localMenu = true;

            while (localMenu)
            {
                Console.Write(">>>>> ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "!back":
                        localMenu = false;
                        break;
                    case "!view":
                        Manager.PrintNote(notes[index]);
                        break;
                    case "!edittitle":
                        Console.WriteLine("Enter new title: ");
                        notes[index].ChangeTitle(Console.ReadLine());
                        break;
                    case "!edittext":
                        Console.WriteLine("Enter new content: ");
                        notes[index].ChangeContent(Manager.MultilineInput());
                        break;
                    case "!appendtext":
                        Console.WriteLine("Enter content to append: ");
                        notes[index].AppendContent(Manager.MultilineInput());
                        break;
                }
            }
        }
   
        static void Main(string[] args)
        {
            int currentId = 0;
            var notes = new List<Note>();
            bool menu = true;

            while (menu)
            {
                Console.Write(">>> ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "!q":
                        menu = false;
                        break;
                    case "!list":
                        Manager.PrintListOfNotes(notes);
                        break;
                    case "!add":
                        notes.Add(Manager.GetNoteObject(currentId++));
                        break;
                    case "!help":
                        Manager.PrintHelp();
                        break;
                    case "!goto":
                        bool sucessIndexInput = int.TryParse(Console.ReadLine(), out int index);

                        if (sucessIndexInput && index >= 0 && index < notes.Count)
                        {
                            NoteMenu(index, ref notes);
                        }
                        else
                        {
                            Console.WriteLine("Input existing note id!");
                        }
                        break;
                        
                }
            }
        }
    }
}
