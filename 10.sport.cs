using System;
class Sports
{
    private string team;
    public string Team
    {
        get { return team; }
        set { team = value; }
    }
    private int count;
    public int Count
    {
        get { return count; }
        set { count = value; }
    }
    public string place
    {
        get; set;
    }
    public virtual void play()
    {

    }
}

class Football : Sports
{
    string title;
    public Football(string title)
    {
        this.title = title;

    }
    public override void play()
    {
        Console.WriteLine(title);

    }

}

class Basketball : Sports
{
    string title;
    public Basketball(string title)
    {
        this.title = title;

    }
    public override void play()
    {
        Console.WriteLine(title);
    }

}

class Rugby : Sports
{
    string title;
    public Rugby(string title)
    {
        this.title = title;

    }
    public override void play()
    {
        Console.WriteLine(title);
    }

}

class program
{
    public static void Main(string[] args)
    {
        Football b = new Football("Foot ball");
        b.Count = 12;
        b.place = "Paris";
        b.Team = "PSG";
        b.play();
        Console.WriteLine(b.Count + " " + b.Team + " team players playing football in " + b.place + " stadium");

        Basketball f = new Basketball("Basket ball");
        f.Count = 50;
        f.place = "Tokiyo";
        f.Team = "CSK";
        f.play();
        Console.WriteLine(f.Count + " " + f.Team + " team players playing football in " + f.place + " stadium");

        Rugby r = new Rugby("Rugby");
        r.Count = 30;
        r.place = "Indian";
        r.Team = "RCB";
        r.play();
        Console.WriteLine(r.Count + " " + r.Team + " team players playing football in " + r.place + " stadium");
    }
}


