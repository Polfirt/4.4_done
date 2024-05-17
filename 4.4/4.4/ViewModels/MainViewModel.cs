using System.Collections.Generic;
using _4._4.Models;
using System;
using System.Diagnostics;
namespace _4._4.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        BlogEntity = new BlogsEntity()
        {
            Article = "Жесткие новости",
            Paragraphs = new List<string> { "Я делал эту прогу до 6 часов утра и чувствую себя настолько плохо, насколько можно. Шок. Оставлю картинку хорошую в общем." },
            ImagePath = "moun.jpg",
            Tags = new List<string> { "Tag 1", "Tag 2", "Tag 3", "Tag 4" }
        };
        NewsEntities = new List<NewsEntity>
        {
            new() { Text = "Здесь могла быть ваша реклама", Date = DateTime.Now.AddDays(-1) },
            new() { Text = "Ахмат сила", Date = DateTime.Now.AddDays(-7) }
        };
    }
    public BlogsEntity BlogEntity { get; set; }
    public List<NewsEntity> NewsEntities { get; set; }
}
