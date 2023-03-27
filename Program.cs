using System;

namespace Jurnal_MOD6_1302210125
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vid1 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid2 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid3 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid4 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid5 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid6 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid7 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid8 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid9 = new SayaTubeVideo("Asik Asik");
            SayaTubeVideo vid10 = new SayaTubeVideo("Asik Asik");

            SayaTubeUser user = new SayaTubeUser("MochamadRifqiBarliant");
            user.AddVideo(vid1);
            user.AddVideo(vid2);
            user.AddVideo(vid3);
            user.AddVideo(vid4);
            user.AddVideo(vid5);
            user.AddVideo(vid6);
            user.AddVideo(vid7);
            user.AddVideo(vid8);
            user.AddVideo(vid9);
            user.AddVideo(vid10);

            user.PrintAllVideoPlaycount();
        }
    }
}
