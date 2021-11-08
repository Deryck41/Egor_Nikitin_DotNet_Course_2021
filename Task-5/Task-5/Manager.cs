using System;
using System.Collections.Generic;

class Manager
{
    public static void PrintListOfNotes(List<Note> notes)
    {
        for (int i = 0; i < notes.Count; i++)
        {
            Console.WriteLine($"{notes[i].id}\t{notes[i].title}");
        }
    }

    public static string MultilineInput()
    {
        string line = "";
        string summaryString = "";
        do
        {
            summaryString += line + "\n";
            line = Console.ReadLine();
        } while (!String.IsNullOrWhiteSpace(line));

        return summaryString;
    }

    public static Note GetNoteObject(int id)
    {
        Console.WriteLine("Enter Title:\n-----------------------------------------------");
        string newTitle = Console.ReadLine();
        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Enter Note:\n-----------------------------------------------");
        string newContent = MultilineInput();
        Console.WriteLine("-----------------------------------------------");

        return new Note(id, newTitle, newContent);
    }

    public static void PrintNote(Note currentNote)
    {
        Console.WriteLine($"id: {currentNote.id}\n");
        Console.WriteLine($"title: {currentNote.title}\n");
        Console.WriteLine(currentNote.content);
    }

    public static void PrintHelp()
    {
        Console.WriteLine("command '!q' lets you exit the program\n" +
            "command '!list' displays a list of existing notes\n" +
            "command '!add' adds a note\n" +
            "command '!goto' navigates to the note and allows you to view and edit the current note\n" +
            "when you have navigated to a note, you can run the following commands:\n" +
            "command '!view' shows the current note\n" +
            "");
    }
}
