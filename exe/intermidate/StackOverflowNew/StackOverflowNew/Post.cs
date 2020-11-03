using System;

namespace StackOverflowNew
{
    public class Post
    {
        public string Title { get; set; }
        public string Describtion { get; set; }

        public int VoteCount { get; private set; }
        public DateTime CreationTime { get; private set; }

        public Post(string title, string describtion)
        {
            this.CreationTime = DateTime.Now;
            this.VoteCount = 0;
            this.Title = title;
            this.Describtion = describtion;
        }

        public void UpVote()
        {
            this.VoteCount++;
        }

        public void DownVote()
        {
            this.VoteCount--;
        }

        public int GetCount()
        {
            return VoteCount;
        }

        public string GetTitle()
        {
            return Title;
        }
        public string GetDescribtion()
        {
            return Describtion;
        }
        public DateTime GetTime()
        {
            return CreationTime;
        }




    }
}
