using System;
class PhotoAlbum
{
    private int numberOfPages;


    public int NumberOfPages
    {
        get { return numberOfPages; }
        set { numberOfPages = value; }
    }
    public int pages;
    public PhotoAlbum()
    {
        pages = 16;
    }
    public PhotoAlbum(int pageswant)
    {
        NumberOfPages = pageswant;
    }
    public int GetNumberOfPages()
    {
        return NumberOfPages;
    }
}
class BigPhotoAlbum
{
    public int pages;
    public BigPhotoAlbum()
    {
        pages = 64;
    }
}

class AlbumTest
{
    public int pages;
    public AlbumTest()
    {
        pages = 24;
    }
}
class Program
{
    public static void Main(string[] args)
    {

        PhotoAlbum p1 = new PhotoAlbum();
        Console.WriteLine("The default pages for the album is : " + p1.pages);
        BigPhotoAlbum bp = new BigPhotoAlbum();
        Console.WriteLine("The pages having BigPhotoAlbum is " + bp.pages);
        AlbumTest at = new AlbumTest();
        Console.WriteLine("The pages having AlbumTest is " + at.pages);
        int total = p1.pages + bp.pages + at.pages;
        Console.WriteLine("The total pages in three album is : " + total);
        Console.WriteLine("Do you need additional pages in albun ? ");
        Console.WriteLine("Press to 1 to add 0 to quit ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("Enter the number of pages you want ? ");
            int pageswant = Convert.ToInt32(Console.ReadLine());
            PhotoAlbum p = new PhotoAlbum(pageswant);
            int page = p.GetNumberOfPages();
            Console.WriteLine("The no of pages you want : " + page);

        }
        if (choice == 0)
        {
            Console.WriteLine("Thank you");
        }


    }
}