using System;

public class MotivationalQuotes
{
    public List<string> _quotes; 
    public Random _random; 

    public MotivationalQuotes() 
    {
        _quotes = new List<string>
        
        {
            // Scriptures
            "\"By small and simple things are great things brought to pass.\" – Alma 37:6",
            "\"Faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.\" – Alma 32:21",
            "\"Trust in the Lord with all thine heart; and lean not unto thine own understanding.\" – Proverbs 3:5",

            // Hymns
            "\"Come, come, ye Saints, no toil nor labor fear; But with joy wend your way.\" – Hymn #30",
            "\"I am a child of God, and he has sent me here.\" – Hymn #301",
            "\"Let us all press on in the work of the Lord.\" – Hymn #243",

            // Prophets and Church Leaders
            "\"Be believing, be happy, don’t get discouraged. Things will work out.\" – Gordon B. Hinckley",
            "\"Your future is as bright as your faith.\" – Thomas S. Monson",
            "\"When you cannot do what you have always done, then you only do what matters most.\" – Russell M. Nelson",
            "\"The joy we feel has little to do with the circumstances of our lives and everything to do with the focus of our lives.\" – Russell M. Nelson",
            "\"God does not begin by asking our ability, only our availability.\" – Neal A. Maxwell",
            "\"We must be willing to let go of the life we have planned, so as to accept the life that is waiting for us.\" – Joseph B. Wirthlin",
            "\"Don’t you quit. You keep walking. You keep trying. There is help and happiness ahead.\" – Jeffrey R. Holland",
            "\"The Lord loves effort. He blesses our best efforts.\" – Russell M. Nelson"
        };
        
        _random = new Random();
    }
    public string GetRandomQuote()
    {
        int index = _random.Next(_quotes.Count);
        return _quotes[index];
    }
}        
