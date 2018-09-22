using System;
using System.Collections.Generic;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        return Pop(this);
    }

    private int index = 0;
    Dictionary<int,string> playList = new Dictionary<int, string>();
    public bool Pop(Song song)
    {
        if (playList.ContainsValue(song.name))
        {
            return true;
        }else if (song.NextSong == null)
        {
            return false;
        }
        else
        {
            playList.Add(index, song.name);
            ++index;
            return Pop(song.NextSong);
        }
    }
    
    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");
      
        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
        
    }
}