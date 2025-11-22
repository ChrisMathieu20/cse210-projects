using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.SetTitle("Boruto Two Blue Vortex");
        video1.SetAuthor("Christian Mathieu Ramasinjanahary");
        video1.SetLength(1200);
        
        Comment commV1 = new Comment();
        commV1.SetName("Naruto Uzumaki");
        commV1.SetText("Good anime.");
        video1.AddComment(commV1);

        Comment commV2 = new Comment();
        commV2.SetName("Minato Namikaze");
        commV2.SetText("That's awesome.");
        video1.AddComment(commV2);

        Comment commV3 = new Comment();
        commV3.SetName("Kakashi Hatake");
        commV3.SetText("I like the action in this part.");
        video1.AddComment(commV3);

        video1.DisplayVideo();
    }
}