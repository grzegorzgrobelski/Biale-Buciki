namespace Biale_Buciki.Models;

public class Post {
    public String Id { get; set; }
    public String Name { get; set; }   
    public String shortDescription { get; set; }
    
    public PostStatus postStatus { get; set; }
    
    public Post(string id, string name, string description)
    {
        Id = id;
        Name = name;
        shortDescription = description;
    }
}