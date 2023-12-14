using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Info on this youtube video");
        
        youtube_vid vid1 = new youtube_vid(
            "I just bought a mega yahat!!!",
            "yurtastic",
            "741"
        );
        Comments vid1_comment1 = new Comments(
            "Jack",
            "Nice video!"
        );
        Comments vid1_comment2 = new Comments(
            "Matt",
            "Try harder!"
        );
        Comments vid1_comment3 = new Comments(
            "Scurnner",
            "I am not a fan of you showing off your wealth."
        );
        Comments vid1_comment4 = new Comments(
            "yurani123",
            "Next time try to get yourself a large VR set"
        );
        vid1.setComments(vid1_comment1);
        vid1.setComments(vid1_comment2);
        vid1.setComments(vid1_comment3);
        vid1.setComments(vid1_comment4);

        List<Comments> vid1_comments = new List<Comments>();
        vid1_comments.Add(vid1_comment1);
        vid1_comments.Add(vid1_comment2);
        vid1_comments.Add(vid1_comment3);
        vid1_comments.Add(vid1_comment4);


        vid1.vid_details();
        vid1.displayAllComments(vid1_comments);

        youtube_vid vid2 = new youtube_vid(
            "How I got to the top of Candy Crush",
            "Minispurn",
            "1134"
        );
        Comments vid2_comment1 = new Comments(
            "help67sd",
            "Congratulations"
        );
        Comments vid2_comment2 = new Comments(
            "Darksoul539",
            "Dang you are really good at predicting those candy falls"
        );
        Comments vid2_comment3 = new Comments(
            "poptartfantazy1",
            "Would be great if you can help me"
        );
        Comments vid2_comment4 = new Comments(
            "fallenangelcrackers",
            "You won't get away with this for long"
        );
        vid2.setComments(vid2_comment1);
        vid2.setComments(vid2_comment2);
        vid2.setComments(vid2_comment3);
        vid2.setComments(vid2_comment4);

        List<Comments> vid2_comments = new List<Comments>();
        vid2_comments.Add(vid2_comment1);
        vid2_comments.Add(vid2_comment2);
        vid2_comments.Add(vid2_comment3);
        vid2_comments.Add(vid2_comment4);


        vid2.vid_details();
        vid2.displayAllComments(vid2_comments);

        youtube_vid vid3 = new youtube_vid(
            "How to build a chair from scratch",
            "Woodman3000",
            "984"
        );
        Comments vid3_comment1 = new Comments(
            "gbamann",
            "I love how creative you are"
        );
        Comments vid3_comment2 = new Comments(
            "YentonHarchor",
            "I am beyond your craft!"
        );
        Comments vid3_comment3 = new Comments(
            "Ihavefallen",
            "This is easy and fun. I should do this with my kids."
        );
        Comments vid3_comment4 = new Comments(
            "Avalinow3456",
            "Give this man craftsman of the year award"
        );
        vid3.setComments(vid3_comment1);
        vid3.setComments(vid3_comment2);
        vid3.setComments(vid3_comment3);
        vid3.setComments(vid3_comment4);

        List<Comments> vid3_comments = new List<Comments>();
        vid3_comments.Add(vid3_comment1);
        vid3_comments.Add(vid3_comment2);
        vid3_comments.Add(vid3_comment3);
        vid3_comments.Add(vid3_comment4);


        vid3.vid_details();
        vid3.displayAllComments(vid3_comments);

        youtube_vid vid4 = new youtube_vid(
            "Worlds fate part 9 ,All have fallen",
            "Porter of man",
            "6753"
        );
        Comments vid4_comment1 = new Comments(
            "skilled gamer",
            "I did not see that coming 56:43"
        );
        Comments vid4_comment2 = new Comments(
            "Herofun",
            "That plot twist was insane"
        );
        Comments vid4_comment3 = new Comments(
            "funfamily",
            "Why is he so evil."
        );
        Comments vid4_comment4 = new Comments(
            "yurasore",
            "Seeing your recation is on par with my reaction"
        );
        vid4.setComments(vid4_comment1);
        vid4.setComments(vid4_comment2);
        vid4.setComments(vid4_comment3);
        vid4.setComments(vid4_comment4);

        List<Comments> vid4_comments = new List<Comments>();
        vid4_comments.Add(vid4_comment1);
        vid4_comments.Add(vid4_comment2);
        vid4_comments.Add(vid4_comment3);
        vid4_comments.Add(vid4_comment4);


        vid4.vid_details();
        vid4.displayAllComments(vid4_comments);
    }
    
}