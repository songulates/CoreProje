
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    //burada bağlantı adresimizi tanımlıyacağız connection stringimizi. Context sınıfımız dbcontex clasından miras- kalıtım almakta
    //DbContext sınıfını kullanmamız için projeye using Microsoft.EntityFrameworkCore; paketinin yüklü olması gerekiuo
    public class Context:DbContext    
    {
        //override olarak onconfigure metod tanımlayacağız.  OnConfiguring isminde metod tanımladı
       //metod DbContextOptionsBuilder türünde ismide optionsBuilder olan bir parametre alacak
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            //tanımladığımız OnConfiguring metodun içerisinde connection stringi tanımlayacağız. Connection stringi tanımlamak için böyle bir yapıya ihtiyaç duyuyoruz
            optionsBuilder.UseSqlServer("server=DESKTOP-1TE9E4I;database=BlogData; integrated security=true;");
            //optionsBuilder parametresini kullanarak UseSqlServer metodunu çağırdık UseSqlServer içerisinede connection stringi tanımladık
        //Sonrasında context sınıfı içerisine veri tabanına yansıtmak istediğimiz entitiy leri tek tek yazıcaz öncesinde referans vereceğiz
        
        }
        //şimdi burda contextlerimizi yazalım. Entityleri çağırazağız.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        //Böylece context sınıfına ait Dbsetler tanımlanmış oldu
    }
}
