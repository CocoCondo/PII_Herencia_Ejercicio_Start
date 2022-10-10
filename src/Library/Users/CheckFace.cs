using System.Drawing;
using System;
using System.Collections;

namespace Herencia;

public static class CheckFace
{
    public static bool[] Check(User user)
    {
        bool[] FaceChecked = new bool[] {false, false};
        CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow);
        cog.Recognize(@$"{user.ProfilePicture}");
        if (cog.FaceFound)
        {
            //Console.WriteLine("Face Found!");
            FaceChecked[0] = true;
            if (cog.SmileFound)
            {
                //Console.WriteLine("Found a Smile :)");
                FaceChecked[1] = true;
            }
            else
            {
                //Console.WriteLine("No smile found :(");
                FaceChecked[1] = false;
            }
        }
        else
        {
            //Console.WriteLine("No Face Found");
            FaceChecked[0] = false;
        }
        return FaceChecked;
    }
}