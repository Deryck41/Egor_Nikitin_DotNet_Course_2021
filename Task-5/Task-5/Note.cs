using System;

class Note
{
    public int id { get; private set; }
    public string title { get; private set; }
    public string content { get; private set; }

    public Note(int newId, string newTitle, string NewContent)
    {
        id = newId;
        title = newTitle;
        content = NewContent;
    }

    public void ChangeContent(string newContent) => content = newContent;

    public void ChangeTitle(string newTitle) => title = newTitle;

    public void AppendContent(string contentToAppend) => content += contentToAppend;
}
